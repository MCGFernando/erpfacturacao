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
    public class ModeloService : IRepository<Modelo>
    {
        private readonly EFContext _context;

        public ModeloService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Modelo> findAll()
        {
            return _context.Modelo.ToList();
        }

        public Modelo findById(int? id)
        {
            throw new NotImplementedException();
        }

        public void insert(Modelo obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(Modelo obj)
        {
            throw new NotImplementedException();
        }
    }
}
