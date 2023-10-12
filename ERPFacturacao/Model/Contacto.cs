using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ERPFacturacao.Model
{
    public class Contacto
    {
        public int Id { get; set; }
        public int TipoContactoId { get; set; }
        public TipoContacto TipoContacto { get; set; }
        public int ClienteFonecedorId { get; set; }
        public Cliente ClienteFonecedor { get; set; }
        public string? Telefone { get; set; }
        public string? Telemovel { get; set; }
        public string? Email { get; set; }
        public string? Site { get; set; }
        public bool Principal { get; set; } = false;
        [Column("data_registo")]
        public DateTime DataRegisto { get; set; }
        [Column("data_actualizacao")]
        public DateTime DataActualizacao { get; set; }
        [Column("data_anulacao")]
        public DateTime DataAnulacao { get; set; }
    }
}
