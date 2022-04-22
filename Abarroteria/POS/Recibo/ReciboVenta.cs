using CapaDatos.ListasPersonalizadas;
using CapaDatos.Repository;
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
    public partial class ReciboVenta : BaseContext
    {
       
        private readonly FacturasRepository _facturasRepository = null;
        private readonly ProductosRepository _productosRepository = null;
        private readonly TallasyColoresRepository tallasyColoresRepository = null;
        private readonly DetalleEstiloRepository estiloRepository = null;
        private readonly ColoresRepository coloresRepository = null;
        private readonly TallasRepository tallasRepository = null;
        
        private Guid facturaID;
        private IList<ListarDetalleFacturas> listadetalles = null;
        private Pago pagoForms = null;
        private string empleado = UsuarioLogeadoPOS.User.Name;

        public ReciboVenta(Pago forms,Guid idfact)
        {
            pagoForms = forms;
            facturaID = idfact;
            listadetalles = new List<ListarDetalleFacturas>();
            _facturasRepository = new FacturasRepository(_context);
            _productosRepository = new ProductosRepository(_context);
            tallasyColoresRepository = new TallasyColoresRepository(_context);
            estiloRepository = new DetalleEstiloRepository(_context);
            coloresRepository = new ColoresRepository(_context);
            tallasRepository = new TallasRepository(_context);
            InitializeComponent();            
        }

        private void ReciboVenta_Load(object sender, EventArgs e)
        {
            CargarTabla();
            traerparametros();
            this.rvRecibo.RefreshReport();
            pagoForms.Close();
        }

        private void CargarTabla()
        {
            var lista = _facturasRepository.GetDetallebyFactura(facturaID).ToList();
            listadetalles = GetListadoConDetalles(lista);
            rvRecibo.LocalReport.ReportEmbeddedResource = "POS.Recibo.ReciboVenta.rdlc";
            var rds1 = new ReportDataSource("detalleFactura", listadetalles);
            rvRecibo.LocalReport.DataSources.Clear();
            rvRecibo.LocalReport.DataSources.Add(rds1);
        }

        private void traerparametros()
        {
            var encabezadoFactura= _facturasRepository.Get(facturaID);

            ReportParameterCollection reportParameters = new ReportParameterCollection
            {
                new ReportParameter("fecha",encabezadoFactura.FechaVenta.ToString() ),
                new ReportParameter("comprobante",encabezadoFactura.NoFactura ),
                new ReportParameter("nombrecliente",encabezadoFactura.Nombre ),
                new ReportParameter("nitcliente",encabezadoFactura.NIT ),
                 new ReportParameter("direccioncliente",encabezadoFactura.Direccion ),
                new ReportParameter("empleado",empleado ),
            };
            rvRecibo.LocalReport.SetParameters(reportParameters);

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

                    if (!listDetFac.EsRecarga)
                    {
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
                    else
                    {
                        foreach (var item in element)
                        {
                            listadoFact.Add(item);
                        }
                    }
                    
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
                foreach (var item in listrec)
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
                    if (color != null)
                        Descripcion += "\n" + item.Cantidad + " " + color.Color;
                    break;
                case 2:
                    var talla = tallasRepository.GetDetalleTalla(item.DetalleTallaId);
                    if (talla != null)
                        Descripcion += "\n" + item.Cantidad + " " + talla.Talla;
                    break;
                case 3:
                    var colortalla = tallasyColoresRepository.GetColorTalla(item.TallayColorId);
                    if (colortalla != null)
                        Descripcion += "\n" + item.Cantidad + " " + colortalla.Color + "-" + colortalla.Talla;
                    break;
                case 4:
                    var estilos = estiloRepository.GetDetalleEstilo(item.EstiloId);
                    if (estilos != null)
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
