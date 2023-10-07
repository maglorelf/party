namespace party.windows.forms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using party.core.attributes;
    using party.core.model;
    using party.core.sorting;

    public partial class EventForm : Form
    {
        public Event Event { get; protected set; }
        private SortableBindingList<Route> routesBinding;
        public EventForm(Event dataEvent)
        {
            Event = dataEvent;
            InitializeComponent();
            UpdateFields();
        }
        private void UpdateFields()
        {

            TituloText.Text = Event.Title;
            DescriptionText.Text = Event.Description;
            StartDatePicker.Value = Event.Start;
            EndDatePicker.Value = Event.End;
            CheckInPicker.Value = Event.CheckIn;
            FillGrid(Event.Routes);
        }
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            (bool validForm, string messageInvalidation) = ValidateForm();
            if (validForm)
            {
                Event.Title = TituloText.Text;
                Event.Description = DescriptionText.Text;
                Event.Start = StartDatePicker.Value;
                Event.End = EndDatePicker.Value;
                Event.CheckIn = CheckInPicker.Value;
                Event.Routes = routesBinding.ToList();
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
            if (string.IsNullOrEmpty(TituloText.Text))
            {
                message += "El titulo es obligatorio.";
                valid = false;
            }
            if (routesBinding.Count == 0)
            {
                message += "Al menos debe existir una localización.";
                valid = false;
            }
            if (routesBinding.Any(r => string.IsNullOrWhiteSpace(r.Name)))
            {
                message += "Se requiere al menos dar un nombre a las localizaciones.";
                valid = false;
            }
            return (valid, message);
        }
        private void EventForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.None)
            {
                e.Cancel = true;
            }
        }
        public void FillGrid(IList<Route> routes)
        {
            routesBinding = new SortableBindingList<Route>(routes);
            gridRoutes.DataSource = routesBinding;
            IList<Tuple<string, string, int>> fields = VisibleFieldList();

            foreach (DataGridViewColumn column in gridRoutes.Columns)
            {
                var campoMetadata = fields.FirstOrDefault(campo => campo.Item1 == column.Name);
                if (campoMetadata != null)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    column.HeaderText = campoMetadata.Item2;
                }
                else
                {
                    column.Visible = false;
                }
            }
        }
        protected static IList<Tuple<string, string, int>> VisibleFieldList()
        {
            Type tipoObjeto = typeof(Route);
            IList<Tuple<string, string, int>> visibleFieldList = new List<Tuple<string, string, int>>();
            foreach (var property in tipoObjeto.GetProperties())
            {
                foreach (var customAttribute in Attribute.GetCustomAttributes(property))
                {
                    VisibleGrid castCustomAttribute = (VisibleGrid)customAttribute;
                    if (customAttribute != null)
                    {
                        visibleFieldList.Add(new Tuple<string, string, int>(property.Name, castCustomAttribute.Header, castCustomAttribute.Order));
                    }
                }
            }
            return visibleFieldList;
        }
        private void MenuItemDelete_Click(object sender, EventArgs e)
        {
            Route route = SelectedRoute();
            if (route != null)
            {
                routesBinding.Remove(route);
            }
        }
        private Route SelectedRoute()
        {
            Route route = null;
            if (gridRoutes?.SelectedRows.Count > 0)
            {
                route = (Route)gridRoutes.SelectedRows[0].DataBoundItem;
            }
            return route;
        }
    }
}
