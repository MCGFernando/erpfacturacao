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
        public int ClienteFonecedorId { get; set; }
        public ClienteFonecedor ClienteFonecedor { get; set; }
        public string? Sigla { get; set; }
        [Column("banco")]
        public string _Banco { get; set; }
        public string? Agencia { get; set; }
    }
}
