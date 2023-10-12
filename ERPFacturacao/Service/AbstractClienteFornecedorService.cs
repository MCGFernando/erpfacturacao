using ERPFacturacao.Data;
using ERPFacturacao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Service
{
    public abstract class AbstractClienteFornecedorService
    {
        public abstract ClienteService PrepreClienteService(EFContext context);

        public abstract FornecedorService PrepreFornecedorService(EFContext context);
    }
}
