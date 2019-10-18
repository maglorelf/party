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
        public Proceso Proceso { get; set; }
        public Asistencia()
        {
            InitializeComponent();
            Proceso = new Proceso();
        }

        private void checkQR_Click(object sender, EventArgs e)
        {
            string qr = getQRValue();
            (ResultadoCheck, Asistente) resultado = Proceso.GetQR(qr);
            Procesar(resultado);
        }

        private void Procesar((ResultadoCheck, Asistente) resultado)
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
    }
}
