namespace party.windows.forms
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Windows.Forms;
    using party.core.attributes;
    using party.core.model;
    using party.core.sorting;
    using party.service;
    using party.service.data;
    using party.windows.components;

    public partial class ListaAsistentesForm : Form
    {
        private SortableBindingList<Asistente> asistentesBinding;
        protected IDataService DataService { get; set; }
        protected IList<Tuple<string, string, int>> CamposVisibles { get; set; }

        protected IProceso Proceso { get; set; }
        protected Filtro FiltroSeleccionado { get; set; }
        public ListaAsistentesForm(IDataService dataService, IProceso proceso)
        {
            asistentesBinding = new SortableBindingList<Asistente>();
            FiltroSeleccionado = null;
            this.DataService = dataService;
            this.Proceso = proceso;
            InitializeComponent();
            CamposVisibles = ListaCamposVisibles();
            FillComboCampos();
            FillGrid();
        }

        public void GetAsistentes()
        {
            var asistentes = DataService.GetAllAsistentes();
            if (FiltroSeleccionado != null)
            {

                var param = Expression.Parameter(typeof(Asistente), "x");
                var predicate = Expression.Lambda<Func<Asistente, bool>>(
                    Expression.Call(
                    Expression.Call(
                        Expression.PropertyOrField(param, FiltroSeleccionado.CampoFiltrado),
                        "ToUpper", null),
                        "Contains", null, Expression.Constant(FiltroSeleccionado.TextoFiltrado.ToUpper())
                    ), param);
                asistentes = asistentes.AsQueryable().Where(predicate).ToList();
            }
            asistentesBinding = new SortableBindingList<Asistente>(asistentes);
        }

        public void FillGrid()
        {
            GetAsistentes();
            gridAsistentes.DataSource = asistentesBinding;
            foreach (DataGridViewColumn column in gridAsistentes.Columns)
            {
                var campoMetadata = CamposVisibles.FirstOrDefault(campo => campo.Item1 == column.Name);
                if (campoMetadata != null)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    column.HeaderText = campoMetadata.Item2;
                    //     column.DisplayIndex = campoMetadata.Item3;   
                }
                else
                {
                    column.Visible = false;
                }
            }

        }

        protected static IList<Tuple<string, string, int>> ListaCamposVisibles()
        {
            Type tipoObjeto = typeof(Asistente);
            IList<Tuple<string, string, int>> listaCamposVisibles = new List<Tuple<string, string, int>>();
            foreach (var property in tipoObjeto.GetProperties())
            {
                foreach (var customAttribute in System.Attribute.GetCustomAttributes(property))
                {
                    VisibleGrid castCustomAttribute = (VisibleGrid)customAttribute;
                    if (customAttribute != null)
                    {
                        listaCamposVisibles.Add(new Tuple<string, string, int>(property.Name, castCustomAttribute.Header, castCustomAttribute.Order));
                    }
                }
            }
            return listaCamposVisibles;
        }
        private void LimpiarFiltroButton_Click(object sender, EventArgs e)
        {
            FiltroSeleccionado = null;
            DataFiltroText.Clear();
            fieldToFilterCombo.SelectedItem = "DNI";
            FillGrid();
        }

        private void FillComboCampos()
        {

            fieldToFilterCombo.Items.Clear();
            fieldToFilterCombo.DataSource = new BindingSource(CamposVisibles, null);
            fieldToFilterCombo.DisplayMember = "Item2";
            fieldToFilterCombo.ValueMember = "Item1";
            fieldToFilterCombo.SelectedValue = "DNI";
        }
        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            FiltroSeleccionado = new Filtro { TextoFiltrado = DataFiltroText.Text, CampoFiltrado = CampoFiltradoSeleccionado() };
            FillGrid();

        }
        protected string CampoFiltradoSeleccionado()
        {
            return fieldToFilterCombo.SelectedValue.ToString();
        }

        private void RetirarAsistencia_Click(object sender, EventArgs e)
        {
            Asistente asistente = AsistenteSeleccionado();
            if (asistente != null)
            {
                string mensaje = $"El invitado {asistente.Nombre} con DNI {asistente.DNI}, ¿se cancela la asistencia?";
                DialogResult dialogResult = MessageBox.Show(mensaje, "Confirmación de borrado de asistencia manual", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    BorrarAsistente(asistente);
                }
            }
        }
        private Asistente AsistenteSeleccionado()
        {
            Asistente asistente = null;
            if (gridAsistentes?.SelectedRows.Count > 0)
            {
                asistente = (Asistente)gridAsistentes.SelectedRows[0].DataBoundItem;
            }
            return asistente;
        }

        private void BorrarAsistente(Asistente asistente)
        {
            Proceso.BorrarAsistente(asistente);
            FillGrid();
        }

        private void GridInvitados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Asistente asistente = AsistenteSeleccionado();
            if (asistente == null)
            {
                contextMenuGrid.Items[0].Enabled = false;
            }
            else
            {
                contextMenuGrid.Items[0].Enabled = true;
            }
        }
    }
}
