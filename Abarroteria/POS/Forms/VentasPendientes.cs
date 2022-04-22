using CapaDatos.ListasPersonalizadas;
using CapaDatos.ListasPersonalizadas.VentasAcumuladas;
using CapaDatos.Models.ProductosToFacturar;
using CapaDatos.Repository;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.
namespace POS.Forms
{
    public partial class VentasPendientes : BaseContext
        
    {
        private ProductosTempRepository _productosTempRepository = null;
        private List<ListaProductosTmp> listaDetalles = null;
        private PrincipalV2 _principal = null;
        
        public VentasPendientes(PrincipalV2 forms)
        {
            _productosTempRepository = new ProductosTempRepository(_context);
            _principal = forms;
            InitializeComponent();
        }

        private void VentasPendientes_Load(object sender, EventArgs e)
        {
            CargarProductosAcumulados();
        }

        private void CargarProductosAcumulados()
        {
            try
            {
                var lista = _productosTempRepository.GetTemporalProductosLista()
                                                    .Where(x => x.IsActive == false).ToList();
                BindingSource source = new BindingSource();
                source.DataSource = lista;
                dgVentasPendientes.DataSource = typeof(List<>);
                dgVentasPendientes.DataSource = lista;
                dgVentasPendientes.AutoResizeColumns();
                dgVentasPendientes.ClearSelection();
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message);
            }          
        }
        
        private void CrearListaBySelected()
        {
            int colAcciones = 15;
            int filasSeleccion = 0;
            int contador = 0;
            listaDetalles = new List<ListaProductosTmp>();
            try
            {
                foreach (DataGridViewRow rows in dgVentasPendientes.Rows)
                {
                    bool acciones = Convert.ToBoolean(rows.Cells[colAcciones].Value);
                    if (!acciones)
                    {
                        filasSeleccion += 1;
                    }
                    else
                    {
                        var fila = (ListaProductosTmp)dgVentasPendientes.Rows[contador].DataBoundItem;
                        listaDetalles.Add(fila);
                    }
                    contador += 1;
                }               
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error",ex.Message);
                return;
            }
        }

        public List<ListarDetalleFacturas> GetCotizacionToFacturaDetalle(List<ListaProductosTmp> listatmp)
        {
              var listfactura = new List<ListarDetalleFacturas>();

            foreach (var item in listatmp)
            {
                if (listatmp == null) { continue; }
                var detalleFactura = GetDetalleFactura();
                detalleFactura.Id = item.Id;
                detalleFactura.DetalleColorId = item.DetalleColorId;
                detalleFactura.DetalleTallaId = item.DetalleTallaId;
                detalleFactura.TallayColorId = item.TallayColorId;
                detalleFactura.Color = item.Color;
                detalleFactura.Talla = item.Talla;
                detalleFactura.ProductoId = (int)item.ProductoId;
                detalleFactura.Descripcion = item.Descripcion;
                detalleFactura.Cantidad = item.Cantidad;
                detalleFactura.Precio = item.Precio;
                detalleFactura.Descuento = 0;
                detalleFactura.PrecioTotal = item.PrecioTotal;
                detalleFactura.SubTotal = detalleFactura.PrecioTotal;
                detalleFactura.ComboId = item.ComboId;
                detalleFactura.EstiloId = item.DetalleEstiloId;
                detalleFactura.Estilo = item.Estilo;
                listfactura.Add(detalleFactura);
            }
            return listfactura;
        }

        public ListarDetalleFacturas GetDetalleFactura()
        {
            return new ListarDetalleFacturas()
            {
            };
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
             CrearListaBySelected();
            if (listaDetalles.Count <= 0) { KryptonMessageBox.Show("Debe Seleccionar un producto"); return; }
            var listafacturaconver = GetCotizacionToFacturaDetalle(listaDetalles);
            foreach (var item in listafacturaconver)
            {
                _principal._listaDetalleFacturas.Add(item);
            }           
            _principal.cargarDGVDetalleFactura(_principal._listaDetalleFacturas);
            _principal.cargarDGVDetalleFactura(_principal.GetCotizacionToFacturaDetalle());
            Close();
        }

        private void dgVentasPendientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarFila(dgVentasPendientes, 15);
        }

        private void SeleccionarFila(DataGridView datagrid, int acciones)
        {
            bool estadoActual = Convert.ToBoolean(datagrid.CurrentRow.Cells[acciones].Value);
            if (estadoActual)
            {
                datagrid.CurrentRow.Cells[acciones].Value = false;
            }
            else
            {
                datagrid.CurrentRow.Cells[acciones].Value = true;
            }            
        }

        private void chbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            int acciones = 15;
            if (chbSelectAll.Checked == true)
            {
                if (dgVentasPendientes.RowCount > 0)
                {
                    foreach (DataGridViewRow row in dgVentasPendientes.Rows)
                    {
                        row.Cells[acciones].Value = true;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgVentasPendientes.Rows)
                {
                    row.Cells[acciones].Value = false;
                }
            }
        }

        private TemporalProductos GetTempProd(ListaProductosTmp tmp)
        {
            TemporalProductos temporal = _productosTempRepository.GetTemporal(tmp.Id);
            temporal.IsActive = true;
            return temporal;
        }

        private void pbTrash_Click(object sender, EventArgs e)
        {
            CrearListaBySelected();
            if (listaDetalles.Count <= 0) { KryptonMessageBox.Show("Debe Seleccionar un producto"); return; }
            
            foreach (var item in listaDetalles)
            {
                _productosTempRepository.Update(GetTempProd(item));
            }

            CargarProductosAcumulados();
        }
    }
}
