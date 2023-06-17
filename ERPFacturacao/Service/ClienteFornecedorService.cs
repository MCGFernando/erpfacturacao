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
            throw new NotImplementedException();
        }

        public void insert(ClienteFonecedor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(ClienteFonecedor obj)
        {
            throw new NotImplementedException();
        }
    }
}