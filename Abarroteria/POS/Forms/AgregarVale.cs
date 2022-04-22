using CapaDatos.ListasPersonalizadas;
using CapaDatos.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Forms
{
    public partial class AgregarVale : BaseContext
    {
        private ValesRepository _valesRepository = null;
        private PrincipalV2 _principal = null;
        private IList<ListarVales> listaVales = new List<ListarVales>();
        
        public AgregarVale(PrincipalV2 principal)
        {           
            InitializeComponent();
            _principal = principal;
            _valesRepository = new ValesRepository(_context);
        }

        private void AgregarVale_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }

        public void cargarDGV()
        {
            listaVales = _valesRepository.GetListaVales();
            BindingSource source = new BindingSource();
            source.DataSource = listaVales;
            dgvVales.DataSource = typeof(List<>);
            dgvVales.DataSource = source;
            dgvVales.AutoResizeColumns();
            dgvVales.Columns[0].Visible = false;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            var filter = listaVales.Where(a => a.Descripcion.Contains(txtbuscar.Text) ||
            (a.Sucursal != null && a.Sucursal.Contains(txtbuscar.Text)) ||
            (a.Tipo != null && a.Tipo.Contains(txtbuscar.Text)));
            dgvVales.DataSource = filter.ToList();
        }     

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            if (dgvVales.CurrentRow == null)
            {
                return;
            }
            var vale = (ListarVales)dgvVales.CurrentRow.DataBoundItem;
            _principal._valeSelected = vale;
            _principal.cargarValeLabel();
            _principal.vales.Add(vale);
            Close();
        }
    }
}
