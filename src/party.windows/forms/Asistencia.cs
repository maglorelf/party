namespace party.windows.forms
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using Microsoft.Extensions.Options;
    using party.core.enums;
    using party.core.model;
    using party.service;
    using party.service.data;

    public partial class Asistencia : Form
    {
        protected IOptionsMonitor<Configuracion> Configuracion { get; set; }
        protected IProceso Proceso { get; private set; }
        protected IDataService DataService { get; private set; }
        protected ICSVService CsvService { get; private set; }
        public Invitado InvitadoTemporal { get; private set; }
        public Asistencia(IOptionsMonitor<Configuracion> configuracion, IProceso proceso, ICSVService csvService, IDataService dataService)
        {
            this.Configuracion = configuracion;
            this.Configuracion.OnChange(conf => Inicializar());
            this.Proceso = proceso;
            this.CsvService = csvService;
            this.DataService = dataService;
            InitializeComponent();
        }
        private void Asistencia_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        protected void Inicializar()
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
            if (!Configuracion.CurrentValue.DatabaseName.EndsWith(".db"))
            {
                ActualizarSettings();
            }
        }
        private void SetScreenSettings(Configuracion configuracion)
        {
            this.BackgroundImage = LoadImage(configuracion.BackgroundImage);            
            this.Invoke(new Action(() => this.Text = configuracion.Titulo));
            Evento.Invoke(new Action(() => Evento.Text = configuracion.Evento));

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
            (ResultadoCheck, Invitado, Asistente) resultado = Proceso.CheckQR(qr);
            Procesar(qr, resultado);
            MostrarBaseDatosInfo();
        }

        private void ClearPanels()
        {
            panelNoExiste.Visible = false;
            panelConfirmacionEntrada.Visible = false;
            this.InvitadoTemporal = null;
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
            this.InvitadoTemporal = invitado;
            this.InvitadoTemporal.QRLeido = GetQRValue();
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
            this.Close();
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
                DataService.InitializeDatabase();
                QRText.Visible = true;
                CheckQR.Visible = true;
            }
            MostrarBaseDatosInfo();
        }

        private void MostrarBaseDatosInfo()
        {
            string checkDatabase = string.Empty;
            int cantidadInvitados = 0;
            int cantidadInvitadosEvento = 0;
            int cantidadAsistentes = 0;

            try
            {
                checkDatabase = DataService.CheckDatabase();
            }
            catch { }
            try
            {
                cantidadInvitados = DataService.GetCountInvitados();
            }
            catch { }
            try
            {
                cantidadAsistentes = DataService.GetCountAsistentes();
            }
            catch { }
            try
            {
                cantidadInvitadosEvento = DataService.GetCountInvitadosEvento(Configuracion.CurrentValue.Evento);
            }
            catch
            {
            }

            statusDatabase.Text = $"Base de datos: {checkDatabase}";
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
                IList<Invitado> invitadosLeidos = CsvService.ReadFileInvitados(openFileDialog.FileName, progress).GetAwaiter().GetResult();

                DataService.LoadInvitados(invitadosLeidos, progress);
            }
            MostrarBaseDatosInfo();
        }

        private void DescargarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "CSV File|*.csv";
            saveFileDialog.Title = "Guardar fichero de asistencia";
            saveFileDialog.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (!string.IsNullOrWhiteSpace(saveFileDialog.FileName))
            {
                IList<Asistente> asistentes = DataService.GetAllAsistentes();
                CsvService.WriteCSV(asistentes, saveFileDialog.FileName);
            }
        }

        private void ButtonVerificado_Click(object sender, EventArgs e)
        {
            VerificarInvitado();
        }
        private void VerificarInvitado()
        {

            Proceso.AceptarInvitado(this.InvitadoTemporal);
            buttonNoVerificado.Visible = false;
            buttonVerificado.Visible = false;
            labelAsistenteAceptado.Text = "Asistente aceptado";
            labelAsistenteAceptado.Visible = true;
            CheckQR.Enabled = true;
            MostrarBaseDatosInfo();
        }
        private void NoVerificarInvitado()
        {
            this.InvitadoTemporal = null;
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
            ListaInvitadosForm formularioLista = new(DataService, Proceso, Configuracion.CurrentValue);
            formularioLista.ShowDialog();
            formularioLista.Dispose();
            MostrarBaseDatosInfo();
        }

        private void ConsultarAsistentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaAsistentesForm formularioLista = new(DataService, Proceso);
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
            settingsForm.Dispose();
            if (dialogResult == DialogResult.OK)
            {
                //Inicializar();
            }
        }


    }
}
