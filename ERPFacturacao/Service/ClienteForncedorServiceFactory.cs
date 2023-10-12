using ERPFacturacao.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Service
{
    public class ClienteForncedorServiceFactory : AbstractClienteFornecedorService
    {
        public override ClienteService PrepreClienteService(EFContext context)
        {
            return new ClienteService(context);    
        }

        public override FornecedorService PrepreFornecedorService(EFContext context)
        {
            return new FornecedorService(context);
        }
    }
}
