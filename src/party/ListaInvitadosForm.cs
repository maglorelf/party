using party.core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace party
{
    public partial class ListaInvitadosForm : Form
    {
        protected Configuracion configuracion { get; set; }
        private SortableBindingList<Invitado> invitadosBinding;
        protected DataService dataService { get; set; }
        protected IList<Tuple<string, string, int>> camposVisibles { get; set; }

        protected Proceso proceso { get; set; }
        protected Filtro filtroSeleccionado { get; set; }
        public ListaInvitadosForm(DataService dataService, Proceso proceso, Configuracion configuracion)
        {
            invitadosBinding = new SortableBindingList<Invitado>();
            filtroSeleccionado = null;
            this.dataService = dataService;
            this.proceso = proceso;
            this.configuracion = configuracion;
            InitializeComponent();
            camposVisibles = ListaCamposVisibles();
            fillComboCampos();
            FillGrid();
        }

        public void GetInvitados()
        {
            var invitados = dataService.GetAllInvitadosView();
            if (filtroSeleccionado != null)
            {

                var param = Expression.Parameter(typeof(Invitado), "x");
                var predicate = Expression.Lambda<Func<Invitado, bool>>(
                    Expression.Call(
                    Expression.Call(
                        Expression.PropertyOrField(param, filtroSeleccionado.CampoFiltrado),
                        "ToUpper", null),
                        "Contains", null, Expression.Constant(filtroSeleccionado.TextoFiltrado.ToUpper())
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
                var campoMetadata = camposVisibles.FirstOrDefault(campo => campo.Item1 == column.Name);
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

        protected IList<Tuple<string, string, int>> ListaCamposVisibles()
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
        private void limpiarFiltroButton_Click(object sender, EventArgs e)
        {
            filtroSeleccionado = null;
            DataFiltroText.Clear();
            fieldToFilterCombo.SelectedItem = "DNI";
            FillGrid();
        }

        private void fillComboCampos()
        {

            fieldToFilterCombo.Items.Clear();
            fieldToFilterCombo.DataSource = new BindingSource(camposVisibles, null);
            fieldToFilterCombo.DisplayMember = "Item2";
            fieldToFilterCombo.ValueMember = "Item1";
            fieldToFilterCombo.SelectedValue = "DNI";
        }
        private void filtrarButton_Click(object sender, EventArgs e)
        {
            filtroSeleccionado = new Filtro { TextoFiltrado = DataFiltroText.Text, CampoFiltrado = campoFiltradoSeleccionado() };
            FillGrid();

        }
        protected string campoFiltradoSeleccionado()
        {
            return fieldToFilterCombo.SelectedValue.ToString();
        }

        private void marcarAsistencia_Click(object sender, EventArgs e)
        {
            Invitado invitado = invitadoSeleccionado();
            if (invitado != null)
            {
                string mensaje = $"El invitado {invitado.Nombre} con DNI {invitado.DNI}, ¿se le concede acceso?";
                DialogResult dialogResult = MessageBox.Show(mensaje, "Confirmación de asistencia manual", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    marcarAsistente(invitado);
                }
            }
        }
        private Invitado invitadoSeleccionado()
        {
            Invitado invitado = null;
            if (gridInvitados?.SelectedRows.Count > 0)
            {
                invitado = (Invitado)gridInvitados.SelectedRows[0].DataBoundItem;
            }
            return invitado;
        }

        private void marcarAsistente(Invitado invitado)
        {
            invitado.QRLeido = "Proceso Manual";
            if (!invitado.IsRegistrado)
            {
            proceso.AceptarInvitado(invitado);
            int? indexSelecte = gridInvitados.SelectedRows[0]?.Index;
            FillGrid();
            gridInvitados.Rows[indexSelecte.GetValueOrDefault()].Selected = true;
            gridInvitados.FirstDisplayedScrollingRowIndex = indexSelecte.GetValueOrDefault();
            } else
            {
                MessageBox.Show("El invitado ya se había registrado antes");
            }
        }

        private void gridInvitados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Invitado invitado = invitadoSeleccionado();
            if (invitado != null && invitado.IsRegistrado)
            {
                contextMenuGrid.Items[0].Enabled = false;
            }
            else
            {
                contextMenuGrid.Items[0].Enabled = true;
            }
        }

        private void nuevoInvitadoButton_Click(object sender, EventArgs e)
        {
            NuevoInvitadoForm nuevoInvitadoForm = new NuevoInvitadoForm(dataService, configuracion);
            nuevoInvitadoForm.ShowDialog();
            nuevoInvitadoForm.Dispose();
            FillGrid();
        }

        private void addNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invitado invitado = invitadoSeleccionado();
            if (invitado != null)
            {
                string notasActualizadas = Prompt.ShowDialog("Notas", $"Actualizar invitado {invitado.Nombre} {invitado.DNI}", invitado.Notas);
                if (!notasActualizadas.Equals(invitado.Notas))
                {
                    invitado.Notas = notasActualizadas;
                    dataService.ActualizarNotasInvitado(invitado);
                    FillGrid();
                }

            }


        }
    }
}
