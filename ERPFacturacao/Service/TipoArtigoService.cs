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
    public class TipoArtigoService : IRepository<TipoArtigo>
    {
        private readonly EFContext _context;

        public TipoArtigoService(EFContext context)
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
            if (id == null || id.Value <= 0)
            {
                throw new ArgumentException("Invalid or missing ID parameter.");
            }

            TipoArtigo result = null;

            try
            {
                result = _context.TipoArtigo.FirstOrDefault(m => m.Id == id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while fetching the data from the database.", ex);
            }

            return result;
        }

        public void insert(TipoArtigo obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(TipoArtigo obj)
        {
            var objOld = findById(obj.Id);
            _context.Entry(objOld).CurrentValues.SetValues(obj);
        }
    }
}
