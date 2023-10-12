using ERPFacturacao.Data;
using ERPFacturacao.Model;
using ERPFacturacao.Model.Enum;
using ERPFacturacao.Service;
using System.Collections.Generic;

namespace ERPFacturacao.Controller
{
    internal class ArtigoController
    {
        private readonly ArtigoService _service;
        private readonly EFContext _context;
        private FormCadastroProductoServico formCadastroProductoServico;

        public ArtigoController(FormCadastroProductoServico formCadastroProductoServico)
        {
            this.formCadastroProductoServico = formCadastroProductoServico;
            _context = new EFContext();
            _service = new ArtigoService(_context);
            SetFormEvents();
        }

        public void SetFormEvents()
        {
            this.formCadastroProductoServico.Gravar += Gravar;
            this.formCadastroProductoServico.Novo += Novo;
            this.formCadastroProductoServico.Editar += Editar;
            this.formCadastroProductoServico.Listar += Listar;
            Console.WriteLine("Chegou Events");
        }

        Artigo SetArtigoFromForm()
        {
            Console.WriteLine("Chegou SetArtigo");
            Artigo artigo = new ArtigoBuilder()
                .SetCodigoArtigo(this.formCadastroProductoServico.CodigoArtidoTextBox)
                .SetDescricao(this.formCadastroProductoServico.DescricaoTextBox)
                .SetCodigoBarras(this.formCadastroProductoServico.CodigoBarraTextBox)
                .SetMovimentaStock(this.formCadastroProductoServico.MovimentaCheckBox)
                .SetDevolucao(this.formCadastroProductoServico.DevolucaoCheckBox)
                .SetActivo(this.formCadastroProductoServico.ActivoCheckBox)
                .SetDesconto(this.formCadastroProductoServico.DescontoTextBox != null ? double.Parse( this.formCadastroProductoServico.DescontoTextBox) : 0.0)
                .SetPrecoCompra(this.formCadastroProductoServico.PrecoCompraTextBox != null ? double.Parse(this.formCadastroProductoServico.PrecoCompraTextBox):0.0)
                //.SetCustoCompra(this.formCadastroProductoServico.)
                .SetPrecoVenda(this.formCadastroProductoServico.PrecoVendaTextBox != null ? double.Parse(this.formCadastroProductoServico.PrecoVendaTextBox):0.0)
                //.SetPeso(this.formCadastroProductoServico)
                //.SetLargura()
                //.SetAltura()
                //.SetComprimento()
                //.SetObservacao()
                .SetFornecedorId(int.Parse(this.formCadastroProductoServico.FornecedorComboBox.SelectedValue.ToString()))
                .SetTipoArtigoId(int.Parse(this.formCadastroProductoServico.TipoArtigoComboBox.SelectedValue.ToString()))
                .SetTipoIVA((TipoIVA)this.formCadastroProductoServico.TipoIVAComboBox.SelectedValue)
                .SetDataRegisto(DateTime.Now)
                .Build();
            return artigo;
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
            var artigo = SetArtigoFromForm();
            Console.WriteLine("Chegou Grvar");
            _service.insert(artigo);
            MessageBox.Show("Ok");
        }
    }
}