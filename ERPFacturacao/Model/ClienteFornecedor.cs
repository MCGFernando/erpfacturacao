using ERPFacturacao.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    public abstract class ClienteFornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? NomeFiscal { get; set; }
        public string? Bi { get; set; }
        public string Nif { get; set; }
        public string? Nacionalidade { get; set;}
        public string? Naturalidade { get; set;}
        public string? ContribuinteOrigem { get; set; }
       
        public int? PaisId { get; set; }
        public Pais? Pais { get; set; }
        public int? RamoActividadeId { get; set; }
        public RamoActividade? RamoActividade { get; set; }

        public TipoContribuinte? TipoContribuinte { get; set; }
        public TipoPessoa? TipoPessoa { get; set; }
        public EstadoCivil? EstadoCivil { get; set; }
        public Genero? Genero { get; set; }
    }
}
