using ERPFacturacao.Data;
using ERPFacturacao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Service.impl
{
    public class TipoProductoServicoService : IRepository<TipoArtigo>
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

        public List<TipoArtigo> findAll()
        {
            return _context.TipoArtigo.ToList();
        }

        public TipoArtigo findById(int? id)
        {
            throw new NotImplementedException();
        }

        public void insert(TipoArtigo obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(TipoArtigo obj)
        {
            throw new NotImplementedException();
        }
    }
}
