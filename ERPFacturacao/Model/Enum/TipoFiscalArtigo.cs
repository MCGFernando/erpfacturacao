using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model.Enum
{
    public enum TipoFiscalArtigo : int
    {
        PRODUCTO = 1,
        SERVICO = 2,
        OUTROS = 3,
        IMPOSTOS_ESPECIAIS = 4
    }
}
