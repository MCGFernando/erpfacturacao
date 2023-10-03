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
    public class TipoEnderecoService : IRepository<TipoEndereco>
    {
        private readonly EFContext _context;

        public TipoEnderecoService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TipoEndereco> findAll()
        {
            return _context.TipoEndereco.ToList();
        }

        public TipoEndereco findById(int? id)
        {
            if (id == null || id.Value <= 0)
            {
                throw new ArgumentException("Invalid or missing ID parameter.");
            }

            TipoEndereco result = null;

            try
            {
                result = _context.TipoEndereco.FirstOrDefault(m => m.Id == id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while fetching the data from the database.", ex);
            }

            return result;
        }

        public void insert(TipoEndereco obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(TipoEndereco obj)
        {
            var objOld = findById(obj.Id);
            _context.Entry(objOld).CurrentValues.SetValues(obj);
        }
    }
}
