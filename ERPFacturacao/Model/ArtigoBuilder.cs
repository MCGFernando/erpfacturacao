using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    public class ArtigoBuilder
    {
        private Artigo artigo;

        public ArtigoBuilder()
        {
            artigo = new Artigo();
        }

        public ArtigoBuilder SetId(int id)
        {
            artigo.Id = id;
            return this;
        }

        public ArtigoBuilder SetCodigoArtigo(string codigoArtigo)
        {
            artigo.CodigoArtigo = codigoArtigo;
            return this;
        }

        public ArtigoBuilder SetDescricao(string descricao)
        {
            artigo.Descricao = descricao;
            return this;
        }

        public ArtigoBuilder SetCodigoBarras(string codigoBarras)
        {
            artigo.CodigoBarras = codigoBarras;
            return this;
        }

        public ArtigoBuilder SetMovimentaStock(bool movimentaStock)
        {
            artigo.MovimentaStock = movimentaStock;
            return this;
        }

        public ArtigoBuilder SetDevolucao(bool devolucao)
        {
            artigo.Devolucao = devolucao;
            return this;
        }

        public ArtigoBuilder SetActivo(bool activo)
        {
            artigo.Activo = activo;
            return this;
        }

        public ArtigoBuilder SetGarantia(int garantia)
        {
            artigo.Garantia = garantia;
            return this;
        }

        public ArtigoBuilder SetDesconto(double desconto)
        {
            artigo.Desconto = desconto;
            return this;
        }

        public ArtigoBuilder SetPrecoCompra(double precoCompra)
        {
            artigo.PrecoCompra = precoCompra;
            return this;
        }

        public ArtigoBuilder SetCustoCompra(double custoCompra)
        {
            artigo.CustoCompra = custoCompra;
            return this;
        }

        public ArtigoBuilder SetPrecoVenda(double precoVenda)
        {
            artigo.PrecoVenda = precoVenda;
            return this;
        }

        public ArtigoBuilder SetPeso(double peso)
        {
            artigo.Peso = peso;
            return this;
        }

        public ArtigoBuilder SetLargura(string largura)
        {
            artigo.Largura = largura;
            return this;
        }

        public ArtigoBuilder SetAltura(string altura)
        {
            artigo.Altura = altura;
            return this;
        }

        public ArtigoBuilder SetComprimento(string comprimento)
        {
            artigo.Comprimento = comprimento;
            return this;
        }

        public ArtigoBuilder SetObservacao(string observacao)
        {
            artigo.Observacao = observacao;
            return this;
        }

        public ArtigoBuilder SetFornecedorId(int fornecedorId)
        {
            artigo.FornecedorId = fornecedorId;
            return this;
        }

        public ArtigoBuilder SetFornecedor(Fornecedor fornecedor)
        {
            artigo.Fornecedor = fornecedor;
            return this;
        }

        public ArtigoBuilder SetTipoIVA(TipoIVA tipoIVA)
        {
            artigo.TipoIVA = tipoIVA;
            return this;
        }
        public ArtigoBuilder SetTipoArtigoId(int tipoArtigoId)
        {
            artigo.TipoArtigoId = tipoArtigoId;
            return this;
        }
        public ArtigoBuilder SetTipoArtigo(TipoArtigo tipoArtigo)
        {
            artigo.TipoArtigo = tipoArtigo;
            return this;
        }

        public ArtigoBuilder SetModelo(Modelo modelo)
        {
            artigo.Modelo = modelo;
            return this;
        }

        public ArtigoBuilder SetDataRegisto(DateTime dataRegisto)
        {
            artigo.DataRegisto = dataRegisto;
            return this;
        }

        public ArtigoBuilder SetDataActualizacao(DateTime? dataActualizacao)
        {
            artigo.DataActualizacao = dataActualizacao;
            return this;
        }

        public ArtigoBuilder SetDataAnulacao(DateTime? dataAnulacao)
        {
            artigo.DataAnulacao = dataAnulacao;
            return this;
        }

        public Artigo Build()
        {
            return artigo;
        }
    }
}
