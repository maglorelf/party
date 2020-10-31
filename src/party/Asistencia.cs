using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace party
{
    public partial class Asistencia : Form
    {
        protected Configuracion configuracion { get; set; }
        protected Proceso proceso { get; set; }
        protected DataService dataService { get; set; }
        protected CSVService csvService { get; set; }
        public Invitado InvitadoTemporal { get; private set; }

        public Asistencia()
        {
            InitializeComponent();

            inicializar();
        }
        protected void inicializar()
        {

            configuracion = leerConfiguracion();
            setScreenSettings(configuracion);
            dataService = new DataService(configuracion.DatabaseName);
            proceso = new Proceso(configuracion, dataService);
            csvService = new CSVService(configuracion.CSVSeparationLetter);
            clearPanels();           
            mostrarBaseDatosInfo();
        }
        private Configuracion leerConfiguracion()
        {
            Configuracion configuracion = new Configuracion
            {
                DatabaseName = SettingsManager.ReadSetting("DatabaseName"),
                CSVSeparationLetter = SettingsManager.ReadSetting("CSVSeparationLetter"),
                Evento = SettingsManager.ReadSetting("Evento"),
                Titulo = SettingsManager.ReadSetting("Titulo"),
                BackgroundImage = SettingsManager.ReadSetting("BackgroundImage")
            };
            if (!configuracion.DatabaseName.EndsWith(".db"))
            {
                actualizarSettings();
            }
            return configuracion;
        }
        private void setScreenSettings(Configuracion configuracion)
        {
            this.BackgroundImage = loadImage(configuracion.BackgroundImage);
            
            this.Text = configuracion.Titulo;
            this.Evento.Text = configuracion.Evento;
        }



        private Image loadImage(string imagePath)
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

        private void checkQR_Click(object sender, EventArgs e)
        {
            clearPanels();
            string qr = getQRValue();
            (ResultadoCheck, Invitado, Asistente) resultado = proceso.CheckQR(qr);
            procesar(qr, resultado);
            mostrarBaseDatosInfo();
        }

        private void clearPanels()
        {
            panelNoExiste.Visible = false;
            panelConfirmacionEntrada.Visible = false;
            this.InvitadoTemporal = null;
            panelAsistenciaRegistrada.Visible = false;

        }

        protected void procesar(string qr, (ResultadoCheck, Invitado, Asistente) resultado)
        {
            switch (resultado.Item1)
            {
                case ResultadoCheck.NoExiste:
                    cambiarBackground(Color.Red);
                    mostrarNoExisteInvitado(qr);
                    break;
                case ResultadoCheck.PuedeEntrar:
                    cambiarBackground(Color.Green);
                    mostrarInvitado(resultado.Item2);
                    break;
                case ResultadoCheck.Registrado:
                    cambiarBackground(Color.Orange);
                    mostrarAsistente(resultado.Item3);
                    break;
                case ResultadoCheck.DatosIncorrectos:
                    cambiarBackground(Color.Orange);
                    mostrarInvitadoDatosIncorrectos(resultado.Item2);
                    break;
                case ResultadoCheck.NoValue:
                    cambiarBackground(Color.Transparent);

                    break;
                default:
                    break;
            }
            clearCode();
        }

        private void mostrarAsistente(Asistente asistente)
        {
            panelAsistenciaRegistrada.Visible = true;
            AsistenteDatosLabel.Text = $"{asistente.Nombre} \n {asistente.DNI} \n {asistente.Email} \n {asistente.Evento} \n {asistente.Entrada}";

        }

        private void mostrarInvitado(Invitado invitado)
        {
            labelAsistenteAceptado.Visible = false;
            panelConfirmacionEntrada.Visible = true;
            this.InvitadoTemporal = invitado;
            this.InvitadoTemporal.QRLeido = getQRValue();
            CheckQR.Enabled = false;
            buttonNoVerificado.Visible = true;
            buttonVerificado.Visible = true;
            InvitadoDatosLabel.Text = $"{invitado.Nombre} \n{invitado.DNI} \n{invitado.Email} \n{invitado.Evento} \n{invitado.EventoLocal}";

        }
        private void mostrarInvitadoDatosIncorrectos(Invitado invitado)
        {
            labelAsistenteAceptado.Visible = false;
            panelConfirmacionEntrada.Visible = true;
            buttonNoVerificado.Visible = false;
            buttonVerificado.Visible = false;
            InvitadoDatosLabel.Text = $"Nombre: {invitado.Nombre} \nDNI: {invitado.DNI} \nEmail: {invitado.Email} \nLocal: {invitado.EventoLocal}\nConfirmado: {invitado.Asistencia}\n\nEl invitado no está confirmado para este evento/local. \nSe debe realizar una inserción manual previa comprobación de los datos";
        }
        private void mostrarNoExisteInvitado(string qr)
        {
            panelNoExiste.Visible = true;
            QRErrorLabel.Text = qr;
        }

        private void clearCode()
        {
            QRText.Text = string.Empty;
        }

        private void cambiarBackground(Color color)
        {

        }

        protected string getQRValue()
        {
            string qr;
            qr = QRText.Text;
            return qr;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void inicializarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool confirmado = solicitarConfirmacion("El proceso de inicializar borrará todos los datos de la aplicación sin posibilidad de recuperarlos. ¿Desea continuar?");
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
            mostrarBaseDatosInfo();
        }

        private void mostrarBaseDatosInfo()
        {
            string checkDatabase = string.Empty;
            int cantidadInvitados = 0;
            int cantidadInvitadosEvento = 0;
            int cantidadAsistentes = 0;

            try
            {
                checkDatabase = dataService.CheckDatabase();
            }
            catch { }
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
                cantidadInvitadosEvento = dataService.GetCountInvitadosEvento(configuracion.Evento);
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

        protected bool solicitarConfirmacion(string mensaje)
        {
            DialogResult result = MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return (result == DialogResult.Yes ? true : false);
        }

        private void cargarFicheroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                IList<Invitado> invitadosLeidos = csvService.ReadFileInvitados(openFileDialog.FileName, processBar);
                dataService.LoadInvitados(invitadosLeidos, processBar);
            }
            mostrarBaseDatosInfo();
        }

        private void descargarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV File|*.csv";
            saveFileDialog.Title = "Guardar fichero de asistencia";
            saveFileDialog.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (!string.IsNullOrWhiteSpace(saveFileDialog.FileName))
            {
                IList<Asistente> asistentes = dataService.GetAllAsistentes();
                csvService.WriteCSV(asistentes, saveFileDialog.FileName);
            }
        }

        private void buttonVerificado_Click(object sender, EventArgs e)
        {
            verificarInvitado();


        }
        private void verificarInvitado()
        {

            proceso.AceptarInvitado(this.InvitadoTemporal);
            buttonNoVerificado.Visible = false;
            buttonVerificado.Visible = false;
            labelAsistenteAceptado.Text = "Asistente aceptado";
            labelAsistenteAceptado.Visible = true;
            CheckQR.Enabled = true;
            mostrarBaseDatosInfo();
        }
        private void noVerificarInvitado()
        {
            this.InvitadoTemporal = null;
            buttonNoVerificado.Visible = false;
            buttonVerificado.Visible = false;
            labelAsistenteAceptado.Text = "Asistente rechazado";
            labelAsistenteAceptado.Visible = true;
            CheckQR.Enabled = true;

        }
        private void buttonNoVerificado_Click(object sender, EventArgs e)
        {
            noVerificarInvitado();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (buttonNoVerificado.Visible && buttonVerificado.Visible)
            {

                if (keyData == (Keys.S))
                {
                    verificarInvitado();
                    return true;
                }
                if (keyData == (Keys.N))
                {
                    noVerificarInvitado();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void consultarInvitadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaInvitadosForm formularioLista = new ListaInvitadosForm(dataService, proceso,configuracion);
            formularioLista.ShowDialog();
            formularioLista.Dispose();
            mostrarBaseDatosInfo();
        }

        private void consultarAsistentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaAsistentesForm formularioLista = new ListaAsistentesForm(dataService, proceso);
            formularioLista.ShowDialog();
            formularioLista.Dispose();
            mostrarBaseDatosInfo();
        }

        private void barcodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarcodesConfForm barcodesConfForm = new BarcodesConfForm();
            barcodesConfForm.ShowDialog();
            barcodesConfForm.Dispose();
        }

        private void textosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizarSettings();
        }
        protected void actualizarSettings()
        {
            SettingsForm settingsForm = new SettingsForm();
            DialogResult dialogResult = settingsForm.ShowDialog();
            settingsForm.Dispose();
            if (dialogResult == DialogResult.OK)
            {
                inicializar();
            }
        }
    }
}
