using System.Collections.Generic;

namespace ERPFacturacao.Controller
{
    internal class ArtigoController
    {
        private FormCadastroProductoServico formCadastroProductoServico;

        public ArtigoController(FormCadastroProductoServico formCadastroProductoServico)
        {
            this.formCadastroProductoServico = formCadastroProductoServico;
            SetFormEvents();
        }

        public void SetFormEvents()
        {
            this.formCadastroProductoServico.Gravar += Gravar;
            this.formCadastroProductoServico.Novo += Novo;
            this.formCadastroProductoServico.Editar += Editar;
            this.formCadastroProductoServico.Listar += Listar;
            
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