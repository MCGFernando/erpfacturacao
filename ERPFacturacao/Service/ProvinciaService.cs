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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
