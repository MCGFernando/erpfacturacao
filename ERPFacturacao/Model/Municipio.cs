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
    [Table("municipios")]
    public class Municipio
    {
        public int Id { get; set; }
        [Column("municipio")]
        [Required]
        public string _Municipio { get; set; }
        [Column("codigo_municipio")]
        public string? CodigoMunicipio { get; set; }
        [Column("provincia_id")]
        public int ProvinciaId { get; set; }
        public Provincia? Provincia { get; set; }
        [Column("data_registo")]
        public DateTime DataRegisto { get; set; }
        [Column("data_actualizacao")]
        public DateTime? DataActualizacao { get; set; }
        [Column("data_anulacao")]
        public DateTime? DataAnulacao { get; set; }
    }
}
