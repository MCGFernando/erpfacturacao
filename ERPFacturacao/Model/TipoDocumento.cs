using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    [Serializable]
    [Table("tipos_documentos")]
    public class TipoDocumento
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        [Column("data_registo")]
        public DateTime DataRegisto { get; set; }
        [Column("data_actualizacao")]
        public DateTime? DataActualizacao { get; set; }
        [Column("data_anulacao")]
        public DateTime? DataAnulacao { get; set; }
    }
}
