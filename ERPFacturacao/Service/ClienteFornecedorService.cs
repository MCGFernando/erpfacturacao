using ERPFacturacao.Data;
using ERPFacturacao.Model;
using ERPFacturacao.Service.impl;

namespace ERPFacturacao.Service
{
    internal class ClienteFornecedorService : IRepository<ClienteFonecedor>
    {
        private EFContext _context;

        public ClienteFornecedorService(EFContext context)
        {
            this._context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ClienteFonecedor> findAll()
        {
            return _context.ClienteFornecedor.ToList();
        }

        public ClienteFonecedor findById(int? id)
        {
            if (id == null || id.Value <= 0)
            {
                throw new ArgumentException("Invalid or missing ID parameter.");
            }

            ClienteFonecedor result = null;

            try
            {
                result = _context.ClienteFornecedor.FirstOrDefault(m => m.Id == id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while fetching the data from the database.", ex);
            }

            return result;
        }

        public void insert(ClienteFonecedor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(ClienteFonecedor obj)
        {
            var objOld = findById(obj.Id);
            _context.Entry(objOld).CurrentValues.SetValues(obj);
        }
    }
}