using ADGV;
using ERPFacturacao.Model.Enum;
using ERPFacturacao.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPFacturacao
{
    public partial class FormCadastroClienteFornecedor : Form
    {
        public string cliente { get; set; }
        public string CodigoClienteFornecedorTextBox
        {
            get
            {
                return txtCodigoClienteFornecedor.Text;
            }
            set
            {
                txtCodigoClienteFornecedor.Text = value;
            }
        }
        public string NomeTextBox
        {
            get
            {
                return txtNome.Text;
            }
            set
            {
                txtNome.Text = value;
            }
        }
        public string BITextBox
        {
            get
            {
                return txtBI.Text;
            }
            set
            {
                txtBI.Text = value;
            }
        }
        public string NacionalidadeTextBox
        {
            get
            {
                return txtNacionalidade.Text;
            }
            set
            {
                txtNacionalidade.Text = value;
            }
        }
        public string NaturalidadeTextBox
        {
            get
            {
                return txtNaturalidade.Text;
            }
            set
            {
                txtNaturalidade.Text = value;
            }
        }
        public string ValorDescontoTextBox
        {
            get
            {
                return txtValorDesconto.Text;
            }
            set
            {
                txtValorDesconto.Text = value;
            }
        }
        public string LimiteCreditoTextBox
        {
            get
            {
                return txtLimiteCredito.Text;
            }
            set
            {
                txtLimiteCredito.Text = value;
            }
        }
        public string PrazoEntregaTextBox
        {
            get
            {
                return txtPrazoEntrega.Text;
            }
            set
            {
                txtPrazoEntrega.Text = value;
            }
        }
        public string NomeFiscalTextBox
        {
            get
            {
                return txtNomeFiscal.Text;
            }
            set
            {
                txtNomeFiscal.Text = value;
            }
        }
        public string NumeroContribuinteTextBox
        {
            get
            {
                return txtNumeroCotribuinte.Text;
            }
            set
            {
                txtNumeroCotribuinte.Text = value;
            }
        }
        public string ContribuiteOrigemTextBox
        {
            get
            {
                return txtContribuinteOrigem.Text;
            }
            set
            {
                txtContribuinteOrigem.Text = value;
            }
        }
        public string EnderecoTextBox
        {
            get
            {
                return txtEndereco.Text;
            }
            set
            {
                txtEndereco.Text = value;
            }
        }
        public string RuaTextBox
        {
            get
            {
                return txtRua.Text;
            }
            set
            {
                txtRua.Text = value;
            }
        }
        public string BairroTextBox
        {
            get
            {
                return txtBairro.Text;
            }
            set
            {
                txtBairro.Text = value;
            }
        }
        public string CidadeTextBox
        {
            get
            {
                return txtCidade.Text;
            }
            set
            {
                txtCidade.Text = value;
            }
        }
        public string ReferenciaTextBox
        {
            get
            {
                return txtReferencia.Text;
            }
            set
            {
                txtReferencia.Text = value;
            }
        }
        public string TelefoneTextBox
        {
            get
            {
                return txtTelefone.Text;
            }
            set
            {
                txtTelefone.Text = value;
            }
        }
        public string TelemovelTextBox
        {
            get
            {
                return txtTelemovel.Text;
            }
            set
            {
                txtTelemovel.Text = value;
            }
        }
        public string EmailTextBox
        {
            get
            {
                return txtEmail.Text;
            }
            set
            {
                txtEmail.Text = value;
            }
        }
        public string SiteTextBox
        {
            get
            {
                return txtSite.Text;
            }
            set
            {
                txtSite.Text = value;
            }
        }
        public string SiglaBancoTextBox
        {
            get
            {
                return txtSiglaBanco.Text;
            }
            set
            {
                txtSiglaBanco.Text = value;
            }
        }
        public string BancoTextBox
        {
            get
            {
                return txtBanco.Text;
            }
            set
            {
                txtBanco.Text = value;
            }
        }
        public string AgenciaTextBox
        {
            get
            {
                return txtAgencia.Text;
            }
            set
            {
                txtAgencia.Text = value;
            }
        }
        public string ObservacoTextBox
        {
            get
            {
                return txtObservacao.Text;
            }
            set
            {
                txtObservacao.Text = value;
            }
        }
        /**/
        public string NascimentoDatePicker
        {
            get
            {
                return datePickerNascimento.Value.ToString("d");
            }
            set
            {
                datePickerNascimento.Value = DateTime.ParseExact(value, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            }
        }


        /**/
        public bool DescontoCheckBox
        {
            get
            {
                return chkDesconto.Checked;
            }
            set
            {
                chkDesconto.Checked = value;
            }
        }
        public bool EstadoCheckBox
        {
            get
            {
                return chkEstado.Checked;
            }
            set
            {
                chkEstado.Checked = value;
            }
        }

        /**/
        public ComboBox GeneroComboBox
        {
            get
            {
                return cmbGenero;
            }
            set
            {
                cmbGenero = value;
            }
        }
        public ComboBox EstadoCivilComboBox
        {
            get
            {
                return cmbEstadoCivil;
            }
            set
            {
                cmbEstadoCivil = value;
            }
        }
        public ComboBox TipoContribuinteComboBox
        {
            get
            {
                return cmbTipoContribuinte;
            }
            set
            {
                cmbTipoContribuinte = value;
            }
        }
       
        public ComboBox RamoActividadeComboBox
        {
            get
            {
                return cmbRamoActividade;
            }
            set
            {
                cmbRamoActividade = value;
            }
        }
        public ComboBox cmbPaisDadoFiscalComboBox
        {
            get
            {
                return cmbPaisDadoFiscal;
            }
            set
            {
                cmbPaisDadoFiscal = value;
            }
        }
        public ComboBox TipoRegimeComboBox
        {
            get
            {
                return cmbTipoRegime;
            }
            set
            {
                cmbTipoRegime = value;
            }
        }
        public ComboBox MoedaComboBox
        {
            get
            {
                return cmbMoeda;
            }
            set
            {
                cmbMoeda = value;
            }
        }
        public ComboBox TipoEnderecoComboBox
        {
            get
            {
                return cmbTipoEndereco;
            }
            set
            {
                cmbTipoEndereco = value;
            }
        }
        public ComboBox TipoContactoComboBox
        {
            get
            {
                return cmbTipoContacto;
            }
            set
            {
                cmbTipoContacto = value;
            }
        }
        public ComboBox ProvinciaEnderecoComboBox
        {
            get
            {
                return cmbProvincia;
            }
            set
            {
                cmbProvincia = value;
            }
        }
        
        public ComboBox MunicipioEnderecoComboBox
        {
            get
            {
                return cmbMunicipio;
            }
            set
            {
                cmbMunicipio = value;
            }
        }

        public AdvancedDataGridView EnderecoDataGrid
        {
            get
            {
                return dataGridEndereco;
            }
            set
            {
                dataGridEndereco = value;
            }
        }
        public AdvancedDataGridView ContactoDataGrid
        {
            get
            {
                return dataGridContacto;
            }
            set
            {
                dataGridContacto = value;
            }
        }
        public AdvancedDataGridView BancoDataGrid
        {
            get
            {
                return dataGridBanco;
            }
            set
            {
                dataGridBanco = value;
            }
        }


        public event EventHandler Gravar;
        public event EventHandler Novo;
        public event EventHandler Editar;
        public event EventHandler Anular;
        public event EventHandler Listar;
        public event EventHandler ProvinciaChange;
        public event EventHandler AdicionarBanco;
        public event EventHandler AdicionarEndereco;
        public event EventHandler AdicionarContacto;
        public FormCadastroClienteFornecedor()
        {
            InitializeComponent();
            cmbGenero.DataSource = Enum.GetValues(typeof(Genero));
            cmbEstadoCivil.DataSource = Enum.GetValues(typeof(EstadoCivil));
            cmbTipoContribuinte.DataSource = Enum.GetValues(typeof(TipoContribuinte));
            cmbPaisDadoFiscalComboBox.DataSource = new PaisService(new Data.EFContext()).findAll();
            cmbPaisDadoFiscalComboBox.DisplayMember = "_Pais";
            cmbPaisDadoFiscalComboBox.ValueMember = "Id";
            RamoActividadeComboBox.DataSource = new RamoActividadeService(new Data.EFContext()).findAll();
            RamoActividadeComboBox.DisplayMember = "Ramo";
            RamoActividadeComboBox.ValueMember = "Id";   
            MoedaComboBox.DataSource = new MoedaService(new Data.EFContext()).findAll();
            MoedaComboBox.DisplayMember = "_Moeda";
            MoedaComboBox.ValueMember= "Id";
            TipoContactoComboBox.DataSource = new TipoContactoService(new Data.EFContext()).findAll();
            TipoContactoComboBox.DisplayMember = "_TipoContacto";
            TipoContactoComboBox.ValueMember = "Id";
            TipoEnderecoComboBox.DataSource = new TipoEnderecoService(new Data.EFContext()).findAll();
            TipoEnderecoComboBox.DisplayMember = "_TipoEndereco";
            TipoEnderecoComboBox.ValueMember = "Id";
            ProvinciaEnderecoComboBox.DataSource = new ProvinciaService(new Data.EFContext()).findByPaisId(1);
            ProvinciaEnderecoComboBox.DisplayMember = "_Provincia";
            ProvinciaEnderecoComboBox.ValueMember = "Id";

            btnGravar.Click += (sender, e) =>
            {
                Gravar?.Invoke(sender, e);
            };
            btnNovo.Click += (sender, e) => Novo?.Invoke(sender, e);
            btnEditar.Click += (sender, e) => Editar?.Invoke(sender, e);
            btnAnular.Click += (sender, e) => Anular?.Invoke(sender, e);
            btnListar.Click += (sender, e) => Listar?.Invoke(sender, e);
            cmbProvincia.SelectedIndexChanged += (sender, e) => ProvinciaChange?.Invoke(sender, e);
            btnAddBanco.Click += (sender, e) => AdicionarBanco?.Invoke(sender, e);
            btnAddContacto.Click += (sender, e) => AdicionarContacto?.Invoke(sender, e);
            btnAddEndereco.Click += (sender, e) => AdicionarEndereco?.Invoke(sender, e);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
