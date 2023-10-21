using ERPFacturacao.Data;
using ERPFacturacao.Model;
using ERPFacturacao.Service.impl;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Service
{
    public class ModeloService : IRepository<Modelo>
    {
        private readonly EFContext _context;

        public ModeloService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            findById(id);
            throw new NotImplementedException();
        }

        public List<Modelo> findAll()
        {
            return _context.Modelo.ToList();
        }

        public Modelo findById(int? id)
        {
            if (id == null || id.Value <= 0)
            {
                throw new ArgumentException("Invalid or missing ID parameter.");
            }

            Modelo result = null;

            try
            {
                result = _context.Modelo.FirstOrDefault(m => m.Id == id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while fetching the data from the database.", ex);
            }

            return result;
    }

        public void insert(Modelo obj)
        {
            _context.Modelo.Add(obj);
            _context.SaveChanges();
        }

        public void update(Modelo obj)
        {
             _context.Modelo.Add(obj);
            _context.SaveChanges();
        }
    }
}
