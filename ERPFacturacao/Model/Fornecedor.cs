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
    [Table("fornecedores")]
    public class Fornecedor : ClienteFornecedor
    {
        //public int Id { get; set; }
        public string CodigoFornecedor { get; set; }
        public string? Obs { get; set; }
        public bool Activo { get; set; } = true;
        public bool? Desconto { get; set; }
        public Double? ValorDesconto { get; set; }
        public int? PrazoEntrega { get; set; }// período de tempo estipulado para que um produto ou serviço seja entregue ao cliente após a realização da compra ou contratação.
        public Double? LimiteCredito { get; set; }//O limite de crédito refere-se ao valor máximo que uma empresa ou indivíduo pode utilizar em compras a prazo ou obter como empréstimo junto a uma instituição financeira

        public TipoClienteFornecedor TipoClienteFornecedor { get; set; } = TipoClienteFornecedor.FORNECEDOR;

        public List<ContaBancaria>? ContasBancarias { get; set; }
        public List<Endereco>? Enderecos { get; set; }
        public List<Contacto>? Contactos { get; set; }

        [Column("data_registo")]
        public DateTime DataRegisto { get; set; }
        [Column("data_actualizacao")]
        public DateTime DataActualizacao { get; set; }
        [Column("data_anulacao")]
        public DateTime DataAnulacao { get; set; }
    }
}
