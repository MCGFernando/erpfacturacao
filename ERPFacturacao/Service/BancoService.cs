﻿using ERPFacturacao.Data;
using ERPFacturacao.Model;
using ERPFacturacao.Service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Service
{
    public class BancoService : IRepository<Banco>
    {
        private readonly EFContext _context;

        public BancoService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Banco> findAll()
        {
            return _context.Banco.ToList();
        }

        public Banco findById(int? id)
        {
            throw new NotImplementedException();
        }

        public void insert(Banco obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(Banco obj)
        {
            throw new NotImplementedException();
        }
    }
}
