using ERPFacturacao.Data;
using ERPFacturacao.Model;
using ERPFacturacao.Model.Enum;
using ERPFacturacao.Service;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERPFacturacao.Controller
{
    internal class ClienteFornecedorController
    {
        private FormCadastroClienteFornecedor frmClienteFornecedor;
        private readonly ClienteService _clitenService;
        private readonly FornecedorService _fornecedorService;
        private readonly ClienteForncedorServiceFactory _service;
        private readonly EFContext _context;
        public ClienteFornecedorController(FormCadastroClienteFornecedor frmClienteFornecedor, TipoClienteFornecedor tipoClienteFornecedor)
        {
            this.frmClienteFornecedor = frmClienteFornecedor;
            _context = new EFContext();
            if (tipoClienteFornecedor == TipoClienteFornecedor.CLIENTE)
            {
                _service = new ClienteForncedorServiceFactory().PrepreClienteService(_context);
            }
            



            SetFormEvents();
            SetEnderecoDataGrid();
            SetContactoDataGrid();
            SetBancoDataGrid();
        }

        public void SetFormEvents() 
        {
            this.frmClienteFornecedor.Gravar += Gravar;
            this.frmClienteFornecedor.Novo += Novo;
            this.frmClienteFornecedor.Editar += Editar;
            this.frmClienteFornecedor.Listar += Listar;
            this.frmClienteFornecedor.ProvinciaChange += ProvinciaChange;
            this.frmClienteFornecedor.AdicionarBanco += AdicionarBanco;
            this.frmClienteFornecedor.AdicionarContacto += AdicionarContacto;
            this.frmClienteFornecedor.AdicionarEndereco += AdicionarEndereco;
        }
        public void SetEnderecoDataGrid()
        {
            this.frmClienteFornecedor.EnderecoDataGrid.Columns.Add("Id Tipo", "IdTipo");
            this.frmClienteFornecedor.EnderecoDataGrid.Columns.Add("Tipo", "Tipo");
            this.frmClienteFornecedor.EnderecoDataGrid.Columns.Add("Id Município", "IdMunicipio");
            this.frmClienteFornecedor.EnderecoDataGrid.Columns.Add("Município", "Município");
            this.frmClienteFornecedor.EnderecoDataGrid.Columns.Add("Endereço", "Endereco");
            this.frmClienteFornecedor.EnderecoDataGrid.Columns.Add("Rua", "Rua");
            this.frmClienteFornecedor.EnderecoDataGrid.Columns.Add("Bairro", "Bairro");
            this.frmClienteFornecedor.EnderecoDataGrid.Columns.Add("Cidade", "Cidade");
            this.frmClienteFornecedor.EnderecoDataGrid.Columns.Add("Referência", "Referencia");
        }
        public void SetContactoDataGrid()
        {
            this.frmClienteFornecedor.ContactoDataGrid.Columns.Add("Id Tipo", "IdTipo");
            this.frmClienteFornecedor.ContactoDataGrid.Columns.Add("Tipo", "Tipo");
            this.frmClienteFornecedor.ContactoDataGrid.Columns.Add("Fixo", "Telefone");
            this.frmClienteFornecedor.ContactoDataGrid.Columns.Add("Telemóvel", "Telemovel");
            this.frmClienteFornecedor.ContactoDataGrid.Columns.Add("E-mail", "Email");
            this.frmClienteFornecedor.ContactoDataGrid.Columns.Add("Site", "Site");
        }
        public void SetBancoDataGrid()
        {
            this.frmClienteFornecedor.BancoDataGrid.Columns.Add("ID Banco", "IdBanco");
            this.frmClienteFornecedor.BancoDataGrid.Columns.Add("Banco", "Banco");
            this.frmClienteFornecedor.BancoDataGrid.Columns.Add("Nº de Conta", "NumeroConta");
            this.frmClienteFornecedor.BancoDataGrid.Columns.Add("Iban", "Iban");
            this.frmClienteFornecedor.BancoDataGrid.Columns.Add("Agência", "Agencia");
            this.frmClienteFornecedor.BancoDataGrid.Columns.Add("Gestor", "Gestor");
            this.frmClienteFornecedor.BancoDataGrid.Columns.Add("E-mail", "Email");
            this.frmClienteFornecedor.BancoDataGrid.Columns.Add("E-mail Alternativo", "EmailAlternativo");
            this.frmClienteFornecedor.BancoDataGrid.Columns.Add("Telefone", "Telefone");
            this.frmClienteFornecedor.BancoDataGrid.Columns.Add("Telefone Alternativo", "TelefoneAlternativo");
        }
        private void AdicionarEndereco(object? sender, EventArgs e)
        {


            var tipoEndereco = (TipoEndereco)this.frmClienteFornecedor.TipoEnderecoComboBox.SelectedItem;
            var municipio = (Municipio)this.frmClienteFornecedor.MunicipioEnderecoComboBox.SelectedItem;
            string endereco = this.frmClienteFornecedor.EnderecoTextBox;
            string rua = this.frmClienteFornecedor.RuaTextBox;
            string bairro = this.frmClienteFornecedor.BairroTextBox;
            string cidade = this.frmClienteFornecedor.CidadeTextBox;
            string referencia = this.frmClienteFornecedor.ReferenciaTextBox;
            this.frmClienteFornecedor.EnderecoDataGrid.Rows.Add(
                tipoEndereco.Id,
                tipoEndereco._TipoEndereco,
                municipio.Id,
                municipio._Municipio,
                endereco,
                rua,
                bairro,
                cidade,
                referencia
                );
        }

        private void AdicionarContacto(object? sender, EventArgs e)
        {


            var tipoContacto = (TipoContacto)this.frmClienteFornecedor.TipoContactoComboBox.SelectedItem;
            string telefone = this.frmClienteFornecedor.TelefoneTextBox;
            string telemovel = this.frmClienteFornecedor.TelemovelTextBox;
            string email = this.frmClienteFornecedor.EmailTextBox;
            string site = this.frmClienteFornecedor.SiteTextBox;
            this.frmClienteFornecedor.ContactoDataGrid.Rows.Add(
                tipoContacto.Id,
                tipoContacto._TipoContacto,
                telefone,
                telemovel,
                email,
                site
                );
        }

        private void AdicionarBanco(object? sender, EventArgs e)
        {

            var banco = (Banco)this.frmClienteFornecedor.BancoComboBox.SelectedItem;
            string numeroConta = this.frmClienteFornecedor.NumeroContaTextBox;
            string iban = this.frmClienteFornecedor.IbanTextBox;
            string agencia = this.frmClienteFornecedor.AgenciaTextBox;
            string gestor = this.frmClienteFornecedor.GestorTextBox;
            string email = this.frmClienteFornecedor.EmailGestorTextBox;
            string emailAlternativo = this.frmClienteFornecedor.EmailAlternantivoGestorTextBox;
            string telefone = this.frmClienteFornecedor.TelefoneGestorTextBox;
            string telefoneAlternativo = this.frmClienteFornecedor.TelefoneAlternativoGestorTextBox;



            this.frmClienteFornecedor.BancoDataGrid.Rows.Add(
                banco.Id,
                banco._Banco,
                numeroConta,
                iban,
                agencia,
                gestor,
                email,
                emailAlternativo,
                telefone,
                telefoneAlternativo
                );
        }

        private void ProvinciaChange(object? sender, EventArgs e)
        {
            var provincia = (Provincia)this.frmClienteFornecedor.ProvinciaEnderecoComboBox.SelectedItem;
            this.frmClienteFornecedor.MunicipioEnderecoComboBox.DataSource = new MunicipioService(_context).findByProvinciaId(provincia.Id);
            this.frmClienteFornecedor.MunicipioEnderecoComboBox.DisplayMember = "_Municipio";
            this.frmClienteFornecedor.MunicipioEnderecoComboBox.ValueMember = "Id";
            //MessageBox.Show("Provincia: "+ provincia._Provincia + " | Id: " + provincia.Id);
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
            var clienteFornecedor = SetClienteFonecedorFromForm();
            _service.insert(clienteFornecedor);
            MessageBox.Show("Ok");
        }
        Cliente SetClienteFonecedorFromForm()
        {
            Cliente clienteFornecedor = new ClienteFornecedorFactory().PrepreCliente();

            clienteFornecedor.Bi = this.frmClienteFornecedor.BITextBox;
            clienteFornecedor.ContribuinteOrigem = this.frmClienteFornecedor.ContribuiteOrigemTextBox;
            clienteFornecedor.CodigoClienteFornecedor = this.frmClienteFornecedor.CodigoClienteFornecedorTextBox;
            clienteFornecedor.DataRegisto = DateTime.Now;
            clienteFornecedor.Desconto = this.frmClienteFornecedor.DescontoCheckBox;
            
            clienteFornecedor.EstadoCivil = (EstadoCivil)this.frmClienteFornecedor.EstadoCivilComboBox.SelectedValue;
            clienteFornecedor.Genero = (Genero)this.frmClienteFornecedor.GeneroComboBox.SelectedValue;
            clienteFornecedor.LimiteCredito = (this.frmClienteFornecedor.LimiteCreditoTextBox != null)
                || !(this.frmClienteFornecedor.LimiteCreditoTextBox.IsNullOrEmpty())
                ? double.Parse(this.frmClienteFornecedor.LimiteCreditoTextBox) : 0;
            clienteFornecedor.Nacionalidade = this.frmClienteFornecedor.NacionalidadeTextBox;
            clienteFornecedor.Naturalidade = this.frmClienteFornecedor.NaturalidadeTextBox;
            clienteFornecedor.Nif = this.frmClienteFornecedor.NumeroContribuinteTextBox;
            clienteFornecedor.Nome = this.frmClienteFornecedor.NomeTextBox;
            clienteFornecedor.NomeFiscal = this.frmClienteFornecedor.NomeFiscalTextBox;
            clienteFornecedor.Obs = this.frmClienteFornecedor.ObservacoTextBox;
            clienteFornecedor.PrazoEntrega = this.frmClienteFornecedor.PrazoEntregaTextBox != null ? int.Parse(this.frmClienteFornecedor.PrazoEntregaTextBox) : 0;
            clienteFornecedor.TipoContribuinte = (TipoContribuinte)this.frmClienteFornecedor.TipoContribuinteComboBox.SelectedValue;
            //clienteFornecedor.//TipoPessoa = this.frmClienteFornecedor.,
            clienteFornecedor.ValorDesconto = this.frmClienteFornecedor.ValorDescontoTextBox != null ? double.Parse(this.frmClienteFornecedor.ValorDescontoTextBox) : 0.0;
            clienteFornecedor.ContasBancarias = GetBancosFromDataGrid();
            clienteFornecedor.Contactos = GetContactosFromDataGrid();
            clienteFornecedor.Enderecos = GetEnderecsFromDataGrid();
            clienteFornecedor.PaisId = int.Parse(this.frmClienteFornecedor.cmbPaisDadoFiscalComboBox.SelectedValue.ToString());
            clienteFornecedor.RamoActividadeId = int.Parse(this.frmClienteFornecedor.RamoActividadeComboBox.SelectedValue.ToString());

            var validationContext = new ValidationContext(clienteFornecedor, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(clienteFornecedor, validationContext, validationResults, validateAllProperties: true))
            {
                foreach (var validationResult in validationResults)
                {
                    MessageBox.Show(validationResult.ErrorMessage);
                    clienteFornecedor = null;
                }
            }
            return clienteFornecedor;
        }
        public List<ContaBancaria> GetBancosFromDataGrid()
        {
            List<ContaBancaria> lstContaBancaria = new List<ContaBancaria>();
            int linhas = this.frmClienteFornecedor.BancoDataGrid.RowCount;
            if (linhas < 1)
            {
                return null;
            }
            this.frmClienteFornecedor.BancoDataGrid.AllowUserToAddRows = false;
            foreach (DataGridViewRow row in this.frmClienteFornecedor.BancoDataGrid.Rows)
            {
                var contaBancaria = new ContaBancaria()
                {
                    BancoId = int.Parse(row.Cells[0].Value.ToString()),
                    NumeroConta = row.Cells[2].Value.ToString(),
                    IBAN = row.Cells[3].Value.ToString(),
                    Agencia = row.Cells[4].Value.ToString(),
                    GestorConta = row.Cells[5].Value.ToString(),
                    EmailGestorConta = row.Cells[6].Value.ToString(),
                    EmailAlternativoGestorConta = row.Cells[7].Value.ToString(),
                    TelefoneGestorConta = row.Cells[8].Value.ToString(),
                    TelefoneAlternativoGestorConta = row.Cells[9].Value.ToString()

                };
                lstContaBancaria.Add(contaBancaria);
            }
            this.frmClienteFornecedor.BancoDataGrid.AllowUserToAddRows = true;
            return lstContaBancaria;
        }

        public List<Contacto> GetContactosFromDataGrid()
        {
            List<Contacto> lstContactos = new List<Contacto>();
            int linhas = this.frmClienteFornecedor.ContactoDataGrid.RowCount;
            if (linhas < 1)
            {
                return null;
            }
            this.frmClienteFornecedor.ContactoDataGrid.AllowUserToAddRows = false;
            foreach (DataGridViewRow row in this.frmClienteFornecedor.ContactoDataGrid.Rows)
            {
                var contacto = new Contacto()
                {
                    TipoContactoId = int.Parse(row.Cells[0].Value.ToString()),
                    Telefone = row.Cells[2].Value.ToString(),
                    Telemovel = row.Cells[3].Value.ToString(),
                    Email = row.Cells[4].Value.ToString(),
                    Site = row.Cells[5].Value.ToString(),
                    DataRegisto = DateTime.Now
                };
                lstContactos.Add(contacto);
            }
            this.frmClienteFornecedor.ContactoDataGrid.AllowUserToAddRows = true;
            return lstContactos;
        }

        public List<Endereco> GetEnderecsFromDataGrid()
        {
            List<Endereco> lstEnderecos = new List<Endereco>();
            int linhas = this.frmClienteFornecedor.EnderecoDataGrid.RowCount;
            if (linhas < 1)
            {
                return null;
            }
            this.frmClienteFornecedor.EnderecoDataGrid.AllowUserToAddRows = false;
            foreach (DataGridViewRow row in this.frmClienteFornecedor.EnderecoDataGrid.Rows)
            {
                var endereco = new Endereco()
                {
                    TipoEnderecoId = int.Parse(row.Cells[0].Value.ToString()),
                    MunicipioId = int.Parse(row.Cells[2].Value.ToString()),
                    _Endereco = row.Cells[4].Value.ToString(),
                    Rua = row.Cells[5].Value.ToString(),
                    Bairro = row.Cells[6].Value.ToString(),
                    Cidade = row.Cells[7].Value.ToString(),
                    Referencia = row.Cells[8].Value.ToString(),
                    DataRegisto = DateTime.Now
                };
                lstEnderecos.Add(endereco);
            }
            this.frmClienteFornecedor.EnderecoDataGrid.AllowUserToAddRows = true;
            return lstEnderecos;
        }
    }
}