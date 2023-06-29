using ERPFacturacao.Data;
using ERPFacturacao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Service.impl
{
    public class UnidadeService : IRepository<Unidade>
    {
        private readonly EFContext _context;

        public UnidadeService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Unidade> findAll()
        {
            return _context.Unidade.ToList();
        }

        public Unidade findById(int? id)
        {
            throw new NotImplementedException();
        }

        public void insert(Unidade obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(Unidade obj)
        {
            throw new NotImplementedException();
        }
    }
}
