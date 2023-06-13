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
    public class MoedaService : IRepository<Moeda>
    {
        private readonly EFContext _context;

        public MoedaService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Moeda> findAll()
        {
            return _context.Moeda.ToList();
        }

        public Moeda findById(int? id)
        {
            throw new NotImplementedException();
        }

        public void insert(Moeda obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(Moeda obj)
        {
            throw new NotImplementedException();
        }
    }
}
