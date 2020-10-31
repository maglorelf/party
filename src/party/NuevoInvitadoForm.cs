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
    public partial class NuevoInvitadoForm : Form
    {
        protected DataService dataService { get; set; }
        protected Configuracion configuracion { get; set; }
        public NuevoInvitadoForm(DataService dataService, Configuracion configuracion)
        {
            InitializeComponent();
            this.dataService = dataService;
            this.configuracion = configuracion;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Invitado invitado = new Invitado
            {
                Nombre = NombreText.Text,
                DNI = DniText.Text,
                Notas = NotasText.Text,
                Evento = string.Empty,
                EventoLocal=configuracion.Evento
                
            };
            if (invitado.HasValuesMinimos())
            {
                dataService.InsertInvitadoManual(invitado);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Es necesario cubrir todos los campos");
            }
        }
    }
}
