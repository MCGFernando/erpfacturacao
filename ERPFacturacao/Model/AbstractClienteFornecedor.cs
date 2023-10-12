using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    public abstract class AbstractClienteFornecedor
    {
        public abstract Cliente PrepreCliente();

        public abstract Fornecedor PrepreFornecedor();
        
    }
}
