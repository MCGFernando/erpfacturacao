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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
