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
    public class ClasseContabilService : IRepository<ClasseContabil>
    {
        private readonly EFContext _context;

        public ClasseContabilService(EFContext context)
        {
            _context = context;
        }
        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ClasseContabil> findAll()
        {
            return _context.ClasseContabil.ToList();
        }

        public ClasseContabil findById(int? id)
        {
            if (id == null || id.Value <= 0)
            {
                throw new ArgumentException("Invalid or missing ID parameter.");
            }

            ClasseContabil result = null;

            try
            {
                result = _context.ClasseContabil.FirstOrDefault(m => m.Id == id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while fetching the data from the database.", ex);
            }

            return result;
        }

        public void insert(ClasseContabil obj)
        {
            throw new NotImplementedException();
        }

        public void update(ClasseContabil obj)
        {
            throw new NotImplementedException();
        }
    }
}
