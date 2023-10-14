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
    public class ContaContabilService : IRepository<ContaContabil>
    {
        private readonly EFContext _context;

        public ContaContabilService(EFContext context)
        {
            _context = context;
        }
        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContaContabil> findAll()
        {
            throw new NotImplementedException();
        }

        public ContaContabil findById(int? id)
        {
            throw new NotImplementedException();
        }

        public void insert(ContaContabil obj)
        {
            throw new NotImplementedException();
        }

        public void update(ContaContabil obj)
        {
            throw new NotImplementedException();
        }
    }
}
