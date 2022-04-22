using CapaDatos.Data;
using CapaDatos.ListasPersonalizadas;
using CapaDatos.Repository;
using ComponentFactory.Krypton.Toolkit;
using Sistema.Reports.Reports_Combos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Forms.modulo_combos
{
    public partial class VerCombos : BaseContext
    {
      //  private ProductosRepository _productosRepository = null;
        private CombosRepository _combosRepository = null;
        private IList<ListarCombos> combos = null;
        public VerCombos()
        {
            _combosRepository = new CombosRepository(_context);
            InitializeComponent();
        }

        private void ListarCombos_Load(object sender, EventArgs e)
        {
            RefrescarDataGridProductos(false);
           // base.OnLoad(e);

        }

        public void RefrescarDataGridProductos(bool loadNewContext = true)
        {
            if (loadNewContext)
            {
                _context = null;
                _context = new Context();
                _combosRepository = null;
                _combosRepository = new CombosRepository(_context);
            }

            BindingSource source = new BindingSource();
             combos = _combosRepository.GetListarCombos(UsuarioLogeadoSistemas.User.SucursalId)
                                       .OrderByDescending(x => x.FechaInicio)
                                       .ToList();
            source.DataSource = combos;
            listproductos.DataSource = typeof(List<>);           
            listproductos.DataSource = source;
            listproductos.AutoResizeColumns();
            listproductos.Columns[1].Visible = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ReporteCombos combosreporte = new ReporteCombos();
            combosreporte.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            RefrescarDataGridProductos(true);
        }

        private void btnDetalleP_Click(object sender, EventArgs e)
        {
            if (listproductos.CurrentRow == null)
            {
                return;
            }

            var producto = (ListarCombos)listproductos.CurrentRow.DataBoundItem;
            var Getproducto = _combosRepository.Get(producto.IdCombo);

            EditarCombos childForm = new EditarCombos(Getproducto, this); // me sirve para refrescar el dg cie el thiscunado regrese
            childForm.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (listproductos.CurrentRow == null)
            {
                return;
            }

            var dialog = KryptonMessageBox.Show("¿Está seguro que desea eliminar el combo de la lista?", "Eliminar combo",
               MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2);
            // dale proba okoko

            if (dialog == DialogResult.Yes)
            {
                var combofila = (ListarCombos)listproductos.CurrentRow.DataBoundItem;
                var ComboObtenido = _combosRepository.Get(combofila.IdCombo);
                ComboObtenido.isActive = true;
                _combosRepository.Update(ComboObtenido);
                _combosRepository.DeleteDetalles(combofila.IdCombo);
                RefrescarDataGridProductos(true);

            }
        }

        private void buscarprod_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            var filtro = combos.Where(a => a.Descripcion.Contains(txtbuscar.Text) ||
         (a.Descripcion != null && a.Descripcion.Contains(txtbuscar.Text)) 
           );
            listproductos.DataSource = filtro.ToList();
        }
    }
}
