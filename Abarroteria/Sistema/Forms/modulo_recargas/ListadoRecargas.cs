using CapaDatos.Data;
using CapaDatos.ListasPersonalizadas;
using CapaDatos.Repository;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Forms.modulo_recargas
{
    public partial class ListadoRecargas : BaseContext
    {
        private RecargasRepository _recargasRepository = null;
        private List<ListarRecargas> _listado = new List<ListarRecargas>();
        public ListadoRecargas()
        {
            _recargasRepository = new RecargasRepository(_context);
            InitializeComponent();
        }

        private void ListadoRecargas_Load(object sender, EventArgs e)
        {
            RefrescarDataGridProductos();
        }

        public void RefrescarDataGridProductos(bool loadNewContext = true)
        {
            if (loadNewContext)
            {
                _context = null;
                _context = new Context();
                _recargasRepository = null;
                _recargasRepository = new RecargasRepository(_context);
            }

            BindingSource source = new BindingSource();
            _listado = _recargasRepository.GetListarRecargas(UsuarioLogeadoSistemas.User.SucursalId).ToList();
            source.DataSource = _listado;
            listRecargas.DataSource = source;
            listRecargas.ClearSelection();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            BuscarProductos();
        }

        private void BuscarProductos()
        {
            try
            {
                string txt1 = txtBuscador.Text;
                String txt2 = txtBuscador.Text.ToUpper();
                BindingSource source = new BindingSource();

                List<ListarRecargas> filter = _listado.Where(a => a.Descripcion.Contains(txt1) || a.Descripcion.Contains(txt2) ||
                                                                  a.DescripcionCorta.Contains(txt1) || a.DescripcionCorta.Contains(txt2)).ToList();
                
                source.DataSource = filter;
                listRecargas.DataSource = source;
                listRecargas.ClearSelection();
            }
            catch (Exception ex)
            {

                KryptonMessageBox.Show("BuscarProductos() ha fallado! " + ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (listRecargas.CurrentRow != null)
            {
                var dialog = KryptonMessageBox.Show("¿Está seguro que desea eliminar la recarga del sistema?", "Eliminar Recarga",
               MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2);

                if (dialog == DialogResult.Yes)
                {
                    var recargalista = (ListarRecargas)listRecargas.CurrentRow.DataBoundItem;
                    var recarga = _recargasRepository.Get(recargalista.Id);
                    recarga.Deleted = true;
                    _recargasRepository.Update(recarga);
                    RefrescarDataGridProductos(true);
                }
            }
            else
            {
                KryptonMessageBox.Show("Debe seleccionar una recarga en la columna 'Deleted'", "Notificación");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            RefrescarDataGridProductos(true);
        }

        private void btnDetalleP_Click(object sender, EventArgs e)
        {
            if (listRecargas.CurrentRow != null)
            {
                var recargalista = (ListarRecargas)listRecargas.CurrentRow.DataBoundItem;
                var recarga = _recargasRepository.Get(recargalista.Id);
                if (Application.OpenForms["EditarRecarga"] == null)
                {
                    EditarRecargas editarRecarga = new EditarRecargas(recarga, this, true);
                    editarRecarga.Show();
                }
                else
                {
                    Application.OpenForms["EditarRecarga"].Activate();
                }
            }
            else
            {
                KryptonMessageBox.Show("Debe seleccionar una recarga", "Notificación");
            }
        }
    }
}
