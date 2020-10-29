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
            configuracion = leerConfiguracion();
            setScreenSettings(configuracion);
            dataService = new DataService(configuracion.DatabaseName);
            proceso = new Proceso(configuracion, dataService);
            csvService = new CSVService(configuracion.CSVSeparationLetter);
            clearPanels();

        }
        private Configuracion leerConfiguracion()
        {
            Configuracion configuracion = new Configuracion
            {
                DatabaseName = party.Properties.Settings.Default.DatabaseName,
                CSVSeparationLetter = party.Properties.Settings.Default.CSVSeparationLetter,
                Evento = party.Properties.Settings.Default.Evento,
                Titulo = party.Properties.Settings.Default.Titulo,
                BackgroundImage = party.Properties.Settings.Default.BackgroundImage,
            };
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
                image = Image.FromFile(imagePath);
            }
            return image;
        }

        private void checkQR_Click(object sender, EventArgs e)
        {
            clearPanels();
            string qr = getQRValue();
            (ResultadoCheck, Invitado, Asistente) resultado = proceso.CheckQR(qr);
            procesar(qr, resultado);
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
            AsistenteDatosLabel.Text = $"{asistente.Nombre} {asistente.Apellidos} \n {asistente.DNI} \n {asistente.Email} \n {asistente.Evento} \n {asistente.Entrada}";

        }

        private void mostrarInvitado(Invitado invitado)
        {
            panelConfirmacionEntrada.Visible = true;
            this.InvitadoTemporal = invitado;
            CheckQR.Enabled = false;
            buttonNoVerificado.Visible = true;
            buttonVerificado.Visible = true;
            InvitadoDatosLabel.Text = $"{invitado.Nombre} \n {invitado.DNI} \n {invitado.Email} \n {invitado.Evento} \n {invitado.EventoLocal}";

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
                dataService.InitializeDatabase();
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

                IList<Invitado> invitadosLeidos = csvService.ReadFileInvitados(openFileDialog.FileName);
                dataService.LoadInvitados(invitadosLeidos);

            }
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

            proceso.AceptarInvitado(this.InvitadoTemporal);
            buttonNoVerificado.Visible = false;
            buttonVerificado.Visible = false;
            CheckQR.Enabled = true;

        }

        private void buttonNoVerificado_Click(object sender, EventArgs e)
        {
            this.InvitadoTemporal = null;
            buttonNoVerificado.Visible = false;
            buttonVerificado.Visible = false;
            CheckQR.Enabled = true;
        }
    }
}
