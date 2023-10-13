using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    public class Serie
    {
        public int Id { get; set; }
        public string CodigoSerie { get; set; }
        public long Sequencia { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public long LimiteInferior { get; set; }
        public long LimiteSuperior { get; set; }
        public string UltimoDocumento { get; set; }
        public DateTime DataUltimoDocumento { get; set; }
        public List<TipoDocumento> TipoDocumento { get; set; }
        [Column("data_registo")]
        public DateTime DataRegisto { get; set; }
        [Column("data_actualizacao")]
        public DateTime DataActualizacao { get; set; }
        [Column("data_anulacao")]
        public DateTime DataAnulacao { get; set; }

    }
}
