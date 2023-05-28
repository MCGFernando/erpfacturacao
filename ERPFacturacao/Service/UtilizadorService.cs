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
    public class UtilizadorService : IRepository<Utilizador>
    {
        private readonly EFContext _context;

        public UtilizadorService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Utilizador> findAll()
        {
            throw new NotImplementedException();
        }

        public Utilizador findById(int? id)
        {
            throw new NotImplementedException();
        }

        public void insert(Utilizador obj)
        {
            throw new NotImplementedException();
        }

        public void update(Utilizador obj)
        {
            throw new NotImplementedException();
        }
    }
}
