using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    [Serializable]
    [Table("classes_contabeis")]
    public class ClasseContabil
    {
        public int Id { get; set; }
        public string Classe { get; set; }
    }
}
