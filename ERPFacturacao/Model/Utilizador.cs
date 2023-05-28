using ERPFacturacao.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPFacturacao.Model
{
    [Serializable]
    [Table("utilizadores")]
    public class Utilizador
    {
        
        public int Id { get; set; }
        //public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        [Column("utilizador")]
        public string _Utilizador { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public Estado Estado { get; set; } = Estado.INACTIVO;
        public bool IsAdmin { get; set; } = false;
        public bool IsSu { get; set; } = false;
    }
}
