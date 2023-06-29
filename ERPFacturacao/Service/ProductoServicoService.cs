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
    public class ProductoServicoService : IRepository<ProductoServico>
    {
        private readonly EFContext _context;

        public ProductoServicoService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductoServico> findAll()
        {
            return _context.ProductoServico.ToList();
        }

        public ProductoServico findById(int? id)
        {
            throw new NotImplementedException();
        }

        public void insert(ProductoServico obj)
        {
            _context.Add(obj);  
            _context.SaveChanges();
        }

        public void update(ProductoServico obj)
        {
            throw new NotImplementedException();
        }
    }
}
