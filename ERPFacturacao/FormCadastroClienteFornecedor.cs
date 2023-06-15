using ERPFacturacao.Model.Enum;
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
        public FormCadastroClienteFornecedor()
        {
            InitializeComponent();
            cmbGenero.DataSource = Enum.GetValues(typeof(Genero));
            cmbEstadoCivil.DataSource = Enum.GetValues(typeof(EstadoCivil));
            cmbTipoContribuinte.DataSource = Enum.GetValues(typeof(TipoContribuinte));
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
