using CapaDatos.Data;
using CapaDatos.ListasPersonalizadas;
using CapaDatos.Models.Productos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos.Repository
{
    public class RecargasRepository
    {
        private Context _context = null;

        public RecargasRepository(Context context)
        {
            _context = context;
        }

        public void Add(Recarga Recarga, bool saveChanges = true)
        {
            _context.Recargas.Add(Recarga);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public void Update(Recarga Recarga, bool saveChanges = true)
        {
            _context.Entry(Recarga).State = System.Data.Entity.EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public Recarga Get(int id)
        {
            return _context.Recargas.Where(x => x.Id == id).FirstOrDefault();
        }

        public SaldoRecarga GetSaldo(int id)
        {
            return _context.SaldoRecargas.Where(x => x.Id == id).FirstOrDefault();
        }

        public void AddDetalleRecarga(DetalleRecarga Recarga, bool saveChanges = true)
        {
            _context.DetalleRecargas.Add(Recarga);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public void UpdateDetalleRecarga(DetalleRecarga detRecarga, bool saveChanges = true)
        {
            _context.Entry(detRecarga).State = System.Data.Entity.EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public List<DetalleRecarga> GetAllDetalles(DetalleRecarga detRecarga)
        {
            return _context.DetalleRecargas.ToList();
        }

        public DetalleRecarga GetDetalleRecarga(int Id)
        {
            return _context.DetalleRecargas.Where(x => x.Id == Id).FirstOrDefault();
        }

        public List<ListarRecargas> GetListarRecargas(int idSucursal)
        {
            return _context.Recargas
              .Where(a => a.Deleted == false && a.SucursalId == idSucursal)
              .OrderBy(a => a.Id).ThenByDescending(a => a.Id)
              .Select(x => new ListarRecargas
              {
                  Id = x.Id,
                  CategoriaId = x.CategoriaId,
                  Categoria = x.Categoria.Nombre,
                  SucursalId = x.SucursalId,
                  Sucursal = x.Sucursal.NombreSucursal,
                  ProveedorId = x.ProveedorId,
                  Proveedor =  x.Proveedor.Nombre, 
                  Empresa = x.Empresa,
                  Tipo = x.Tipo,
                  CodigoBarras = x.CodigoBarras,
                  Descripcion = x.Descripcion,
                  DescripcionCorta = x.DescripcionCorta,
                  Vigencia = x.Vigencia,                  
                  PrecioVenta = x.PrecioVenta,
                  Deleted = x.Deleted,
              })
              .OrderBy(a => a.Descripcion)
              .ToList();
        }

        public List<ListarHistorialRecargas> GetListarHistorial(int idSucursal)
        {
            return _context.SaldoRecargas
              .Where(a => a.SucursalId == idSucursal)
              .Select(x => new ListarHistorialRecargas
              {
                  Id = x.Id,
                  SucursalId = x.SucursalId,
                  Sucursal = x.Sucursal.NombreSucursal,
                  Empresa = x.Empresa,
                  SaldoInicial = x.SaldoInicial,
                  Saldo = x.Saldo,
                  SaldoActual = x.SaldoActual,
                  FechaTransferencia = x.FechaTransferencia
              })
              .ToList();
        }

        public void AddSaldo(SaldoRecarga saldo, bool saveChanges = true)
        {
            _context.SaldoRecargas.Add(saldo);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public void UpdateSaldo(SaldoRecarga saldo, bool saveChanges = true)
        {
            _context.Entry(saldo).State = System.Data.Entity.EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public void DeleteSaldo(SaldoRecarga saldo, bool saveChanges = true)
        {
            _context.Entry(saldo).State = System.Data.Entity.EntityState.Deleted;

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public List<SaldoRecarga> GetAllHistorial(int Sucursal)
        {
            return _context.SaldoRecargas.Where(x => x.SucursalId == Sucursal).ToList();
        }

        public SaldoRecarga LastSaldoRecarga(int sucursal, string empresa)
        {
            SaldoRecarga lastsaldo = null;
            var Saldos = _context.SaldoRecargas.Where(x => x.SucursalId == sucursal).ToList();
            if (Saldos.Count() > 0)
            {
                var filtro = Saldos.Where(x => x.Empresa == empresa);
                if (filtro.Count() > 0)
                {
                    lastsaldo = filtro.LastOrDefault();
                }
            }
            return lastsaldo;
        }

        public DetalleRecarga GetLastDetalleRecarga()
        {
            return _context.DetalleRecargas.ToList().LastOrDefault();
        }

    }
}
