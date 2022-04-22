using CapaDatos.Models.Sucursales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models.Productos
{
    public class SaldoRecarga
    {
        public int Id { get; set; }
        public int SucursalId { get; set; }
        public string Empresa { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal Saldo { get; set; }
        public decimal SaldoActual { get; set; }
        public DateTime FechaTransferencia { get; set; }
        public Sucursal Sucursal { get; set; }
    }
}
