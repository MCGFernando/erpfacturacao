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
    public class TipoContactoService : IRepository<TipoContacto>
    {
        private readonly EFContext _context;

        public TipoContactoService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TipoContacto> findAll()
        {
            return _context.TipoContacto.ToList();
        }

        public TipoContacto findById(int? id)
        {
            throw new NotImplementedException();
        }

        public void insert(TipoContacto obj)
        {
            _context.Add(obj);  
            _context.SaveChanges();
        }

        public void update(TipoContacto obj)
        {
            throw new NotImplementedException();
        }
    }
}
