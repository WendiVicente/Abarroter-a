using CapaDatos.Data;
using CapaDatos.ListasPersonalizadas;
using CapaDatos.Models.Bancos;
using CapaDatos.Models.Productos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CapaDatos.Repository
{
    public class DetalleEstiloRepository
    {
        private Context _context = null;

        public DetalleEstiloRepository(Context context)
        {
            _context = context;
        }

        public void Add(DetalleEstilo detalleEstilo, bool saveChanges = true)
        {
            _context.DetalleEstilos.Add(detalleEstilo);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public void Update(DetalleEstilo detalleEstilo, bool saveChanges = true)
        {
            _context.Entry(detalleEstilo).State = EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }
        
        public DetalleEstilo GetDetalleEstilo(int id)
        {
            return _context.DetalleEstilos
                .Where(r => r.Id == id)
                .OrderBy(h => h.Estilo)
                .FirstOrDefault();
        }

        public void DeleteDetalleEstilo(DetalleEstilo detalleEstilo)
        {
            _context.Entry(detalleEstilo).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public List<DetalleEstilo> GetAllEstilos()
        {
            return _context.DetalleEstilos.ToList();
        }

        public List<DetalleEstilo> GetProductoListaEstilo(int codigoproducto)
        {
            return _context.DetalleEstilos
                .Where(r => r.ProductoId == codigoproducto)
                .OrderBy(h => h.Estilo)
                .ToList();
        }
    }
}
