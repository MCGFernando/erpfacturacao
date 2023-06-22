using ERPFacturacao.Data;
using ERPFacturacao.Model;
using ERPFacturacao.Model.Enum;
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
            this.frmClienteFornecedor.ProvinciaChange += ProvinciaChange;
            this.frmClienteFornecedor.AdicionarBanco += AdicionarBanco;
            this.frmClienteFornecedor.AdicionarContacto += AdicionarContacto;
            this.frmClienteFornecedor.AdicionarEndereco += AdicionarEndereco;

            this.frmClienteFornecedor.EnderecoDataGrid.Columns.Add("Id Tipo", "IdTipo");
            this.frmClienteFornecedor.EnderecoDataGrid.Columns.Add("Tipo", "Tipo");
            this.frmClienteFornecedor.EnderecoDataGrid.Columns.Add("Id Município", "IdMunicipio");
            this.frmClienteFornecedor.EnderecoDataGrid.Columns.Add("Município", "Município");
            this.frmClienteFornecedor.EnderecoDataGrid.Columns.Add("Endereço", "Endereco");
            this.frmClienteFornecedor.EnderecoDataGrid.Columns.Add("Rua", "Rua");
            this.frmClienteFornecedor.EnderecoDataGrid.Columns.Add("Bairro", "Bairro");
            this.frmClienteFornecedor.EnderecoDataGrid.Columns.Add("Cidade", "Cidade");
            this.frmClienteFornecedor.EnderecoDataGrid.Columns.Add("Referência", "Referencia");

            this.frmClienteFornecedor.ContactoDataGrid.Columns.Add("Id Tipo", "IdTipo");
            this.frmClienteFornecedor.ContactoDataGrid.Columns.Add("Tipo", "Tipo");
            this.frmClienteFornecedor.ContactoDataGrid.Columns.Add("Fixo", "Telefone");
            this.frmClienteFornecedor.ContactoDataGrid.Columns.Add("Telemóvel", "Telemovel");
            this.frmClienteFornecedor.ContactoDataGrid.Columns.Add("E-mail", "Email");
            this.frmClienteFornecedor.ContactoDataGrid.Columns.Add("Site", "Site");

            this.frmClienteFornecedor.BancoDataGrid.Columns.Add("Sigla", "Sigla");
            this.frmClienteFornecedor.BancoDataGrid.Columns.Add("Banco", "Banco");
            this.frmClienteFornecedor.BancoDataGrid.Columns.Add("Agência", "Agencia");
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
            

            string sigla = this.frmClienteFornecedor.SiglaBancoTextBox;
            string banco = this.frmClienteFornecedor.BancoTextBox;
            string agencia = this.frmClienteFornecedor.AgenciaTextBox;
            
            this.frmClienteFornecedor.BancoDataGrid.Rows.Add(
                sigla,
                banco,
                agencia
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

            var clienteFornecedor = new ClienteFonecedor();

            clienteFornecedor.Bi = this.frmClienteFornecedor.BITextBox;
                clienteFornecedor.ContribuinteOrigem = this.frmClienteFornecedor.ContribuiteOrigemTextBox;
                clienteFornecedor.Cliente = true;
                clienteFornecedor.CodigoClienteFornecedor = this.frmClienteFornecedor.CodigoClienteFornecedorTextBox;
                clienteFornecedor.DataRegisto = DateTime.Now;
                clienteFornecedor.Desconto = this.frmClienteFornecedor.DescontoCheckBox;
                clienteFornecedor.Estado = Model.Enum.Estado.ACTIVO;
                clienteFornecedor.EstadoCivil = (EstadoCivil)this.frmClienteFornecedor.EstadoCivilComboBox.SelectedValue;
                clienteFornecedor.Genero = (Genero)this.frmClienteFornecedor.GeneroComboBox.SelectedValue;
            clienteFornecedor.LimiteCredito = this.frmClienteFornecedor.LimiteCreditoTextBox != null ? double.Parse(this.frmClienteFornecedor.LimiteCreditoTextBox) : 0.0;
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
                clienteFornecedor.Bancos = GetBancosFromDataGrid();
                clienteFornecedor.Contactos = GetContactosFromDataGrid();
                clienteFornecedor.Enderecos = GetEnderecsFromDataGrid();
                clienteFornecedor.PaisId = int.Parse(this.frmClienteFornecedor.cmbPaisDadoFiscalComboBox.SelectedValue.ToString());
                clienteFornecedor.RamoActividadeId = int.Parse( this.frmClienteFornecedor.RamoActividadeComboBox.SelectedValue.ToString());
                
                
            
            MessageBox.Show(clienteFornecedor.ToString());
        }

        public List<Banco> GetBancosFromDataGrid()
        {
            List<Banco> lstBancos = new List<Banco>();
            int linhas = this.frmClienteFornecedor.BancoDataGrid.RowCount;
            if (linhas<1)
            {
                return null;
            }
            this.frmClienteFornecedor.BancoDataGrid.AllowUserToAddRows = false;
            foreach (DataGridViewRow row in this.frmClienteFornecedor.BancoDataGrid.Rows)
            {
                var banco = new Banco()
                {
                    Sigla = row.Cells[0].Value.ToString(),
                    _Banco = row.Cells[1].Value.ToString(),
                    Agencia = row.Cells[2].Value.ToString()
                };
                lstBancos.Add(banco);
            }
            this.frmClienteFornecedor.BancoDataGrid.AllowUserToAddRows = true;
            return lstBancos;
        }
        
        public List<Contacto> GetContactosFromDataGrid()
        {
            List<Contacto> lstContactos = new List<Contacto>();
            int linhas = this.frmClienteFornecedor.ContactoDataGrid.RowCount;
            if (linhas<1)
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
                    TipoEnderecoId = int.Parse( row.Cells[0].Value.ToString()),
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