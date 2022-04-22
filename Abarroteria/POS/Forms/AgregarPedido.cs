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
    public partial class AgregarPedido : BaseContext
    {
        private List<ListarDetallePedidos> listadetalles = new List<ListarDetallePedidos>();
        private IList<ListarPedidos> listaPedidos = null;
        private PedidoRepository _pedidoRepository = null;
        private PrincipalV2 _principal = null;

        public AgregarPedido(PrincipalV2 forms)
        {
            _pedidoRepository = new PedidoRepository(_context);
            _principal = forms;
            InitializeComponent();
        }

        private void AgregarPedido_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }

        public void cargarDGV()
        {
            listaPedidos = _pedidoRepository.GetListGenerales(0);
            BindingSource source = new BindingSource();
            source.DataSource = listaPedidos;
            dgvPedidos.DataSource = typeof(List<>);
            dgvPedidos.DataSource = source;
            dgvPedidos.AutoResizeColumns();
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow == null)
            {
                return;
            }
            var pedidos = (ListarPedidos)dgvPedidos.CurrentRow.DataBoundItem;
            if (_pedidoRepository.GetListDetallePedido(pedidos.Id) == null) { return; }
             listadetalles = _pedidoRepository.GetListDetallePedido(pedidos.Id);
            _principal.idPedido = pedidos.Id;
            _principal._listadetallesPedidos = listadetalles;
            _principal.pedidos.Add(pedidos);
            _principal.cargarDGVDetalleFactura(_principal.GetPedidoToFacturaDetalle());
            Close();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            var filtro = listaPedidos.Where(a => a.Cliente.Contains(txtbuscar.Text) ||
            (a.Cliente != null && a.Cliente.Contains(txtbuscar.Text)) ||
            (a.Cliente != null && a.Cliente.Contains(txtbuscar.Text)));
            dgvPedidos.DataSource = filtro.ToList();
        }      
    }
}
