using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model.Enum
{
    public enum  TipoPagamento : int
    {
        DINHEIRO = 1,
        TRANSFERENCIA = 2,
        CARTAO = 3,
        TALAO_MULTICAIXA = 4,
        CHEQUE = 5,
        ELECTRONICO = 6

    }
}
