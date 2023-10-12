using ERPFacturacao.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    public class FornecedorBuilder
    {
        private Fornecedor fornecedor;
        public FornecedorBuilder()
        {
            fornecedor = new Fornecedor();
        }
        /**/
        public FornecedorBuilder SetId(int id)
        {
            fornecedor.Id = id;
            return this;
        }

        public FornecedorBuilder SetNome(string nome)
        {
            fornecedor.Nome = nome;
            return this;
        }

        public FornecedorBuilder SetNomeFiscal(string? nomeFiscal)
        {
            fornecedor.NomeFiscal = nomeFiscal;
            return this;
        }

        public FornecedorBuilder SetBi(string? bi)
        {
            fornecedor.Bi = bi;
            return this;
        }

        public FornecedorBuilder SetNif(string nif)
        {
            fornecedor.Nif = nif;
            return this;
        }

        public FornecedorBuilder SetNacionalidade(string? nacionalidade)
        {
            fornecedor.Nacionalidade = nacionalidade;
            return this;
        }

        public FornecedorBuilder SetNaturalidade(string? naturalidade)
        {
            fornecedor.Naturalidade = naturalidade;
            return this;
        }

        public FornecedorBuilder SetContribuinteOrigem(string? contribuinteOrigem)
        {
            fornecedor.ContribuinteOrigem = contribuinteOrigem;
            return this;
        }

        public FornecedorBuilder SetPaisId(int? paisId)
        {
            fornecedor.PaisId = paisId;
            return this;
        }

        public FornecedorBuilder SetPais(Pais? pais)
        {
            fornecedor.Pais = pais;
            return this;
        }

        public FornecedorBuilder SetRamoActividadeId(int? ramoActividadeId)
        {
            fornecedor.RamoActividadeId = ramoActividadeId;
            return this;
        }

        public FornecedorBuilder SetRamoActividade(RamoActividade? ramoActividade)
        {
            fornecedor.RamoActividade = ramoActividade;
            return this;
        }

        public FornecedorBuilder SetTipoContribuinte(TipoContribuinte? tipoContribuinte)
        {
            fornecedor.TipoContribuinte = tipoContribuinte;
            return this;
        }

        public FornecedorBuilder SetTipoPessoa(TipoPessoa? tipoPessoa)
        {
            fornecedor.TipoPessoa = tipoPessoa;
            return this;
        }

        public FornecedorBuilder SetEstadoCivil(EstadoCivil? estadoCivil)
        {
            fornecedor.EstadoCivil = estadoCivil;
            return this;
        }

        public FornecedorBuilder SetGenero(Genero? genero)
        {
            fornecedor.Genero = genero;
            return this;
        }
        /**/
       

        public FornecedorBuilder SetCodigoFornecedor(string codigoFornecedor)
        {
            fornecedor.CodigoFornecedor = codigoFornecedor;
            return this;
        }

        public FornecedorBuilder SetObs(string obs)
        {
            fornecedor.Obs = obs;
            return this;
        }

        public FornecedorBuilder SetActivo(bool activo)
        {
            fornecedor.Activo = activo;
            return this;
        }

        public FornecedorBuilder SetDesconto(bool? desconto)
        {
            fornecedor.Desconto = desconto;
            return this;
        }

        public FornecedorBuilder SetValorDesconto(double? valorDesconto)
        {
            fornecedor.ValorDesconto = valorDesconto;
            return this;
        }

        public FornecedorBuilder SetPrazoEntrega(int? prazoEntrega)
        {
            fornecedor.PrazoEntrega = prazoEntrega;
            return this;
        }

        public FornecedorBuilder SetLimiteCredito(double? limiteCredito)
        {
            fornecedor.LimiteCredito = limiteCredito;
            return this;
        }

        public FornecedorBuilder SetTipoClienteFornecedor(TipoClienteFornecedor tipo)
        {
            fornecedor.TipoClienteFornecedor = tipo;
            return this;
        }

        public FornecedorBuilder SetContasBancarias(List<ContaBancaria> contasBancarias)
        {
            fornecedor.ContasBancarias = contasBancarias;
            return this;
        }

        public FornecedorBuilder SetEnderecos(List<Endereco> enderecos)
        {
            fornecedor.Enderecos = enderecos;
            return this;
        }

        public FornecedorBuilder SetContactos(List<Contacto> contactos)
        {
            fornecedor.Contactos = contactos;
            return this;
        }

        public FornecedorBuilder SetDataRegisto(DateTime dataRegisto)
        {
            fornecedor.DataRegisto = dataRegisto;
            return this;
        }

        public FornecedorBuilder SetDataActualizacao(DateTime dataActualizacao)
        {
            fornecedor.DataActualizacao = dataActualizacao;
            return this;
        }

        public FornecedorBuilder SetDataAnulacao(DateTime dataAnulacao)
        {
            fornecedor.DataAnulacao = dataAnulacao;
            return this;
        }

        public Fornecedor Build()
        {
            return fornecedor;
        }
    }
}
