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
    public class ContaBancariaService : IRepository<ContaBancaria>
    {
        private readonly EFContext _context;

        public ContaBancariaService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContaBancaria> findAll()
        {
            return _context.ContaBancaria.ToList();
        }

        public ContaBancaria findById(int? id)
        {
            throw new NotImplementedException();
        }

        public void insert(ContaBancaria obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(ContaBancaria obj)
        {
            throw new NotImplementedException();
        }
    }
}
