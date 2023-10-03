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
    [Table("cargos")]
    public class Cargo 
    {
        public int Id { get; set; }
        [Column("utilizadores_cargos_id")]
        [ForeignKey("Utilizador")]
        public int UtilizadorId { get; set; }
        [Column("cargo")]
        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "O Campo {0} é obrigatório.")]
        public string _Cargo { get; set; }
        public string Sigla { get; set; }

        [Column("data_registo")]
        public DateTime DataRegisto { get; set; } 
        [Column("data_actualizacao")]
        public DateTime DataActualizacao { get; set; }
        [Column("data_anulacao")]
        public DateTime DataAnulacao { get; set; }

       
    }
}
