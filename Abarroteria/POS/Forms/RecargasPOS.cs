using CapaDatos.Data;
using CapaDatos.ListasPersonalizadas;
using CapaDatos.Models.Productos;
using CapaDatos.Repository;
using CapaDatos.Validation;
using ComponentFactory.Krypton.Toolkit;
using sharedDatabase.Models.Caja;
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
    public partial class RecargasPOS : BaseContext
    {
        private RecargasRepository _recargasRepository = null;
        private CajasRepository _cajasRepository = null;
        private List<ListarRecargas> _listado = new List<ListarRecargas>();
        private List<CheckBox> checkBoxesSaldo = new List<CheckBox>();
        private ListarRecargas recargaLocal;
        private string Empresa = "";
        private string Tipo = "";
        private Caja cajaObtenida = null;
        private PrincipalV2 Principallocal = null;
        private decimal SaldoActualTigo;
        private decimal SaldoActualClaro;
        private decimal MontoRecarga;

        public RecargasPOS(PrincipalV2 principal)
        {
            Principallocal = principal;
            _recargasRepository = new RecargasRepository(_context);
            _cajasRepository = new CajasRepository(_context);
            recargaLocal = new ListarRecargas();            
            InitializeComponent();
        }

        private void RecargasPOS_Load(object sender, EventArgs e)
        {
            RefrescarDataGridProductos();
            CargarCheckBoxSaldo();
            CargarSaldos();
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
            _listado = _recargasRepository.GetListarRecargas(UsuarioLogeadoPOS.User.SucursalId).ToList();
            source.DataSource = _listado;
            listRecargas.DataSource = source;
            listRecargas.ClearSelection();
        }

        private void CargarCheckBoxSaldo()
        {
            checkBoxesSaldo.Add(CheckSaldo5);
            checkBoxesSaldo.Add(CheckSaldo10);
            checkBoxesSaldo.Add(CheckSaldo15);
            checkBoxesSaldo.Add(CheckSaldo20);
            checkBoxesSaldo.Add(CheckSaldo25);
            checkBoxesSaldo.Add(CheckSaldo50);
            checkBoxesSaldo.Add(CheckSaldo100);
            checkBoxesSaldo.Add(CheckSaldo150);
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            RefrescarDataGridProductos(true);
        }

        private void RbTigo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbTigo.Checked)
            {
                Empresa = "TIGO";
                CargarLista(Empresa);
            }
        }

        private void RbClaro_CheckedChanged(object sender, EventArgs e)
        {
            if (RbClaro.Checked)
            {
                Empresa = "CLARO";
                CargarLista(Empresa);
            }
        }

        private void CargarLista(string empresa)
        {
            List<ListarRecargas> listado = new List<ListarRecargas>();
            if (empresa.Length > 0)
            {
                listado = _listado.Where(x => x.Empresa == empresa).ToList();
            }
            listRecargas.DataSource = typeof(List<>);
            listRecargas.DataSource = listado;
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;

                }
            }
            catch
            {
                KryptonMessageBox.Show("ERROR KEYPRESS", "ERROR");
            }            
        }

        private void listRecargas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listRecargas.CurrentRow != null)
            {
                var fila = listRecargas.CurrentRow;
                ListarRecargas recarga = (ListarRecargas)fila.DataBoundItem;
                recargaLocal = recarga;
                lbMonto.Text = "Q" + recarga.PrecioVenta;
                MontoRecarga = Convert.ToDecimal(recarga.PrecioVenta);
                if (recarga.Empresa == "TIGO")
                {
                    RbTigo.Checked = true;
                }
                else if (recarga.Empresa == "CLARO")
                {
                    RbClaro.Checked = true;
                }
            }
        }

        private void CheckSaldo_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            if (check.Checked)
            {
                ActivarDesactivarCheck(check);
                lbMonto.Text = check.Text;
            }
            else
            {
                DesactivarTodosCheck();
                lbMonto.Text = "Q0";
            }
            OcultarAgregarSaldo();

        }

        private void ActivarDesactivarCheck(CheckBox checkBox)
        {
            foreach (CheckBox check in checkBoxesSaldo)
            {
                if (check == checkBox)
                {
                    checkBox.Checked = true;
                    string[] values = check.Text.Split('Q');
                    MontoRecarga = Convert.ToDecimal(values[1]);
                }
                else
                {
                    check.Checked = false;
                }
            }
        }

        private void DesactivarTodosCheck()
        {
            foreach (CheckBox check in checkBoxesSaldo)
            {
                check.Checked = false;
            }
        }

        private void OcultarAgregarSaldo()
        {
            if (ChecksActivados())
            {
                CheckAgregarSaldo.Enabled = false;
            }
            else
            {
                CheckAgregarSaldo.Enabled = true;
            }
        }

        private void TxtNumeroTel_TextChanged(object sender, EventArgs e)
        {
            string numero = TxtNumeroTel.Text;
            if (TxtNumeroTel.Text.Length > 8)
            {
                TxtNumeroTel.Text = numero.Substring(0, 8);
                KryptonMessageBox.Show("Ha excedido el numero de digitos para el numero telefonico.", "Notificación");
            }
        }

        private void TxtMontoVariable_TextChanged(object sender, EventArgs e)
        {
            DesactivarTodosCheck();
            lbMonto.Text = "Q" + TxtMontoVariable.Text;
            MontoRecarga = Convert.ToInt32(TxtMontoVariable.Text);
        }

        private void AgregarASaldo()
        {
            try
            {
                if (ValidarCampos())
                {
                    SaldoRecarga nuevoSaldo = GetViewModel();
                    DetalleCaja detalleCaja = GetModelCaja();
                    if (ModelState.IsValid(nuevoSaldo) && ModelState.IsValid(detalleCaja))
                    {
                        _recargasRepository.AddSaldo(nuevoSaldo);
                        _cajasRepository.AddDetalleCaja(detalleCaja);
                        Close();
                    }                    
                }
            }
            catch
            {
                KryptonMessageBox.Show("Ha ocurrido un error interno al guardar la informmacion.", "ERROR");
            }
        }

        private bool ValidarCampos()
        {
            cajaObtenida = _cajasRepository.GetCajaAperturada(UsuarioLogeadoPOS.User.SucursalId);
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
            if (!string.IsNullOrEmpty(TxtMontoVariable.Text))
            {
                decimal compara = 0.00m;
                decimal preciov = Convert.ToDecimal(TxtMontoVariable.Text);

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

            nuevoSaldo.SucursalId = UsuarioLogeadoPOS.User.SucursalId;
            nuevoSaldo.Empresa = Empresa;
            if (Empresa == "TIGO")
            {
                nuevoSaldo.SaldoInicial = SaldoActualTigo;
            }
            else if (Empresa == "CLARO")
            {
                nuevoSaldo.SaldoInicial = SaldoActualClaro;
            }
            nuevoSaldo.Saldo = Convert.ToDecimal(TxtMontoVariable.Text);
            nuevoSaldo.SaldoActual = nuevoSaldo.SaldoInicial + nuevoSaldo.Saldo;
            nuevoSaldo.FechaTransferencia = DateTime.Now;
            return nuevoSaldo;
        }

        private DetalleCaja GetModelCaja()
        {
            return new DetalleCaja
            {
                CajaId = cajaObtenida.Id,
                Descripcion = "Compra de saldo " + Empresa,
                Egreso = Convert.ToDecimal(TxtMontoVariable.Text)
            };
        }

        private void CargarSaldos()
        {
            var historial = _recargasRepository.GetAllHistorial(UsuarioLogeadoPOS.User.SucursalId);
            if (historial.Count() > 0)
            {
                var htigo = historial.Where(x => x.Empresa == "TIGO");
                if (htigo.Count() > 0)
                {
                    SaldoActualTigo = htigo.LastOrDefault().SaldoActual;
                }
                var hclaro = historial.Where(x => x.Empresa == "CLARO");
                if (hclaro.Count() > 0)
                {
                    SaldoActualClaro = hclaro.LastOrDefault().SaldoActual;
                }
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (CheckAgregarSaldo.Checked)
            {
                AgregarASaldo();
            }
            else
            {
                AgregarAListadoVenta();
            }
        }

        private void AgregarAListadoVenta()
        {
            try
            {
                if (ValidarCamposVenta())
                {                    
                    if (ValidarSaldos(Empresa))
                    {
                        DetalleRecarga detalle = GetViewRecarga();
                        ListarDetalleFacturas detallefactura = GetViewModelVenta(detalle);
                        if (ModelState.IsValid(detalle))
                        {
                            _recargasRepository.AddDetalleRecarga(detalle);
                            var DetRecarga = _recargasRepository.GetLastDetalleRecarga();
                            detallefactura.DetalleRecargaId = DetRecarga.Id;
                            Principallocal._listaDetalleFacturas.Add(detallefactura);
                            Principallocal.cargarDGVDetalleFactura(Principallocal._listaDetalleFacturas);
                            Close();
                        }
                        else
                        {
                            KryptonMessageBox.Show("Datos inválidos en la informacion ingresada", "ERROR");
                        }
                    }
                    else
                    {
                        KryptonMessageBox.Show("No hay Saldo suficiente para realizar recargas.", "ERROR");
                    }
                }                              
            }
            catch
            {
                KryptonMessageBox.Show("Ha ocurrido un error interno al guardar la informmacion.", "ERROR");
            }
        }

        private bool ValidarSaldos(string empresa)
        {
            bool valida = false;
            if (empresa == "TIGO")
            {
                if (MontoRecarga > SaldoActualTigo)
                {
                    valida = false;
                }
                else 
                {
                    valida = true;
                }

            }
            else if (empresa == "CLARO")
            {
                if (MontoRecarga > SaldoActualClaro)
                {
                    valida = false;
                }
                else
                {
                    valida = true;
                }
            }
            return valida;            
        }

        private bool ValidarCamposVenta()
        {
            if (RbTigo.Checked == false && RbClaro.Checked == false)
            {
                KryptonMessageBox.Show("Debe seleccionar una Compañía", "Notificación");
                return false;
            }
            if (string.IsNullOrEmpty(TxtNumeroTel.Text) || (TxtNumeroTel.Text.Length < 8))
            {
                KryptonMessageBox.Show("No hay introducido un numero telefonico valido", "Notificación");
                return false;
            }
            else
            if (MontoRecarga <= 0.001m)
            {
                KryptonMessageBox.Show("Nay un monto valido registrado para la recarga", "Notificación");
                return false;
            }
            else if (!string.IsNullOrEmpty(TxtMontoVariable.Text) && !ChecksActivados() && recargaLocal == null)
            {
                decimal compara = 0.00m;
                decimal preciov = Convert.ToDecimal(TxtMontoVariable.Text);

                if (preciov <= compara)
                {
                    KryptonMessageBox.Show("Debe ingresar una cantidad válida en Monto Variable", "Notificación");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        private bool ChecksActivados()
        {
            var filter = checkBoxesSaldo.Where(a => a.Checked == true);
            if (filter.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private DetalleRecarga GetViewRecarga()
        {
            DetalleRecarga detalle;
            if (ChecksActivados())
            {
                detalle = new DetalleRecarga
                {
                    Empresa = Empresa,
                    Descripcion = "Recarga de Saldo Q" + MontoRecarga,
                    Numero = TxtNumeroTel.Text,
                    Monto = MontoRecarga,
                    Fecha = DateTime.Now,
                    Estado = false
                };
            }
            else if (recargaLocal.Id > 0)
            {
                detalle = new DetalleRecarga
                {
                    RecargaId = recargaLocal.Id,
                    Empresa = Empresa,
                    Descripcion = recargaLocal.Descripcion,
                    Numero = TxtNumeroTel.Text,
                    Monto = MontoRecarga,
                    Fecha = DateTime.Now,
                    Estado = false
                };
            }
            else
            {
                detalle = new DetalleRecarga
                {
                    Empresa = Empresa,
                    Descripcion = "Recarga de Saldo Q" + TxtMontoVariable.Text,
                    Numero = TxtNumeroTel.Text,
                    Monto = Convert.ToDecimal(TxtMontoVariable.Text),
                    Fecha = DateTime.Now,
                    Estado = false
                };
            }

            return detalle;
        }

        private ListarDetalleFacturas GetViewModelVenta(DetalleRecarga detalleRecarga)
        {
            ListarDetalleFacturas detalleFacturas = new ListarDetalleFacturas
            {
                Descripcion = detalleRecarga.Descripcion,
                Cantidad = 1,
                Precio = detalleRecarga.Monto,
                SubTotal = detalleRecarga.Monto * 1,
                PrecioTotal = detalleRecarga.Monto * 1,
                EsRecarga = true,
                Empresa = detalleRecarga.Empresa                
            }; 
          
            return detalleFacturas;
        }

        private void CheckAgregarSaldo_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckAgregarSaldo.Checked)
            {
                groupSaldo.Enabled = false;
                TxtNumeroTel.Enabled = false;
                listRecargas.Enabled = false;
                toolRecargas.Enabled = false;
            }
            else
            {
                groupSaldo.Enabled = true;
                TxtNumeroTel.Enabled = true;
                listRecargas.Enabled = true;
                toolRecargas.Enabled = true;
            }
        }
    }
}
