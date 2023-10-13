using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    [Serializable]
    [Table("contas_contabeis")]
    public class ContaContabil
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public long Sequencia { get; set; }
        public string Descricao { get; set; }

        public int ContaContabilAgregadoraId { get; set; }
        public ContaContabilAgregadora ContaContabilAgregadora { get; set; }
    }
}
