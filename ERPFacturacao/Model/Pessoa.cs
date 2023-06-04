using ERPFacturacao.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string? Bi { get; set; }
        public string? Nacionalidade { get; set;}
        public string? Naturalidade { get; set;}
        public EstadoCivil? EstadoCivil { get; set; }
        public Genero? Genero { get; set; }
    }
}
