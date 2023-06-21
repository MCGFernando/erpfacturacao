using ERPFacturacao.Data;
using ERPFacturacao.Model;
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
            this.frmClienteFornecedor.EnderecoDataGrid.Rows.Add(
                tipoEndereco.Id,
                tipoEndereco._TipoEndereco,
                municipio.Id,
                municipio._Municipio,
                endereco
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
            throw new NotImplementedException();
        }
    }
}