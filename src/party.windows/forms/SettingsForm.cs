using party.core.model;
using party.windows.configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace party.windows.forms
{
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
            _ = SettingsManager.ReadSetting("Titulo");
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
            SettingsManager.SaveConfiguration(configuracion);
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
