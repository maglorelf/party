namespace party.windows.forms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using party.core.constants;
    using party.core.model;
    using party.core.settings;
    using party.service.data;
    using party.windows.configuration.settings;
    public partial class SettingsForm : Form
    {
        public SettingsAppData Configuration { get; protected set; }
        private readonly IDataService dataService;
        public SettingsForm(SettingsAppData configuracion, IDataService dataService)
        {
            this.Configuration = configuracion;
            this.dataService = dataService;
            InitializeComponent();

            UpdateFields();
        }
        private void UpdateFields()
        {

            PathText.Text = Configuration.EventPath;
            DatabaseText.Text = Configuration.DatabaseName;
            EventoText.Text = Configuration.Event;
            SeparadorCSVText.Text = Configuration.CSVSeparationLetter;
            BackgroundText.Text = Configuration.BackgroundImage;
            FillRouteCombo();
        }
        private void FillRouteCombo()
        {
            RouteCombo.Enabled = false;
            if (dataService.ExistDatabaseFile() && dataService.CheckDatabase().Success)
            {
                List<Route> routes = dataService.GetAllRoutesOfEvent(Configuration.EventId);
                if (routes != null && routes.Count > 0)
                {
                    RouteCombo.Enabled = true;
                    RouteCombo.Items.Clear();
                    RouteCombo.DataSource = new BindingSource(routes, null);
                    RouteCombo.DisplayMember = nameof(Route.Name);
                    RouteCombo.ValueMember = nameof(Route.Id);
                    if (routes.Any(route => route.Id == Configuration.RouteId))
                    {
                        RouteCombo.SelectedValue = Configuration.RouteId;
                    }
                    else
                    {
                        RouteCombo.SelectedItem = routes.First();
                    }
                }
            }
        }
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            (bool validForm, string messageInvalidation) = ValidateForm();
            if (validForm)
            {
                Configuration.Event = EventoText.Text;
                if (RouteCombo.SelectedItem != null)
                {
                    Configuration.RouteName = ((Route)RouteCombo.SelectedItem).Name;
                    Configuration.RouteId = ((Route)RouteCombo.SelectedItem).Id;
                }
                Configuration.EventPath = PathText.Text;
                Configuration.DatabaseName = DatabaseText.Text;
                Configuration.CSVSeparationLetter = SeparadorCSVText.Text;
                Configuration.BackgroundImage = BackgroundText.Text;

                SettingsManager.SetAppSettingConfiguracionValues(Configuration, Configuration.ConfigurationFilename);
                SettingsManager.SetAppSettingConfiguracionValues(Configuration, null);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(messageInvalidation);
                this.DialogResult = DialogResult.None;
            }
        }
        private (bool validForm, string messageInvalidation) ValidateForm()
        {
            bool valid = true;
            string message = string.Empty;
            if (!System.IO.Path.IsPathFullyQualified(PathText.Text))
            {
                message += "El path tiene que ser válido.";
                valid = false;
            }
            return (valid, message);
        }
        private void SelectDatabaseButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = $"Bases de datos  (*{SQLiteConstants.DefaultExtension}) | *{SQLiteConstants.DefaultExtension};"
            };
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                DatabaseText.Text = saveFileDialog.FileName;
            }
        }
        private void SelectBackgroundButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "Imágenes (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackgroundText.Text = openFileDialog.FileName;
            }
        }
        private void SelectEventPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                PathText.Text = folderBrowserDialog.SelectedPath;
            }
        }
        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.None)
                e.Cancel = true;
        }
    }
}
