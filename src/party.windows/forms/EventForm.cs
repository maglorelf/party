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
                Event.Description = TituloText.Text;
                //Event.Start= TituloText.Text;
                //Event.End = TituloText.Text;
                //Event.CheckIn = TituloText.Text;
                //Event.Routes = TituloText.Text;
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
            if (!string.IsNullOrEmpty(TituloText.Text))
            {
                message += "El titulo es obligatorio.";
                valid = false;
            }
            return (valid, message);
        }
        private void EventForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.None)
                e.Cancel = true;
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
    }
}
