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
        public SettingsForm()
        {
            InitializeComponent();
            TituloText.Text = SettingsManager.ReadSetting("Titulo");
            DatabaseText.Text = SettingsManager.ReadSetting("DatabaseName");
            EventoText.Text = SettingsManager.ReadSetting("Evento");
            SeparadorCSVText.Text = SettingsManager.ReadSetting("CSVSeparationLetter");
            BackgroundText.Text = SettingsManager.ReadSetting("BackgroundImage");
            UpdateEmptyValues();
        }

        private void UpdateEmptyValues()
        {
            TituloText.PlaceholderText = "Party Events";
            if (String.IsNullOrWhiteSpace(TituloText.Text))
            {
                TituloText.Text = TituloText.PlaceholderText;
            }
            EventoText.PlaceholderText = "Event Local 1";
            if (String.IsNullOrWhiteSpace(EventoText.Text))
            {
                EventoText.Text = EventoText.PlaceholderText;
            }
            if (String.IsNullOrWhiteSpace(BackgroundText.Text))
            {
                BackgroundText.Text = @".\images\Background.jpg";
            }
            if (String.IsNullOrWhiteSpace(DatabaseText.Text))
            {
                DatabaseText.Text = @".\eventDatabase.db";
            }
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            SettingsManager.AddUpdateAppSettings("Titulo", TituloText.Text);
            SettingsManager.AddUpdateAppSettings("DatabaseName", DatabaseText.Text);
            SettingsManager.AddUpdateAppSettings("Evento", EventoText.Text);
            SettingsManager.AddUpdateAppSettings("CSVSeparationLetter", SeparadorCSVText.Text);
            SettingsManager.AddUpdateAppSettings("BackgroundImage", BackgroundText.Text);

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
