using CapaDatos.ListasPersonalizadas;
using CapaDatos.Models.DocumentoSAT;
using CapaDatos.Repository;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.Reporting.WinForms;
using POS.Forms;
using sharedDatabase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Recibo
{
    public partial class ReporteReciboCliente : BaseContext
    {
        private readonly FacturasRepository _facturasRepository = null;
        private IList<ListarDetalleFacturas> listadetalles = null;
        private readonly DocumentoCertificadoSAT DocCertificado = null;
        private readonly ProductosRepository _productosRepository = null;
        private readonly TallasyColoresRepository tallasyColoresRepository = null;
        private readonly DetalleEstiloRepository estiloRepository = null;
        private readonly ColoresRepository coloresRepository = null;
        private readonly TallasRepository tallasRepository = null;

        private Pago pagoForms = null;
        private Guid idfactura;
        public ReporteReciboCliente(Pago forms, Guid idfac, DocumentoCertificadoSAT DocCertif)
        {
            pagoForms = forms;
            idfactura = idfac;
            DocCertificado = DocCertif;
            _facturasRepository = new FacturasRepository(_context);
            _productosRepository = new ProductosRepository(_context);
            tallasyColoresRepository = new TallasyColoresRepository(_context);
            estiloRepository = new DetalleEstiloRepository(_context);
            coloresRepository = new ColoresRepository(_context);
            tallasRepository = new TallasRepository(_context);
            InitializeComponent();
        }

        private void ReporteReciboCliente_Load(object sender, EventArgs e)
        {
             CargarTabla();
          ///  listadetalles = _facturasRepository.GetDetallebyFactura(idfactura);
            traerparametros();
            this.rvporte.RefreshReport();

            //  pagoForms.Close();


           
        }
        private void CargarTabla()
        {
           var lista = _facturasRepository.GetDetallebyFactura(idfactura).ToList();
            listadetalles = GetListadoConDetalles(lista);
            //rvfacturafel.LocalReport.ReportEmbeddedResource = "POS.Recibo.FacturaFEL.rdlc";
            rvporte.LocalReport.ReportEmbeddedResource = "POS.Recibo.ReporteReciboCliente.rdlc";
            var rds1 = new ReportDataSource("detallefactura", listadetalles);
            rvporte.LocalReport.DataSources.Clear();
            rvporte.LocalReport.DataSources.Add(rds1);

        }
       

        private void traerparametros()
        {
            try
            {
                decimal iva = 0.10714284m;
                var sumatotal = listadetalles.Sum(x => x.PrecioTotal);
                var direccionCl = _facturasRepository.Get(idfactura);
                var ivatotal = sumatotal * iva;

                ReportParameterCollection reportParameters = new ReportParameterCollection
                {
                    new ReportParameter("noautorizacion",DocCertificado.Autorizacion ),
                    new ReportParameter("nombrecomprador",DocCertificado.NOMBRE_COMPRADOR),
                    new ReportParameter("nitcomprador",DocCertificado.NIT_COMPRADOR),
                    new ReportParameter("fechaemision",DocCertificado.Fecha_DTE.ToString()),
                    new ReportParameter("nombreeface", "RED OWL SOFTWARE"),
                    new ReportParameter("niteface", DocCertificado.NIT_EFACE),
                    new ReportParameter("ivatotal",ivatotal.ToString("0.0000")),
                    new ReportParameter("totalfactura",sumatotal.ToString("0.00")),
                    new ReportParameter("serie" ,DocCertificado.Serie),
                    new ReportParameter("numero",DocCertificado.NUMERO),
                    new ReportParameter("direccion","GUATEMALA, GUATEMALA"),
                };
                rvporte.LocalReport.SetParameters(reportParameters);
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error en traer los parametros de Recibo " + ex.Message);
            }
            
        }
        private List<ListarDetalleFacturas> GetListadoConDetalles(List<ListarDetalleFacturas> listado)
        {
            List<ListarDetalleFacturas> listadoFact = new List<ListarDetalleFacturas>();
            var list = listado.Where(x => x.DetalleRecargaId == 0).GroupBy(x => x.ProductoId);
            var listrec = listado.Where(x => x.DetalleRecargaId > 0).ToList();
            foreach (var element in list)
            {
                if (element.Count() > 1)
                {
                    ListarDetalleFacturas listDetFac = element.FirstOrDefault();
                    string Descripcion = listDetFac.Descripcion;
                    foreach (var item in element)
                    {
                        Descripcion = ObtenerDetalle(item, Descripcion);
                    }
                    listDetFac.Descripcion = Descripcion;
                    listDetFac.Cantidad = element.Sum(x => x.Cantidad);
                    listDetFac.SubTotal = element.Sum(x => x.SubTotal);
                    listDetFac.PrecioTotal = element.Sum(x => x.PrecioTotal);
                    listadoFact.Add(listDetFac);
                }
                else if (element.Count() == 1)
                {
                    if (TieneDetalle(element.FirstOrDefault().ProductoId))
                    {
                        string Desccripcion = ObtenerDetalle(element.FirstOrDefault(), element.FirstOrDefault().Descripcion);
                        element.FirstOrDefault().Descripcion = Desccripcion;
                        listadoFact.Add(element.FirstOrDefault());
                    }
                    else
                    {
                        listadoFact.Add(element.FirstOrDefault());
                    }
                }
            }

            if (listrec.Count() > 0)
            {
                foreach(var item in listrec)
                {
                    listadoFact.Add(item);
                }
            }

            return listadoFact;
        }

        private string ObtenerDetalle(ListarDetalleFacturas item, string Descripcion)
        {
            switch (ObtenerTipoDetalle(item.ProductoId))
            {
                case 1:
                    var color = coloresRepository.GetDetalleColor(item.DetalleColorId);
                    Descripcion += "\n" + item.Cantidad + " " + color.Color;
                    break;
                case 2:
                    var talla = tallasRepository.GetDetalleTalla(item.DetalleTallaId);
                    Descripcion += "\n" + item.Cantidad + " " + talla.Talla;
                    break;
                case 3:
                    var colortalla = tallasyColoresRepository.GetColorTalla(item.TallayColorId);
                    Descripcion += "\n" + item.Cantidad + " " + colortalla.Color + "-" + colortalla.Talla;
                    break;
                case 4:
                    var estilos = estiloRepository.GetDetalleEstilo(item.EstiloId);
                    Descripcion += "\n" + item.Cantidad + " " + estilos.Estilo;
                    break;
            }
            return Descripcion;
        }

        private int ObtenerTipoDetalle(int ProductoId)
        {
            if (ProductoId > 0)
            {
                Producto producto = _productosRepository.Get(ProductoId);
                if (producto.TieneColor == true && producto.TieneTalla == false)
                    return 1;
                else if (producto.TieneColor == false && producto.TieneTalla == true)
                    return 2;
                else if (producto.TieneColor == true && producto.TieneTalla == true)
                    return 3;
                else if (producto.TieneEstilo == true)
                    return 4;
                else
                    return 0;
            }
            else
            {
                return 0;
            }
        }

        private bool TieneDetalle(int ProductoId)
        {
            Producto producto = _productosRepository.Get(ProductoId);
            if (producto.TieneColor || producto.TieneTalla || producto.TieneEstilo || producto.TieneColor)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
