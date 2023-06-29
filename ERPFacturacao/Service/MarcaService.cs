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
    public class MarcaService : IRepository<Marca>
    {
        private readonly EFContext _context;

        public MarcaService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Marca> findAll()
        {
            return _context.Marca.ToList();
        }

        public Marca findById(int? id)
        {
            throw new NotImplementedException();
        }

        public void insert(Marca obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(Marca obj)
        {
            throw new NotImplementedException();
        }
    }
}
