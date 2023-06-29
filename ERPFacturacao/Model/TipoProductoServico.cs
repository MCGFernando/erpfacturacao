using ERPFacturacao.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    public class TipoProductoServico
    {
        public int Id { get; set; }
        public string _TipoProductoServico { get; set; }
        public TipoFiscalProductoServico TipoFiscalProductoServico { get; set; }
        [Column("data_registo")]
        public DateTime DataRegisto { get; set; }
        [Column("data_actualizacao")]
        public DateTime? DataActualizacao { get; set; }
        [Column("data_anulacao")]
        public DateTime? DataAnulacao { get; set; }
    }
}
