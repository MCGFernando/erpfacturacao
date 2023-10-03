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
    public class MunicipioService : IRepository<Municipio>
    {
        private readonly EFContext _context;

        public MunicipioService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Municipio> findAll()
        {
            return _context.Municipio.ToList();
        }

        public Municipio findById(int? id)
        {
            if (id == null || id.Value <= 0)
            {
                throw new ArgumentException("Invalid or missing ID parameter.");
            }

            Municipio result = null;

            try
            {
                result = _context.Municipio.FirstOrDefault(m => m.Id == id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while fetching the data from the database.", ex);
            }

            return result;
        }
        public List<Municipio> findByProvinciaId(int? id)
        {
            return _context.Municipio.Where(m => m.ProvinciaId == id).ToList();  
        }

        public void insert(Municipio obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(Municipio obj)
        {
            var objOld = findById(obj.Id);
            _context.Entry(objOld).CurrentValues.SetValues(obj);
        }
    }
}
