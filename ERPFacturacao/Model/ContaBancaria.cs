using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    [Serializable]
    [Table("contas_bancarias")]
    public class ContaBancaria
    {
        public int Id { get; set; }
        public int ClienteFonecedorId { get; set; }
        public ClienteFonecedor ClienteFonecedor { get; set; }
        public int BancoId { get; set; }
        public Banco Banco { get; set; }
        [Column("numero_conta")]
        public string NumeroConta { get; set; }
        public string IBAN { get; set; }
        public string Agencia { get; set; }
        [Column("gestor_conta")]
        public string? GestorConta { get; set; }
        [Column("email_gestor_conta")]
        public string? EmailGestorConta { get; set; }
        [Column("email_alternativo_gestor_conta")]
        public string? EmailAlternativoGestorConta { get; set; }
        [Column("telefone_gestor_conta")]
        public string? TelefoneGestorConta { get; set; }
        [Column("telefone_alternativo_gestor_conta")]
        public string? TelefoneAlternativoGestorConta { get; set; }
        [Column("data_registo")]
        public DateTime DataRegisto { get; set; }
        [Column("data_actualizacao")]
        public DateTime DataActualizacao { get; set; }
        [Column("data_anulacao")]
        public DateTime DataAnulacao { get; set; }
    }
}
