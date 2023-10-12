using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    public class ClienteFornecedorFactory : AbstractClienteFornecedor
    {
        public override Cliente PrepreCliente()
        {
            return new Cliente();
        }

        public override Fornecedor PrepreFornecedor()
        {
            return new Fornecedor();
        }
    }
}
