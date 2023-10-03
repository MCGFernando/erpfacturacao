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
    public class CategoriaProductoServicoService : IRepository<CategoriaProductoServico>
    {
        private readonly EFContext _context;

        public CategoriaProductoServicoService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoriaProductoServico> findAll()
        {
            return _context.CategoriaProductoServico.ToList();
        }

        public CategoriaProductoServico findById(int? id)
        {
            if (id == null || id.Value <= 0)
            {
                throw new ArgumentException("Invalid or missing ID parameter.");
            }

            CategoriaProductoServico result = null;

            try
            {
                result = _context.CategoriaProductoServico.FirstOrDefault(m => m.Id == id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while fetching the data from the database.", ex);
            }

            return result;
        }

        public void insert(CategoriaProductoServico obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(CategoriaProductoServico obj)
        {
            var objOld = findById(obj.Id);
            _context.Entry(objOld).CurrentValues.SetValues(obj);
        }
    }
}
