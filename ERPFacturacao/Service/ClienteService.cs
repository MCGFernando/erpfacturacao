using ERPFacturacao.Data;
using ERPFacturacao.Model;
using ERPFacturacao.Service.impl;

namespace ERPFacturacao.Service
{
    public class ClienteService : IRepository<Cliente>
    {
        private EFContext _context;

        public ClienteService(EFContext context)
        {
            this._context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> findAll()
        {
            return _context.Cliente.ToList();
        }

        public Cliente findById(int? id)
        {
            if (id == null || id.Value <= 0)
            {
                throw new ArgumentException("Invalid or missing ID parameter.");
            }

            Cliente result = null;

            try
            {
                result = _context.Cliente.FirstOrDefault(m => m.Id == id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while fetching the data from the database.", ex);
            }

            return result;
        }

        public void insert(Cliente obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(Cliente obj)
        {
            var objOld = findById(obj.Id);
            _context.Entry(objOld).CurrentValues.SetValues(obj);
        }
    }
}