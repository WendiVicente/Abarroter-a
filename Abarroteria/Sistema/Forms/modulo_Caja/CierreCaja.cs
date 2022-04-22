using CapaDatos.Repository;
using CapaDatos.Repository.SolicitudestoFacturar;
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

namespace Sistema.Forms.modulo_Caja
{
    public partial class CierreCaja : BaseContext
    {
        private CajaInicio _cajaIniciofrm = null;
        private CajasRepository _cajasRepository = null;
        private DetalleMonetarioRepository _detalleMonetarioRepository = null;
        private Caja _cajaToclose = null;

        // variables
        decimal totalVentasAcom;
        public CierreCaja(CajaInicio cajaInicio, Caja cajaactiva)
        {
            _cajaIniciofrm = cajaInicio;
            _cajaToclose = cajaactiva;
            _cajasRepository = new CajasRepository(_context);
            _detalleMonetarioRepository = new DetalleMonetarioRepository(_context);


            InitializeComponent();
            CargarValores();
        }

        private void txtquin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtdosc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtcien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtcincuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtveinte_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtdiez_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtcinco_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtmquetzal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtmcincuentac_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtmveinte_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtmdiez_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtmcinco_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtmcentavo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtquin_TextChanged(object sender, EventArgs e)
        {
            

            if (!string.IsNullOrEmpty(txtquin.Text))
            {
                var cantidad = int.Parse(txtquin.Text);
                lb500.Text = OperacionMulti(500, cantidad).ToString("0.00");
            }
            else
            {
                lb500.Text = "0.00";

            }
            operacionSuma();

        }

