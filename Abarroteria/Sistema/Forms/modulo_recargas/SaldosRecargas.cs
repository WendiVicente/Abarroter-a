using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos.Repository;
using sharedDatabase.Models;
using CapaDatos.ListasPersonalizadas;
using CapaDatos.Models.Productos;
using ComponentFactory.Krypton.Toolkit;
using CapaDatos.Validation;
using sharedDatabase.Models.Caja;

namespace Sistema.Forms.modulo_recargas
{
    public partial class SaldosRecargas : BaseContext
    {
        private RecargasRepository _recargasRepository = null;
        private CajasRepository _cajasRepository = null;

        List<SaldoRecarga> historial = new List<SaldoRecarga>();
        List<ListarHistorialRecargas> listaGrid = new List<ListarHistorialRecargas>();
        private string Empresa = "";
        private decimal SaldoActualTigo;
        private decimal SaldoActualClaro;
        private Caja cajaObtenida = null;
        
        public SaldosRecargas()
        {
            _recargasRepository = new RecargasRepository(_context);
            _cajasRepository = new CajasRepository(_context);
            InitializeComponent();
        }

        private void SaldoRecarga_Load(object sender, EventArgs e)
        {
            CargarCampos();
        }

        private void CargarCampos()
        {
            CargarHistorial("");
            CargarSaldos();
            dtpFecha.Value = DateTime.Now;
            TxtNuevoSaldo.Text = "0.00";
            RbClaro.Checked = false;
            RbTigo.Checked = false;
        }

        private void CargarHistorial(string empresa)
        {
            historial = _recargasRepository.GetAllHistorial(UsuarioLogeadoSistemas.User.SucursalId);
            listaGrid = _recargasRepository.GetListarHistorial(UsuarioLogeadoSistemas.User.SucursalId);
            if (empresa.Length > 0)
            {
                listaGrid = listaGrid.Where(x => x.Empresa == empresa).ToList();
            }
            DgvHistorialSaldos.DataSource = typeof(List<>);
            DgvHistorialSaldos.DataSource = listaGrid;
            DgvHistorialSaldos.ClearSelection();
        }

        private void CargarSaldos()
        {
            if (historial.Count() > 0)
            {
                var htigo = historial.Where(x => x.Empresa == "TIGO");
                if (htigo.Count() > 0)
                {
                    SaldoActualTigo = htigo.LastOrDefault().SaldoActual;
                    lbSaldoActualTigo.Text = SaldoActualTigo.ToString();
                }
                var hclaro = historial.Where(x => x.Empresa == "CLARO");
                if (hclaro.Count() > 0)
                {
                    SaldoActualClaro = hclaro.LastOrDefault().SaldoActual;
                    lbSaldoActualClaro.Text = SaldoActualClaro.ToString();
                }                
            }
        }

        private void RbTigo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbTigo.Checked)
            {
                Empresa = "TIGO";
                CargarHistorial(Empresa);
            }
        }

        private void RbClaro_CheckedChanged(object sender, EventArgs e)
        {
            if(RbClaro.Checked)
            {
                Empresa = "CLARO";
                CargarHistorial(Empresa);
            }
        }

        private void TxtNuevoSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    SaldoRecarga nuevoSaldo = GetViewModel();
                   // DetalleCaja detalleCaja = GetModelCaja();
                    if (ModelState.IsValid(nuevoSaldo)/* && ModelState.IsValid(detalleCaja)*/)
                    {
                        _recargasRepository.AddSaldo(nuevoSaldo);
                       // _cajasRepository.AddDetalleCaja(detalleCaja);
                    }
                    CargarCampos();
                }
            }
            catch 
            {
                KryptonMessageBox.Show("Ha ocurrido un error interno al guardar la informmacion.", "ERROR");
            }            
        }

        private bool ValidarCampos()
        {
            cajaObtenida = _cajasRepository.GetCajaAperturada(UsuarioLogeadoSistemas.User.SucursalId);
            if (RbTigo.Checked == false && RbClaro.Checked == false)
            {
                KryptonMessageBox.Show("Debe seleccionar una Compañía", "Notificación");
                return false;
            }
            if (cajaObtenida == null)
            {
                KryptonMessageBox.Show("No se encuentra ninguna caja abierta", "Notificación");
                return false;
            }
            if (!string.IsNullOrEmpty(TxtNuevoSaldo.Text))
            {
                decimal compara = 0.00m;
                decimal preciov = Convert.ToDecimal(TxtNuevoSaldo.Text);

                if (preciov <= compara)
                {
                    KryptonMessageBox.Show("Debe ingresar una cantidad válida en Precio Venta", "Notificación");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        private SaldoRecarga GetViewModel()
        {
            SaldoRecarga nuevoSaldo = new SaldoRecarga();

            nuevoSaldo.SucursalId = UsuarioLogeadoSistemas.User.SucursalId;
            nuevoSaldo.Empresa = Empresa;
            if (Empresa == "TIGO")
            {
                nuevoSaldo.SaldoInicial = SaldoActualTigo;                
            }
            else if (Empresa == "CLARO")
            {
                nuevoSaldo.SaldoInicial = SaldoActualClaro;
            }
            nuevoSaldo.Saldo = Convert.ToDecimal(TxtNuevoSaldo.Text);
            nuevoSaldo.SaldoActual = nuevoSaldo.SaldoInicial + nuevoSaldo.Saldo;
            nuevoSaldo.FechaTransferencia = dtpFecha.Value;
            return nuevoSaldo;            
        }

        private DetalleCaja GetModelCaja()
        {
            return new DetalleCaja
            {
                CajaId  = cajaObtenida.Id,
                Descripcion = "Compra de saldo " + Empresa,
                Egreso = Convert.ToDecimal(TxtNuevoSaldo.Text)
            };
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvHistorialSaldos.CurrentRow != null)
            {
                DialogResult dialogResult = KryptonMessageBox.Show("¿Esta seguro de eliminar permanentemente del historial?", "Notificación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var fila = DgvHistorialSaldos.CurrentRow;
                    var detallesaldo = (ListarHistorialRecargas)fila.DataBoundItem;
                    //cajaObtenida = _cajasRepository.GetCajaAperturada(UsuarioLogeadoSistemas.User.SucursalId);
                    var saldo = _recargasRepository.GetSaldo(detallesaldo.Id);

                    //DetalleCaja detalleCaja = new DetalleCaja();
                    //detalleCaja.CajaId = cajaObtenida.Id;
                    //detalleCaja.Descripcion = "Cancelacion de egreso de saldo " + saldo.Empresa;
                    //detalleCaja.Efectivo = saldo.Saldo;
                    //_cajasRepository.AddDetalleCaja(detalleCaja);
                    _recargasRepository.DeleteSaldo(saldo);
                    CargarCampos();
                }
            }
            else
            {
                KryptonMessageBox.Show("Debe seleccionar un elemento", "Notificación");
            }
        }
    }
}
