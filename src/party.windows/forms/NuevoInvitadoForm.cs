namespace party.windows.forms
{
    using System;
    using System.Windows.Forms;
    using party.core.model;
    using party.core.settings;
    using party.service.data;

    public partial class NuevoInvitadoForm : Form
    {
        protected IDataService DataService { get; set; }
        protected SettingsAppData Configuracion { get; set; }
        public NuevoInvitadoForm(IDataService dataService, SettingsAppData configuracion)
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
                EventoLocal = Configuracion.Event

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
