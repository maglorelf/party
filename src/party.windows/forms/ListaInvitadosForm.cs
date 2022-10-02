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

    public partial class ListaInvitadosForm : Form
    {
        protected Configuracion Configuracion { get; set; }
        private SortableBindingList<Invitado> invitadosBinding;
        protected IDataService DataService { get; set; }
        protected IList<Tuple<string, string, int>> CamposVisibles { get; set; }

        protected IProceso Proceso { get; set; }
        protected Filtro FiltroSeleccionado { get; set; }
        public ListaInvitadosForm(IDataService dataService, IProceso proceso, Configuracion configuracion)
        {
            invitadosBinding = new SortableBindingList<Invitado>();
            FiltroSeleccionado = null;
            this.DataService = dataService;
            this.Proceso = proceso;
            this.Configuracion = configuracion;
            InitializeComponent();
            CamposVisibles = ListaCamposVisibles();
            FillComboCampos();
            FillGrid();
        }

        public void GetInvitados()
        {
            var invitados = DataService.GetAllInvitadosView();
            if (FiltroSeleccionado != null)
            {

                var param = Expression.Parameter(typeof(Invitado), "x");
                var predicate = Expression.Lambda<Func<Invitado, bool>>(
                    Expression.Call(
                    Expression.Call(
                        Expression.PropertyOrField(param, FiltroSeleccionado.CampoFiltrado),
                        "ToUpper", null),
                        "Contains", null, Expression.Constant(FiltroSeleccionado.TextoFiltrado.ToUpper())
                    ), param);
                invitados = invitados.AsQueryable().Where(predicate).ToList();
            }
            invitadosBinding = new SortableBindingList<Invitado>(invitados);
        }

        public void FillGrid()
        {
            GetInvitados();
            gridInvitados.DataSource = invitadosBinding;
            foreach (DataGridViewColumn column in gridInvitados.Columns)
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
            gridInvitados.AutoResizeColumns(
                 DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

        }

        protected static IList<Tuple<string, string, int>> ListaCamposVisibles()
        {
            Type tipoObjeto = typeof(Invitado);
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

        private void MarcarAsistencia_Click(object sender, EventArgs e)
        {
            Invitado invitado = InvitadoSeleccionado();
            if (invitado != null)
            {
                string mensaje = $"El invitado {invitado.Nombre} con DNI {invitado.DNI}, ¿se le concede acceso?";
                DialogResult dialogResult = MessageBox.Show(mensaje, "Confirmación de asistencia manual", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MarcarAsistente(invitado);
                }
            }
        }
        private Invitado InvitadoSeleccionado()
        {
            Invitado invitado = null;
            if (gridInvitados?.SelectedRows.Count > 0)
            {
                invitado = (Invitado)gridInvitados.SelectedRows[0].DataBoundItem;
            }
            return invitado;
        }

        private void MarcarAsistente(Invitado invitado)
        {
            invitado.QRLeido = "Proceso Manual";
            if (!invitado.IsRegistrado)
            {
            Proceso.AceptarInvitado(invitado);
            int? indexSelecte = gridInvitados.SelectedRows[0]?.Index;
            FillGrid();
            gridInvitados.Rows[indexSelecte.GetValueOrDefault()].Selected = true;
            gridInvitados.FirstDisplayedScrollingRowIndex = indexSelecte.GetValueOrDefault();
            } else
            {
                MessageBox.Show("El invitado ya se había registrado antes");
            }
        }

        private void GridInvitados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Invitado invitado = InvitadoSeleccionado();
            if (invitado != null && invitado.IsRegistrado)
            {
                contextMenuGrid.Items[0].Enabled = false;
            }
            else
            {
                contextMenuGrid.Items[0].Enabled = true;
            }
        }

        private void NuevoInvitadoButton_Click(object sender, EventArgs e)
        {
            NuevoInvitadoForm nuevoInvitadoForm = new(DataService, Configuracion);
            nuevoInvitadoForm.ShowDialog();
            nuevoInvitadoForm.Dispose();
            FillGrid();
        }

        private void AddNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invitado invitado = InvitadoSeleccionado();
            if (invitado != null)
            {
                string notasActualizadas = Prompt.ShowDialog("Notas", $"Actualizar invitado {invitado.Nombre} {invitado.DNI}", invitado.Notas);
                if (!notasActualizadas.Equals(invitado.Notas))
                {
                    invitado.Notas = notasActualizadas;
                    DataService.ActualizarNotasInvitado(invitado);
                    FillGrid();
                }

            }


        }
    }
}
