using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    public class Endereco
    {
        public int Id { get; set; }
        public int TipoEnderecoId { get; set; }
        public TipoEndereco? TipoEndereco { get; set; }
        public int? MunicipioId { get; set; }
        public Municipio? Municipio { get; set; }
        public string _Endereco { get; set; }
        public string? Rua { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Referencia { get; set; }
        [Column("data_registo")]
        public DateTime DataRegisto { get; set; }
        [Column("data_actualizacao")]
        public DateTime DataActualizacao { get; set; }
        [Column("data_anulacao")]
        public DateTime DataAnulacao { get; set; }
    }
}
