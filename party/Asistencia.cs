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
        protected  CSVService csvService { get; set; }
        public Asistencia()
        {
            InitializeComponent();
            proceso = new Proceso();
            configuracion = proceso.LeerConfiguracion();
            dataService = new DataService(configuracion.DatabaseName);
            proceso.DataService = dataService;
            csvService = new CSVService(configuracion.CSVSeparationLetter);

        }

        private void checkQR_Click(object sender, EventArgs e)
        {
            string qr = getQRValue();
            (ResultadoCheck, Asistente) resultado = proceso.GetQR(qr);
            procesar(resultado);
        }

        protected void procesar((ResultadoCheck, Asistente) resultado)
        {
            switch (resultado.Item1)
            {
                case ResultadoCheck.NoExiste:
                    cambiarBackground(Color.Red);
                    break;
                case ResultadoCheck.Correcto:
                    cambiarBackground(Color.Green);

                    break;
                case ResultadoCheck.Registrado:
                    cambiarBackground(Color.Orange);

                    break;
                case ResultadoCheck.NoValue:
                    cambiarBackground(Color.Transparent);

                    break;
                default:
                    break;
            }
        }

        private void cambiarBackground(Color color)
        {
            panelResultado.BackColor = color;
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
            if (!string.IsNullOrWhiteSpace (saveFileDialog.FileName))
            {
                IList<Asistente> asistentes = dataService.GetAllAsistentes();
                csvService.WriteCSV(asistentes, saveFileDialog.FileName);
            }
        }
    }
}
