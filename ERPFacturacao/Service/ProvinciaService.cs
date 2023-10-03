using ERPFacturacao.Data;
using ERPFacturacao.Model;
using ERPFacturacao.Service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Service
{
    public class ProvinciaService : IRepository<Provincia>
    {
        private readonly EFContext _context;

        public ProvinciaService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Provincia> findAll()
        {
            return _context.Provincia.ToList();
        }

        public Provincia findById(int? id)
        {
            if (id == null || id.Value <= 0)
            {
                throw new ArgumentException("Invalid or missing ID parameter.");
            }

            Provincia result = null;

            try
            {
                result = _context.Provincia.FirstOrDefault(m => m.Id == id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while fetching the data from the database.", ex);
            }

            return result;
        }
        public List<Provincia> findByPaisId(int? id)
        {
            return _context.Provincia.Where(p => p.PaisId == id).ToList();  
        }

        public void insert(Provincia obj)
        {
            _context.Add(obj);
            _context.SaveChanges(); 
        }

        public void update(Provincia obj)
        {
            var objOld = findById(obj.Id);
            _context.Entry(objOld).CurrentValues.SetValues(obj);
        }
    }
}
