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
    public class TipoIVAService : IRepository<TipoIVA>
    {
        private readonly EFContext _context;

        public TipoIVAService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TipoIVA> findAll()
        {
            return _context.TipoIVA.ToList();
        }

        public TipoIVA findById(int? id)
        {
            throw new NotImplementedException();
        }

        public void insert(TipoIVA obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(TipoIVA obj)
        {
            throw new NotImplementedException();
        }
    }
}
