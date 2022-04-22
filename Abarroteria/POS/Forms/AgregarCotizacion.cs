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
    public partial class AgregarCotizacion : BaseContext
    {
        private CotizacionRepository _cotizacionRepository = null;
        private IList<ListarCotizaciones> listaCotiz = null;
        private PrincipalV2 _principal = null;
        
        public AgregarCotizacion(PrincipalV2 forms)
        {
            InitializeComponent();
            _principal = forms;
            _cotizacionRepository = new CotizacionRepository(_context);
        }

        private void AgregarCotizacion_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }

        public void cargarDGV()
        {
            listaCotiz = _cotizacionRepository.GetListGenerales(0);
            listaCotiz = listaCotiz.Where(x => x.IsActive == false).ToList();
            BindingSource source = new BindingSource();
            source.DataSource = listaCotiz;
            dgvCotizaciones.DataSource = typeof(List<>);
            dgvCotizaciones.DataSource = source;
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            if (dgvCotizaciones.CurrentRow == null)
            {
                return;
            }
            var cotizacion = (ListarCotizaciones)dgvCotizaciones.CurrentRow.DataBoundItem;
            if (_cotizacionRepository.GetDetalleCotizacionslista(cotizacion.Id) == null) { return; }
            var listadetalles = _cotizacionRepository.GetListDetalleCotiz(cotizacion.Id);
            _principal.idCotizacion = cotizacion.Id;
            _principal._listadetallesCotiz = listadetalles;
            _principal.cotizaciones.Add(cotizacion);
            _principal.cargarDGVDetalleFactura(_principal.GetCotizacionToFacturaDetalle());
            Close();
        }

        private void txtbuscarcotiza_TextChanged(object sender, EventArgs e)
        {
            var filtro = listaCotiz.Where(a => a.Nombre.Contains(txtbuscarcotiza.Text) ||
            (a.Nombre != null && a.Nombre.Contains(txtbuscarcotiza.Text)) ||
            (a.Apellido != null && a.Apellido.Contains(txtbuscarcotiza.Text)) ||
            (a.NoCotizacion != null && a.NoCotizacion.Contains(txtbuscarcotiza.Text)) ||
            (a.Nit != null && a.Nit.Contains(txtbuscarcotiza.Text)) ||
            (a.Cliente != null && a.Cliente.Contains(txtbuscarcotiza.Text)));
            dgvCotizaciones.DataSource = filtro.ToList();
        }
    }
}
