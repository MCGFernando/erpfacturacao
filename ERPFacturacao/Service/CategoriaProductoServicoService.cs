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
    public class CategoriaProductoServicoService : IRepository<CategoriaProductoServico>
    {
        private readonly EFContext _context;

        public CategoriaProductoServicoService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoriaProductoServico> findAll()
        {
            return _context.CategoriaProductoServico.ToList();
        }

        public CategoriaProductoServico findById(int? id)
        {
            throw new NotImplementedException();
        }

        public void insert(CategoriaProductoServico obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(CategoriaProductoServico obj)
        {
            throw new NotImplementedException();
        }
    }
}