        private void txtdosc_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtdosc.Text))
            {
                var cantidad = int.Parse(txtdosc.Text);
                lb200.Text = OperacionMulti(200, cantidad).ToString("0.00");
            }
            else
            {
                lb200.Text = "0.00";

            }
            operacionSuma();
        }

        private void txtcien_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcien.Text))
            {
                var cantidad = int.Parse(txtcien.Text);
                lb100.Text = OperacionMulti(100, cantidad).ToString("0.00");

            }
            else
            {
                lb100.Text = "0.00";

            }
            operacionSuma();
        }

        private void txtcincuenta_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcincuenta.Text))
            {
                var cantidad = int.Parse(txtcincuenta.Text);
                lb50.Text = OperacionMulti(50, cantidad).ToString("0.00");
            }
            else
            {
                lb50.Text = "0.00";

            }
            operacionSuma();
        }

        private void txtveinte_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtveinte.Text))
            {
                var cantidad = int.Parse(txtveinte.Text);
                lb20.Text = OperacionMulti(20, cantidad).ToString("0.00");
            }
            else
            {
                lb20.Text = "0.00";

            }
            operacionSuma();

        }

        private void txtdiez_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtdiez.Text))
            {
                var cantidad = int.Parse(txtdiez.Text);
                lb10.Text = OperacionMulti(10, cantidad).ToString("0.00");
            }
            else
            {
                lb10.Text = "0.00";

            }
            operacionSuma();
        }

        private void txtcinco_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcinco.Text))
            {
                var cantidad = int.Parse(txtcinco.Text);
                lb5.Text = OperacionMulti(5, cantidad).ToString("00.00");
            }
            else
            {
                lb5.Text = "0.00";

            }
            operacionSuma();
        }

        private void txtmquetzal_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmquetzal.Text))
            {
                var cantidad = int.Parse(txtmquetzal.Text);
                lb1.Text = OperacionMulti(1M, cantidad).ToString("00.00");
            }
            else
            {
                lb1.Text = "0.00";

            }

            operacionSuma();
        }

        private void txtmcincuentac_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmcincuentac.Text))
            {
                var cantidad = int.Parse(txtmcincuentac.Text);
                lb050.Text = OperacionMulti(0.50M, cantidad).ToString("00.00");
            }
            else
            {
                lb050.Text = "0.00";

            }
            operacionSuma();
        }

        private void txtmveinte_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmveinte.Text))
            {
                var cantidad = int.Parse(txtmveinte.Text);
                lb020.Text = OperacionMulti(0.25M, cantidad).ToString("00.00");
            }
            else
            {
                lb020.Text = "0.00";

            }
            operacionSuma();
        }

        private void txtmdiez_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmdiez.Text))
            {
                var cantidad = int.Parse(txtmdiez.Text);
                lb010.Text = OperacionMulti(0.10M, cantidad).ToString("00.00");
            }
            else
            {
                lb010.Text = "0.00";

            }
            operacionSuma();
        }

        private void txtmcinco_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmcinco.Text))
            {
                var cantidad = int.Parse(txtmcinco.Text);
                lb005.Text = OperacionMulti(0.05M, cantidad).ToString("00.00");
            }
            else
            {
                lb005.Text = "0.00";
            }
            operacionSuma();
        }

        private void txtmcentavo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmcentavo.Text))
            {
                var cantidad = int.Parse(txtmcentavo.Text);
                lb001.Text = OperacionMulti(0.01M, cantidad).ToString("00.00");
            }
            else
            {
                lb001.Text = "0.00";

            }
            operacionSuma();
        }

        private decimal OperacionMulti(decimal valor1, int cantidad)
        {


            return  valor1 * cantidad;

        }
        decimal totalToshow;
        private void operacionSuma()
        {
            //menor a mayor
           
            decimal lbv1 = decimal.Parse(lb001.Text);
            decimal lbv2 = decimal.Parse(lb005.Text);
            decimal lbv3 = decimal.Parse(lb010.Text);
            decimal lbv4 = decimal.Parse(lb020.Text);
            decimal lbv5 = decimal.Parse(lb050.Text);
            decimal lbv6 = decimal.Parse(lb1.Text);
            decimal lbv7 = decimal.Parse(lb5.Text);
            decimal lbv8 = decimal.Parse(lb10.Text);
            decimal lbv9 = decimal.Parse(lb20.Text);
            decimal lbv10 = decimal.Parse(lb50.Text);
            decimal lbv11 = decimal.Parse(lb100.Text);
            decimal lbv12 = decimal.Parse(lb200.Text);
            decimal lbv13 = decimal.Parse(lb500.Text);

            decimal lbv14 = decimal.Parse(txtcheque.Text);
            decimal lbv15 = decimal.Parse(txttcredito.Text);
            decimal lbv16 = decimal.Parse(txttdebito.Text);
            decimal lbv17 = decimal.Parse(txttransfer.Text);

            totalToshow = lbv1 + lbv2 + lbv3 + lbv4 + lbv5 + lbv6 + lbv7 + lbv8 + lbv9 + lbv10 + lbv11 + lbv12 + lbv13 + lbv14
                + lbv15 + lbv16 + lbv17 + _cajaToclose.MontoApertura;
            lbtotal.Text = totalToshow.ToString("Q."+"0.0");
            lbResumenTotal.Text = lbtotal.Text;
            operacionesBasic();
            lbtotalCuadre.Text = operacionesBasic().ToString("Q." + "0.00");
        }

        private void txtcheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as KryptonTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;

            }
        }

        private void txttcredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as KryptonTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;

            }
        }

        private void txttdebito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as KryptonTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;

            }

        }

        private void txttransfer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as KryptonTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;

            }
        }

        private void txtcheque_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcheque.Text))
            {

                operacionSuma();

            }
           
        }

        private void txttcredito_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttcredito.Text))
            {

                operacionSuma();

            }
          

        }

        private void txttdebito_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttdebito.Text))
            {

                operacionSuma();

            }
          

        }

        private void txttransfer_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttransfer.Text))
            {

                operacionSuma();

            }
            

        }

        private void txtcheque_Click(object sender, EventArgs e)
        {
            txtcheque.Text="";
        }

        private void txtcheque_EnabledChanged(object sender, EventArgs e)
        {
            txtcheque.Text = "";
        }
        private Caja GetViewModel(Caja caja)
        {
            caja.FechaCierre = DateTime.Now;
            caja.EstadoCaja = false;
            return caja;
        }
        public void CerrarCaja()
        {

            var cerrarCaja = GetViewModel(_cajaToclose);
            if (!ModelState.IsValid(cerrarCaja)) { return; }//validacion del modelo state

           
            if (operacionesBasic() > 0)
            {
                KryptonMessageBox.Show("EL CIERRE DE CAJA NO CUADRA, POR FAVOR VALIDAR");
                return;
            }
            else
            if (operacionesBasic() < 0)
            {
                KryptonMessageBox.Show("EL CIERRE DE CAJA NO CUADRA, POR FAVOR VALIDAR INGRESOS");
                return;
            }
            else if (operacionesBasic() == 0)
                    {
                _cajasRepository.Update(cerrarCaja);
                guardarDesgloseCaja();
                _cajaIniciofrm.RefrescardgCajaActiva(true);
                _cajaIniciofrm.dgvDetalleCajaActiva.DataSource = null;
                KryptonMessageBox.Show("EL CIERRE  CUADRADO, OPERACION EXITOSA");
            }

        }

        public decimal operacionesBasic()
        {
            decimal operacionReciduo = totalVentasAcom - totalToshow;
            return operacionReciduo;
        }


       
        private void CargarValores()
        {
            try
            {
                var obtenerDetalle = _cajasRepository.GetDetalleCaja(_cajaToclose.Id);
                //operaciones con las columnas y Labels
                var egresos = obtenerDetalle.Sum(a => a.Egreso);
                var efectivototal = obtenerDetalle.Sum(a => a.Efectivo);
                var chequestotal = obtenerDetalle.Sum(a => a.Cheques);
                var tarjetaDebitototal = obtenerDetalle.Sum(a => a.TarjetaDebito);
                var tarjetaCreditototal = obtenerDetalle.Sum(a => a.TarjetaCredito);
                var transferencias = obtenerDetalle.Sum(a => a.Transferencias);
                var ingresos = (efectivototal + chequestotal + tarjetaCreditototal + tarjetaDebitototal);
                txtmontoinitdes.Text = _cajaToclose.MontoApertura.ToString("Q." + "0.00");
                lbRcheque.Text = chequestotal<1? "Q.0.00": chequestotal.ToString("Q." + "0.00");
                lbRefectivo.Text = efectivototal.ToString("Q." + "0.00");
                lbRtcredito.Text = tarjetaCreditototal.ToString("Q." + "0.00");
                lbRtdebito.Text = tarjetaDebitototal.ToString("Q." + "0.00");
                lbRegresos.Text = egresos.ToString("Q." + "0.00");
                 totalVentasAcom = ingresos - egresos;
                lbtotalVentasAcom.Text = totalVentasAcom.ToString("Q." + "0.00");

                // lbtotalcerrar.Text = (ingresos - egresos).ToString();
                // lbtotalinicio.Text = obtenercodcajaActiva.MontoApertura.ToString();

            }
            catch (Exception ex)
            {

                KryptonMessageBox.Show(ex.Message);
            }
          

        }
        private DetalleMonetario getModel()
        {
            var detallem = new DetalleMonetario()
            {
                CajaId = _cajaToclose.Id,

            };
            return detallem;
        }

        private List<DetalleMonetario> getdetalleMonetarios()
        {
            ValidarCampos();
            var lista = new List<DetalleMonetario>();
            var m9 = new DetalleMonetario();
            var m1 = new DetalleMonetario() { CajaId = _cajaToclose.Id, Cantidad = int.Parse(txtquin.Text), Moneda = 500, };
            var m2 = new DetalleMonetario() { CajaId = _cajaToclose.Id, Cantidad = int.Parse(txtdosc.Text), Moneda = 200, };
            var m3 = new DetalleMonetario() { CajaId = _cajaToclose.Id, Cantidad = int.Parse(txtcien.Text), Moneda = 100, };
            var m4 = new DetalleMonetario() { CajaId = _cajaToclose.Id, Cantidad = int.Parse(txtcincuenta.Text), Moneda = 50, };
            var m5 = new DetalleMonetario() { CajaId = _cajaToclose.Id, Cantidad = int.Parse(txtveinte.Text), Moneda = 20, };
            var m6 = new DetalleMonetario() { CajaId = _cajaToclose.Id, Cantidad = int.Parse(txtdiez.Text), Moneda = 10, };
            var m7 = new DetalleMonetario() { CajaId = _cajaToclose.Id, Cantidad = int.Parse(txtcinco.Text), Moneda = 5, };
            var m8 = new DetalleMonetario() { CajaId = _cajaToclose.Id, Cantidad = int.Parse(txtmquetzal.Text), Moneda = 1, };
            if (txtmcincuentac.Text.Length > 0)
            {
                m9 = new DetalleMonetario() { CajaId = _cajaToclose.Id, Cantidad = int.Parse(txtmcincuentac.Text), Moneda = 0.5m, };
            }
            var m10 = new DetalleMonetario() { CajaId = _cajaToclose.Id, Cantidad = int.Parse(txtmveinte.Text), Moneda = 0.2M, };
            var m11 = new DetalleMonetario() { CajaId = _cajaToclose.Id, Cantidad = int.Parse(txtmdiez.Text), Moneda = 0.1M, };
            var m12 = new DetalleMonetario() { CajaId = _cajaToclose.Id, Cantidad = int.Parse(txtmcinco.Text), Moneda = 0.05M, };
            var m13 = new DetalleMonetario() { CajaId = _cajaToclose.Id, Cantidad = int.Parse(txtmcentavo.Text), Moneda = 0.01M, };
            //var m14 = new DetalleMonetario() { CajaId = _cajaToclose.Id, Cantidad = int.Parse(txtcheque.Text), Moneda = 500, };
            //var m12 = new DetalleMonetario() { CajaId = _cajaToclose.Id, Cantidad = int.Parse(txtmcinco.Text), Moneda = 500, };
            //var m12 = new DetalleMonetario() { CajaId = _cajaToclose.Id, Cantidad = int.Parse(txtmcinco.Text), Moneda = 500, };
            lista.Add(m1);
            lista.Add(m2);
            lista.Add(m3);
            lista.Add(m4);
            lista.Add(m5);
            lista.Add(m6);
            lista.Add(m7);
            lista.Add(m8);
            lista.Add(m9);
            lista.Add(m10);
            lista.Add(m11);
            lista.Add(m12);
            lista.Add(m13);
            return lista;
        }


        private void guardarDesgloseCaja()
        {
            var listadetalle = getdetalleMonetarios();
            foreach (var item in listadetalle)
            {
                _detalleMonetarioRepository.Add(item);
            }


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarCaja();
        }

        private void lbRefectivo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CierreCaja_Load(object sender, EventArgs e)
        {

        }

        private void ValidarCampos()
        {
            if (txtquin.Text == "")
                txtquin.Text = "0";            
            if (txtdosc.Text == "")
                txtdosc.Text = "0";           
            if (txtcien.Text == "")
                txtcien.Text = "0";            
            if (txtcincuenta.Text == "")
                txtcincuenta.Text = "0";            
            if (txtveinte.Text == "")
                txtveinte.Text = "0";            
            if (txtdiez.Text == "")
                txtdiez.Text = "0";            
            if (txtcinco.Text == "")
                txtcinco.Text = "0";            
            if (txtmquetzal.Text == "")
                txtmquetzal.Text = "0";
            if (txtmveinte.Text == "")
                txtmveinte.Text = "0";
            if (txtmdiez.Text == "")
                txtmdiez.Text = "0";
            if (txtmcinco.Text == "")
                txtmcinco.Text = "0";
            if (txtmcentavo.Text == "")
                txtmcentavo.Text = "0";
        }
    }
}
