namespace party.windows.forms
{
    using System;
    using System.Windows.Forms;
    using party.core.model;
    using party.windows.configuration;

    public partial class SettingsForm : Form
    {
        private readonly Configuracion configuracion;

        public SettingsForm(core.model.Configuracion configuracion)
        {
            this.configuracion = configuracion;
            InitializeComponent();

            UpdateFields();
        }

        private void UpdateFields()
        {
            TituloText.Text = configuracion.Titulo;
   
            DatabaseText.Text = configuracion.DatabaseName;
            EventoText.Text = configuracion.Evento;
            SeparadorCSVText.Text = configuracion.CSVSeparationLetter;
            BackgroundText.Text = configuracion.BackgroundImage;
            //TituloText.PlaceholderText = "Party Events";
            //if (String.IsNullOrWhiteSpace(TituloText.Text))
            //{
            //    TituloText.Text = TituloText.PlaceholderText;
            //}
            //EventoText.PlaceholderText = "Event Local 1";
            //if (String.IsNullOrWhiteSpace(EventoText.Text))
            //{
            //    EventoText.Text = EventoText.PlaceholderText;
            //}
            //if (String.IsNullOrWhiteSpace(BackgroundText.Text))
            //{
            //    BackgroundText.Text = @".\images\Background.jpg";
            //}
            //if (String.IsNullOrWhiteSpace(DatabaseText.Text))
            //{
            //    DatabaseText.Text = @".\eventDatabase.db";
            //}
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {            
            Configuracion configuracion = new();
            configuracion.Titulo = TituloText.Text;
            configuracion.DatabaseName = DatabaseText.Text;
            configuracion.Evento = EventoText.Text;
            configuracion.CSVSeparationLetter = SeparadorCSVText.Text;
            configuracion.BackgroundImage = BackgroundText.Text;
            SettingsManager.SetAppSettingConfiguracionValues (configuracion);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SelectDatabaseButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "Bases de datos  (*.db) | *.db;";
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                DatabaseText.Text = saveFileDialog.FileName;
            }
        }

        private void SelectBackgroundButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Imágenes (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackgroundText.Text = openFileDialog.FileName;
            }
        }
    }
}
