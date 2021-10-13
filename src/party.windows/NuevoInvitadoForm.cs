using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace party.windows
{
    public partial class NuevoInvitadoForm : Form
    {
        protected DataService DataService { get; set; }
        protected Configuracion Configuracion { get; set; }
        public NuevoInvitadoForm(DataService dataService, Configuracion configuracion)
        {
            InitializeComponent();
            this.DataService = dataService;
            this.Configuracion = configuracion;
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Invitado invitado = new()
            {
                Nombre = NombreText.Text,
                DNI = DniText.Text,
                Notas = NotasText.Text,
                Evento = string.Empty,
                EventoLocal=Configuracion.Evento
                
            };
            if (invitado.HasValuesMinimos())
            {
                DataService.InsertInvitadoManual(invitado);
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
