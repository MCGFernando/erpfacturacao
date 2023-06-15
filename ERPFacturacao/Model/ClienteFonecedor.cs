using ERPFacturacao.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    [Serializable]
    [Table("clientes_fornecedores")]
    public class ClienteFonecedor : Pessoa
    {
        public int Id { get; set; }
        public int? PaisId { get; set; }
        public Pais? Pais { get; set; }
        public int? RamoActividadeId { get; set; }
        public RamoActividade? RamoActividade { get; set; }
        
        public List<Banco>? Bancos { get; set; }
        public List<Endereco>? Enderecos { get; set; }
        public List<Contacto>? Contactos { get; set; }
        
        public string CodigoClienteFornecedor { get; set; }
        public string Nome { get; set; }
        public string? NomeFiscal { get; set; }
        public string? ContribuinteOrigem { get; set; }
        public string Nif { get; set; }
        public string Obs { get; set; }

        public bool? Desconto { get; set; }
        public Double? ValorDesconto { get; set; }
        public int? PrazoEntrega { get; set; }// período de tempo estipulado para que um produto ou serviço seja entregue ao cliente após a realização da compra ou contratação.
        public Double? LimiteCredito { get; set; }//O limite de crédito refere-se ao valor máximo que uma empresa ou indivíduo pode utilizar em compras a prazo ou obter como empréstimo junto a uma instituição financeira
        public TipoContribuinte TipoContribuinte { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public Estado Estado { get; set; }

        public bool? Fornecedor { get; set; }
        public bool? Cliente { get; set; }

        

        [Column("data_registo")]
        public DateTime DataRegisto { get; set; }
        [Column("data_actualizacao")]
        public DateTime DataActualizacao { get; set; }
        [Column("data_anulacao")]
        public DateTime DataAnulacao { get; set; }
    }
}
