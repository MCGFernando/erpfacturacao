using ERPFacturacao.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    public class ClienteBuilder
    {
        private Cliente cliente;

        public ClienteBuilder()
        {
            cliente = new Cliente();
        }
        /**/
        public ClienteBuilder SetId(int id)
        {
            cliente.Id = id;
            return this;
        }

        public ClienteBuilder SetNome(string nome)
        {
            cliente.Nome = nome;
            return this;
        }

        public ClienteBuilder SetNomeFiscal(string? nomeFiscal)
        {
            cliente.NomeFiscal = nomeFiscal;
            return this;
        }

        public ClienteBuilder SetBi(string? bi)
        {
            cliente.Bi = bi;
            return this;
        }

        public ClienteBuilder SetNif(string nif)
        {
            cliente.Nif = nif;
            return this;
        }

        public ClienteBuilder SetNacionalidade(string? nacionalidade)
        {
            cliente.Nacionalidade = nacionalidade;
            return this;
        }

        public ClienteBuilder SetNaturalidade(string? naturalidade)
        {
            cliente.Naturalidade = naturalidade;
            return this;
        }

        public ClienteBuilder SetContribuinteOrigem(string? contribuinteOrigem)
        {
            cliente.ContribuinteOrigem = contribuinteOrigem;
            return this;
        }

        public ClienteBuilder SetPaisId(int? paisId)
        {
            cliente.PaisId = paisId;
            return this;
        }

        public ClienteBuilder SetPais(Pais? pais)
        {
            cliente.Pais = pais;
            return this;
        }

        public ClienteBuilder SetRamoActividadeId(int? ramoActividadeId)
        {
            cliente.RamoActividadeId = ramoActividadeId;
            return this;
        }

        public ClienteBuilder SetRamoActividade(RamoActividade? ramoActividade)
        {
            cliente.RamoActividade = ramoActividade;
            return this;
        }

        public ClienteBuilder SetTipoContribuinte(TipoContribuinte? tipoContribuinte)
        {
            cliente.TipoContribuinte = tipoContribuinte;
            return this;
        }

        public ClienteBuilder SetTipoPessoa(TipoPessoa? tipoPessoa)
        {
            cliente.TipoPessoa = tipoPessoa;
            return this;
        }

        public ClienteBuilder SetEstadoCivil(EstadoCivil? estadoCivil)
        {
            cliente.EstadoCivil = estadoCivil;
            return this;
        }

        public ClienteBuilder SetGenero(Genero? genero)
        {
            cliente.Genero = genero;
            return this;
        }
        /**/
        
        public ClienteBuilder SetCodigoCliente(string codigoCliente)
        {
            cliente.CodigoCliente = codigoCliente;
            return this;
        }

        public ClienteBuilder SetObs(string obs)
        {
            cliente.Obs = obs;
            return this;
        }

        public ClienteBuilder SetActivo(bool? activo)
        {
            cliente.Activo = activo;
            return this;
        }

        public ClienteBuilder SetDesconto(bool? desconto)
        {
            cliente.Desconto = desconto;
            return this;
        }

        public ClienteBuilder SetValorDesconto(double? valorDesconto)
        {
            cliente.ValorDesconto = valorDesconto;
            return this;
        }

        public ClienteBuilder SetPrazoEntrega(int? prazoEntrega)
        {
            cliente.PrazoEntrega = prazoEntrega;
            return this;
        }

        public ClienteBuilder SetLimiteCredito(double? limiteCredito)
        {
            cliente.LimiteCredito = limiteCredito;
            return this;
        }

        public ClienteBuilder SetTipoClienteFornecedor(TipoClienteFornecedor tipo)
        {
            cliente.TipoClienteFornecedor = tipo;
            return this;
        }

        public ClienteBuilder SetContasBancarias(List<ContaBancaria> contasBancarias)
        {
            cliente.ContasBancarias = contasBancarias;
            return this;
        }

        public ClienteBuilder SetEnderecos(List<Endereco> enderecos)
        {
            cliente.Enderecos = enderecos;
            return this;
        }

        public ClienteBuilder SetContactos(List<Contacto> contactos)
        {
            cliente.Contactos = contactos;
            return this;
        }

        public ClienteBuilder SetDataRegisto(DateTime dataRegisto)
        {
            cliente.DataRegisto = dataRegisto;
            return this;
        }

        public ClienteBuilder SetDataActualizacao(DateTime dataActualizacao)
        {
            cliente.DataActualizacao = dataActualizacao;
            return this;
        }

        public ClienteBuilder SetDataAnulacao(DateTime dataAnulacao)
        {
            cliente.DataAnulacao = dataAnulacao;
            return this;
        }

        public Cliente Build()
        {
            return cliente;
        }
    }
}
