using ERPFacturacao.Data;
using ERPFacturacao.Model;
using ERPFacturacao.Service.impl;

namespace ERPFacturacao.Service
{
    public class FornecedorService : IRepository<Fornecedor>
    {
        private EFContext _context;

        public FornecedorService(EFContext context)
        {
            this._context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> findAll()
        {
            return _context.Fornecedor.ToList();
        }

        public Fornecedor findById(int? id)
        {
            if (id == null || id.Value <= 0)
            {
                throw new ArgumentException("Invalid or missing ID parameter.");
            }

            Fornecedor result = null;

            try
            {
                result = _context.Fornecedor.FirstOrDefault(m => m.Id == id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while fetching the data from the database.", ex);
            }

            return result;
        }

        public void insert(Fornecedor obj)
        {
            _context.Fornecedor.Add(obj);
            _context.SaveChanges();
        }

        public void update(Fornecedor obj)
        {
            var objOld = findById(obj.Id);
            _context.Entry(objOld).CurrentValues.SetValues(obj);
        }
    }
}