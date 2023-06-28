using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    public class Modelo
    {
        public int Id { get; set; }
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
        public string _Modelo { get; set; }
        public string Descricao { get; set; }
    }
}
