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
    public class CargoService : IRepository<Cargo>
    {
        private readonly EFContext _context;

        public CargoService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cargo> findAll()
        {
            return _context.Cargo.ToList();
        }

        public Cargo findById(int? id)
        {
            return _context.Cargo.FirstOrDefault(c => c.Id == id.Value);   
        }

        public void insert(Cargo obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(Cargo obj)
        {
            throw new NotImplementedException();
        }
    }
}
