using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    public class ClienteCreator : IClienteFornecedorCreator
    {
        public ClienteFornecedor CreateClienteFornecedor()
        {
            return new Cliente();
        }
    }
}
