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
    public class ContaContabilAgregadoraService : IRepository<ContaContabilAgregadora>
    {
        private readonly EFContext _context;

        public ContaContabilAgregadoraService(EFContext context)
        {
            _context = context;
        }
        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContaContabilAgregadora> findAll()
        {
            return _context.ContaContabilAgregadora.ToList();
        }

        public ContaContabilAgregadora findById(int? id)
        {
            if (id == null || id.Value <= 0)
            {
                throw new ArgumentException("Invalid or missing ID parameter.");
            }

            ContaContabilAgregadora result = null;

            try
            {
                result = _context.ContaContabilAgregadora.FirstOrDefault(m => m.Id == id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while fetching the data from the database.", ex);
            }

            return result;
        }

        public void insert(ContaContabilAgregadora obj)
        {
            _context.ContaContabilAgregadora.Add(obj);
            _context.SaveChanges();
        }

        public void update(ContaContabilAgregadora obj)
        {
            var objOld = findById(obj.Id);
            _context.Entry(objOld).CurrentValues.SetValues(obj);
        }
    }
}
