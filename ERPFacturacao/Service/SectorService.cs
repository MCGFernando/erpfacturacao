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
    public class SectorService : IRepository<Sector>
    {
        private readonly EFContext _context;

        public SectorService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Sector> findAll()
        {
            return _context.Sector.ToList();
        }

        public Sector findById(int? id)
        {
            throw new NotImplementedException();
        }

        public void insert(Sector obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(Sector obj)
        {
            throw new NotImplementedException();
        }
    }
}
