using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Service.impl
{
    internal interface IRepository<T>
    {
        public void insert(T obj);
        public void delete(int id);
        public void update(T obj);
        public T findById(int? id);
        public List<T> findAll();


    }
}
