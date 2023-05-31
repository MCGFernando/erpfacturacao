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
    public class PaisService : IRepository<Pais>
    {
        private readonly EFContext _context;

        public PaisService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pais> findAll()
        {
            return _context.Pais.ToList();
        }

        public Pais findById(int? id)
        {
            throw new NotImplementedException();
        }

        public void insert(Pais obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(Pais obj)
        {
            throw new NotImplementedException();
        }
    }
}
