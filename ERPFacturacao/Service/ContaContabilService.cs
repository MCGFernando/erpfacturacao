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
            findById(id);
            throw new NotImplementedException();
        }

        public List<ContaContabil> findAll()
        {
            return _context.ContaContabil.ToList();
        }

        public ContaContabil findById(int? id)
        {
            if (id == null || id.Value <= 0)
            {
                throw new ArgumentException("Invalid or missing ID parameter.");
            }

            ContaContabil result = null;

            try
            {
                result = _context.ContaContabil.FirstOrDefault(m => m.Id == id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while fetching the data from the database.", ex);
            }

            return result;
        }

        public ContaContabil findByCodigo(string? codigo)
        {
            throw new NotImplementedException();
        }

        public void insert(ContaContabil obj)
        {
            _context.ContaContabil.Add(obj);
            _context.SaveChanges();
        }

        public void update(ContaContabil obj)
        {
            _context.ContaContabil.Add(obj);
            _context.SaveChanges();
        }
    }
}
