using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    [Serializable]
    [Table("paises")]
    public class Pais
    {
        public int Id { get; set; }
        [Column("pais")]
        [Required]
        public string _Pais { get; set; }
        [Column("codigo_pais")]
        public string? CodigoPais { get; set; }
        public string? Moeda { get; set; }
        [Column("codigo_moeda")]
        public string? CodigoMoeda { get; set; }
        [Column("dominio_topo")]
        public string? DominioTopo { get; set; }
        [Column("codigo_telefonia")]
        public string? CodigoTelefonia { get; set; }
        [Column("data_registo")]
        public DateTime DataRegisto { get; set; }
        [Column("data_actualizacao")]
        public DateTime? DataActualizacao { get; set; }
        [Column("data_anulacao")]
        public DateTime? DataAnulacao { get; set; }
    }
}
