using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    [Serializable]
    [Table("enderecos")]
    public class Endereco
    {
        public int Id { get; set; }
        public int TipoEnderecoId { get; set; }
        public TipoEndereco? TipoEndereco { get; set; }
        public int? MunicipioId { get; set; }
        public Municipio? Municipio { get; set; }
        public int? ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public int? FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }
        [Column("endereco")]
        public string _Endereco { get; set; }
        public string? Rua { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Referencia { get; set; }
        public string? CodigoPostal { get; set; }
        [Column("data_registo")]
        public DateTime DataRegisto { get; set; }
        [Column("data_actualizacao")]
        public DateTime DataActualizacao { get; set; }
        [Column("data_anulacao")]
        public DateTime DataAnulacao { get; set; }
    }
}
