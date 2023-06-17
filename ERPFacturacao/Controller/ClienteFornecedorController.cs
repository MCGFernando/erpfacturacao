using ERPFacturacao.Data;
using ERPFacturacao.Service;
using System.Collections.Generic;

namespace ERPFacturacao.Controller
{
    internal class ClienteFornecedorController
    {
        private FormCadastroClienteFornecedor frmClienteFornecedor;
        private readonly ClienteFornecedorService _service;
        private readonly EFContext _context;
        public ClienteFornecedorController(FormCadastroClienteFornecedor frmClienteFornecedor)
        {
            this.frmClienteFornecedor = frmClienteFornecedor;
            _context = new EFContext();
            _service = new ClienteFornecedorService(_context);
            this.frmClienteFornecedor.Gravar += Gravar;
            this.frmClienteFornecedor.Novo += Novo;
            this.frmClienteFornecedor.Editar += Editar;
            this.frmClienteFornecedor.Listar += Listar;
        }

        private void Listar(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Editar(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Novo(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Gravar(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}