namespace party.windows.forms
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using Microsoft.Extensions.Options;
    using party.core.enums;
    using party.core.infrastructure;
    using party.core.model;
    using party.service;
    using party.service.data;
    using party.windows.infrastructure.extensions;

    public partial class AttendanceForm : Form
    {
        protected IOptionsMonitor<Configuracion> Configuracion { get; set; }
        private readonly IProceso proceso;
        private readonly IDataService dataService;
        private readonly ICSVService csvService;
        public Invitado InvitadoTemporal { get; private set; }
        public AttendanceForm(IOptionsMonitor<Configuracion> configuracion, IProceso proceso, ICSVService csvService, IDataService dataService)
        {
            Configuracion = configuracion;
            Configuracion.OnChange(conf => Initialize());
            this.proceso = proceso;
            this.csvService = csvService;
            this.dataService = dataService;
            InitializeComponent();
        }
        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        protected void Initialize()
        {
            ClearPanels();
            UpdateConfiguracion();
            if (Configuracion != null)
            {
                SetScreenSettings(Configuracion.CurrentValue);
                MostrarBaseDatosInfo();
            }
        }
        private void UpdateConfiguracion()
        {
            Configuracion existingConfiguration = Configuracion.CurrentValue;
            if (existingConfiguration.ExistsConfiguration())
            {
                existingConfiguration.RefreshFromInfo();
            }
            if (!existingConfiguration.HasBasicValues())
            {
                ActualizarSettings();
            }
        }
        private void SetScreenSettings(Configuracion configuracion)
        {
            BackgroundImage = LoadImage(configuracion.BackgroundImage);
            Invoke(new Action(() => Text = configuracion.Title));
            Evento.Invoke(new Action(() => Evento.Text = configuracion.Event));
        }

        private static Image LoadImage(string imagePath)
        {
            Image image = null;
            if (!string.IsNullOrWhiteSpace(imagePath))
            {
                try
                {
                    image = Image.FromFile(imagePath);
                }
                catch { }
            }
            return image;
        }

        private void CheckQR_Click(object sender, EventArgs e)
        {
            ClearPanels();
            string qr = GetQRValue();
            (ResultadoCheck, Invitado, Asistente) resultado = proceso.CheckQR(qr);
            Procesar(qr, resultado);
            MostrarBaseDatosInfo();
        }

        private void ClearPanels()
        {
            panelNoExiste.Visible = false;
            panelConfirmacionEntrada.Visible = false;
            InvitadoTemporal = null;
            panelAsistenciaRegistrada.Visible = false;
        }

        protected void Procesar(string qr, (ResultadoCheck, Invitado, Asistente) resultado)
        {
            switch (resultado.Item1)
            {
                case ResultadoCheck.NoExiste:
                    CambiarBackground(Color.Red);
                    MostrarNoExisteInvitado(qr);
                    break;
                case ResultadoCheck.PuedeEntrar:
                    CambiarBackground(Color.Green);
                    MostrarInvitado(resultado.Item2);
                    break;
                case ResultadoCheck.Registrado:
                    CambiarBackground(Color.Orange);
                    MostrarAsistente(resultado.Item3);
                    break;
                case ResultadoCheck.DatosIncorrectos:
                    CambiarBackground(Color.Orange);
                    MostrarInvitadoDatosIncorrectos(resultado.Item2);
                    break;
                case ResultadoCheck.NoValue:
                    CambiarBackground(Color.Transparent);

                    break;
                default:
                    break;
            }
            ClearCode();
        }
        private void MostrarAsistente(Asistente asistente)
        {
            panelAsistenciaRegistrada.Visible = true;
            AsistenteDatosLabel.Text = $"{asistente.Nombre} \n {asistente.DNI} \n {asistente.Email} \n {asistente.Evento} \n {asistente.Entrada}";

        }
        private void MostrarInvitado(Invitado invitado)
        {
            labelAsistenteAceptado.Visible = false;
            panelConfirmacionEntrada.Visible = true;
            InvitadoTemporal = invitado;
            InvitadoTemporal.QRLeido = GetQRValue();
            CheckQR.Enabled = false;
            buttonNoVerificado.Visible = true;
            buttonVerificado.Visible = true;
            InvitadoDatosLabel.Text = $"{invitado.Nombre} \n{invitado.DNI} \n{invitado.Email} \n{invitado.Evento} \n{invitado.EventoLocal}";
        }
        private void MostrarInvitadoDatosIncorrectos(Invitado invitado)
        {
            labelAsistenteAceptado.Visible = false;
            panelConfirmacionEntrada.Visible = true;
            buttonNoVerificado.Visible = false;
            buttonVerificado.Visible = false;
            InvitadoDatosLabel.Text = $"Nombre: {invitado.Nombre} \nDNI: {invitado.DNI} \nEmail: {invitado.Email} \nLocal: {invitado.EventoLocal}\nConfirmado: {invitado.Asistencia}\n\nEl invitado no está confirmado para este evento/local. \nSe debe realizar una inserción manual previa comprobación de los datos";
        }
        private void MostrarNoExisteInvitado(string qr)
        {
            panelNoExiste.Visible = true;
            QRErrorLabel.Text = qr;
        }

        private void ClearCode()
        {
            QRText.Text = string.Empty;
        }

        private static void CambiarBackground(Color color)
        {
            //  throw new NotImplementedException($"FunctionNotDeveloped {nameof(color)}");
        }

        protected string GetQRValue()
        {
            string qr = QRText.Text;
            return qr;
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void InicializarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool confirmado = SolicitarConfirmacion("El proceso de inicializar borrará todos los datos de la aplicación sin posibilidad de recuperarlos. ¿Desea continuar?");
            if (confirmado)
            {
                QRText.Visible = false;
                CheckQR.Visible = false;
                panelAsistenciaRegistrada.Visible = false;
                panelConfirmacionEntrada.Visible = false;
                panelNoExiste.Visible = false;
                dataService.InitializeDatabase();
                QRText.Visible = true;
                CheckQR.Visible = true;
            }
            MostrarBaseDatosInfo();
        }
        private void MostrarBaseDatosInfo()
        {
            ResultValue<string> checkDatabase = ResultValue<string>.NewOk();
            int cantidadInvitados = 0;
            int cantidadInvitadosEvento = 0;
            int cantidadAsistentes = 0;
            if (dataService.ExistDatabaseFile())
            {
                checkDatabase = dataService.CheckDatabase();
                try
                {
                    cantidadInvitados = dataService.GetCountInvitados();
                }
                catch { }
                try
                {
                    cantidadAsistentes = dataService.GetCountAsistentes();
                }
                catch { }
                try
                {
                    cantidadInvitadosEvento = dataService.GetCountInvitadosEvento(Configuracion.CurrentValue.Event);
                }
                catch
                {
                }
            }

            statusDatabase.Text = $"Base de datos: {checkDatabase.Result}";
            statusInvitados.Text = $"Invitados: {cantidadInvitados}";
            statusAsistentes.Text = $" {cantidadAsistentes} asistentes de {cantidadInvitadosEvento}";
            if (cantidadInvitadosEvento > 0)
            {
                processBar.Minimum = 0;
                processBar.Maximum = cantidadInvitadosEvento;
                int porcentaje = Convert.ToInt32(100 * cantidadAsistentes / (double)cantidadInvitadosEvento);
                processBar.ToolTipText = $"{porcentaje}% {statusAsistentes.Text}";
                if (porcentaje > 100)
                {
                    processBar.Value = cantidadInvitadosEvento;
                    statusAsistentes.BackColor = Color.Red;
                }
                else
                {
                    processBar.Value = cantidadAsistentes;
                }
            }
        }
        protected static bool SolicitarConfirmacion(string mensaje)
        {
            DialogResult result = MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return (result == DialogResult.Yes);
        }
        private void CargarFicheroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Progress<int> progress = new(i => processBar.Value = i);
                IList<Invitado> invitadosLeidos = csvService.ReadFileInvitados(openFileDialog.FileName, progress).GetAwaiter().GetResult();

                dataService.LoadInvitados(invitadosLeidos, progress);
            }
            MostrarBaseDatosInfo();
        }
        private void DescargarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "CSV File|*.csv",
                Title = "Guardar fichero de asistencia"
            };
            saveFileDialog.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (!string.IsNullOrWhiteSpace(saveFileDialog.FileName))
            {
                IList<Asistente> asistentes = dataService.GetAllAsistentes();
                csvService.WriteCSV(asistentes, saveFileDialog.FileName);
            }
        }
        private void ButtonVerificado_Click(object sender, EventArgs e)
        {
            VerificarInvitado();
        }
        private void VerificarInvitado()
        {
            proceso.AceptarInvitado(InvitadoTemporal);
            buttonNoVerificado.Visible = false;
            buttonVerificado.Visible = false;
            labelAsistenteAceptado.Text = "Asistente aceptado";
            labelAsistenteAceptado.Visible = true;
            CheckQR.Enabled = true;
            MostrarBaseDatosInfo();
        }
        private void NoVerificarInvitado()
        {
            InvitadoTemporal = null;
            buttonNoVerificado.Visible = false;
            buttonVerificado.Visible = false;
            labelAsistenteAceptado.Text = "Asistente rechazado";
            labelAsistenteAceptado.Visible = true;
            CheckQR.Enabled = true;
        }
        private void ButtonNoVerificado_Click(object sender, EventArgs e)
        {
            NoVerificarInvitado();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (buttonNoVerificado.Visible && buttonVerificado.Visible)
            {
                if (keyData == (Keys.S))
                {
                    VerificarInvitado();
                    return true;
                }
                if (keyData == (Keys.N))
                {
                    NoVerificarInvitado();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void ConsultarInvitadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaInvitadosForm formularioLista = new(dataService, proceso, Configuracion.CurrentValue);
            formularioLista.ShowDialog();
            formularioLista.Dispose();
            MostrarBaseDatosInfo();
        }
        private void ConsultarAsistentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaAsistentesForm formularioLista = new(dataService, proceso);
            formularioLista.ShowDialog();
            formularioLista.Dispose();
            MostrarBaseDatosInfo();
        }
        private void BarcodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarcodesConfForm barcodesConfForm = new();
            barcodesConfForm.ShowDialog();
            barcodesConfForm.Dispose();
        }
        private void TextosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarSettings();
        }
        protected void ActualizarSettings()
        {
            SettingsForm settingsForm = new(Configuracion.CurrentValue);
            DialogResult dialogResult = settingsForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Configuracion.CurrentValue.EventPath = settingsForm.Configuration.EventPath;
                Configuracion.CurrentValue.Title = settingsForm.Configuration.Title;
                Configuracion.CurrentValue.DatabaseName = settingsForm.Configuration.DatabaseName;
                Configuracion.CurrentValue.Event = settingsForm.Configuration.Event;
                Configuracion.CurrentValue.CSVSeparationLetter = settingsForm.Configuration.CSVSeparationLetter;
                Configuracion.CurrentValue.BackgroundImage = settingsForm.Configuration.BackgroundImage;
                Initialize();
            }
            settingsForm.Dispose();
        }


    }
}
