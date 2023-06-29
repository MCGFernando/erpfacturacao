using ERPFacturacao.Data;
using ERPFacturacao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Service.impl
{
    public class TipoProductoServicoService : IRepository<TipoProductoServico>
    {
        private readonly EFContext _context;

        public TipoProductoServicoService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TipoProductoServico> findAll()
        {
            return _context.TipoProductoServico.ToList();
        }

        public TipoProductoServico findById(int? id)
        {
            throw new NotImplementedException();
        }

        public void insert(TipoProductoServico obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(TipoProductoServico obj)
        {
            throw new NotImplementedException();
        }
    }
}
