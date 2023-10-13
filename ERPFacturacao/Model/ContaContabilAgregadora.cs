using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    [Serializable]
    [Table("contas_contabeis_agregadoras")]
    public class ContaContabilAgregadora
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set;}
    }
}
