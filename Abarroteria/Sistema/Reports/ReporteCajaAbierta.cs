using CapaDatos.ListasPersonalizadas;
using CapaDatos.Repository;
using Microsoft.Reporting.WinForms;
using Sistema.Reports.Reports_Caja;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Reports
{
    public partial class ReporteCajaAbierta : BaseContext
    {
        private CajasRepository _cajaRepository = null;
        // public int idSucursal = 0;
        public int idcajaAbierta = 0;
        public string nombreSucursal;


        private IList<ListarCajaDetalles> listarCajas => _cajaRepository.GetDetalleCaja(idcajaAbierta);//FechaInicio, FechaFinal.AddDays(1));

        private decimal? sumatotal => listarCajas.Sum(a => a.Efectivo + a.Cheques + a.TarjetaDebito + a.TarjetaCredito + a.Transferencias  - a.Egreso);
        public ReporteCajaAbierta()
        {
            _cajaRepository = new CajasRepository(_context);
            InitializeComponent();
            cargarTextbox();
        }

        private void ReporteCajaAbierta_Load(object sender, EventArgs e)
        {
            CargarTabla();
            this.reportViewer1.RefreshReport();
        }
        public void CargarTabla()
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Reports.CajaAbiertas.rdlc";
            var reportDataSource = new ReportDataSource("CajaActual", listarCajas);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);


        }

        public void cargarTextbox()
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection
            {

                new ReportParameter("NombreVendedor",UsuarioLogeadoSistemas.User.Name),
                new ReportParameter("Sucursal","Central"),
                new ReportParameter("usuario",UsuarioLogeadoSistemas.User.UserName),
                new ReportParameter("FechaInicio",DateTime.Now.ToString()),
                new ReportParameter("FechaFin",DateTime.Now.ToString()),

            };
            reportViewer1.LocalReport.SetParameters(reportParameters);
        }

        private void btnsucursal_Click(object sender, EventArgs e)
        {
            FiltroSucursal filtroSucursal = new FiltroSucursal(this);
            filtroSucursal.Show();
        }
    }
}
