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
    public class RamoActividadeService : IRepository<RamoActividade>
    {
        private readonly EFContext _context;

        public RamoActividadeService(EFContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<RamoActividade> findAll()
        {
            return _context.RamoActividade.ToList();
        }

        public RamoActividade findById(int? id)
        {
            throw new NotImplementedException();
        }

        public void insert(RamoActividade obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void update(RamoActividade obj)
        {
            throw new NotImplementedException();
        }
    }
}
