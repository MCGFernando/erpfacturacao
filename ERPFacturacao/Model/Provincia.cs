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
    [Table("provincias")]
    public class Provincia
    {
        public int Id { get; set; }
        [Column("provincia")]
        [Required]
        public string _Provincia { get; set; }
        [Column("codigo_provincia")]
        public string? CodigoProvincia { get; set; }
        [Column("paises_is")]
        public int PaisId { get; set; }
        public Pais? Pais { get; set; }
        [Column("data_registo")]
        public DateTime DataRegisto { get; set; }
        [Column("data_actualizacao")]
        public DateTime? DataActualizacao { get; set; }
        [Column("data_anulacao")]
        public DateTime? DataAnulacao { get; set; }
    }
}
