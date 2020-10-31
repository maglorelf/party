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
    public partial class ListaAsistentesForm : Form
    {
        private SortableBindingList<Asistente> asistentesBinding;
        protected DataService dataService { get; set; }
        protected IList<Tuple<string, string, int>> camposVisibles { get; set; }

        protected Proceso proceso { get; set; }
        protected Filtro filtroSeleccionado { get; set; }
        public ListaAsistentesForm(DataService dataService, Proceso proceso)
        {
            asistentesBinding = new SortableBindingList<Asistente>();
            filtroSeleccionado = null;
            this.dataService = dataService;
            this.proceso = proceso;
            InitializeComponent();
            camposVisibles = ListaCamposVisibles();
            fillComboCampos();
            FillGrid();          
        }

        public void GetAsistentes()
        {
            var asistentes = dataService.GetAllAsistentes();
            if (filtroSeleccionado != null)
            {

                var param = Expression.Parameter(typeof(Asistente), "x");
                var predicate = Expression.Lambda<Func<Asistente, bool>>(
                    Expression.Call(
                    Expression.Call(
                        Expression.PropertyOrField(param, filtroSeleccionado.CampoFiltrado),
                        "ToUpper", null),
                        "Contains", null, Expression.Constant(filtroSeleccionado.TextoFiltrado.ToUpper())
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
         
        }

        protected IList<Tuple<string, string, int>> ListaCamposVisibles()
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

        private void retirarAsistencia_Click(object sender, EventArgs e)
        {
            Asistente asistente= asistenteSeleccionado();
            if (asistente != null)
            {
                string mensaje = $"El invitado {asistente.Nombre} con DNI {asistente.DNI}, ¿se cancela la asistencia?";
                DialogResult dialogResult = MessageBox.Show(mensaje, "Confirmación de borrado de asistencia manual", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    borrarAsistente(asistente);
                }
            }
        }
        private Asistente asistenteSeleccionado()
        {
            Asistente asistente = null;
            if (gridAsistentes?.SelectedRows.Count > 0)
            {
                asistente = (Asistente)gridAsistentes.SelectedRows[0].DataBoundItem;
            }
            return asistente;
        }

        private void borrarAsistente(Asistente asistente)
        {           
            proceso.BorrarAsistente(asistente);
            FillGrid();
        }

        private void gridInvitados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Asistente asistente = asistenteSeleccionado();
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
