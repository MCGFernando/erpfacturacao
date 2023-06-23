using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    [Serializable]
    [Table("bancos")]
    public class Banco
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        [Column("banco")]
        public string _Banco { get; set; }
        [Column("data_registo")]
        public DateTime DataRegisto { get; set; }
        [Column("data_actualizacao")]
        public DateTime DataActualizacao { get; set; }
        [Column("data_anulacao")]
        public DateTime DataAnulacao { get; set; }
    }
}
