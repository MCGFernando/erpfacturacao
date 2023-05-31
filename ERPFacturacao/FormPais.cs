using ADGV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPFacturacao
{
    public partial class FormPais : Form
    {
        public string IDTextBox
        {
            get
            {
                return txtId.Text;
            }
            set
            {
                txtId.Text = value;
            }
        }
        public string CodigoPaisTextBox
        {
            get
            {
                return txtCodigoPais.Text;
            }
            set
            {
                txtCodigoPais .Text = value;
            }
        }
        public string PaisTextBox
        {
            get
            {
                return txtPais.Text;
            }
            set
            {
                txtPais.Text = value;
            }
        }
        public string CodigoMoedaTextBox
        {
            get
            {
                return txtCodigoMoeda.Text;
            }
            set
            {
                txtCodigoMoeda.Text = value;
            }
        }
        public string MoedaTextBox
        {
            get
            {
                return txtMoeda.Text;
            }
            set
            {
                txtMoeda.Text = value;
            }
        }
        public string CodigoTelefoniaTextBox
        {
            get
            {
                return txtCodigoTelefonia.Text;
            }
            set
            {
                txtCodigoTelefonia.Text = value;
            }
        }
        public string DominioTopoTextBox
        {
            get
            {
                return txtDominioTopo.Text;
            }
            set
            {
                txtDominioTopo.Text = value;
            }
        }
        public AdvancedDataGridView PaisAdvancedDataGridView
        {
            get
            {
                return dataGridPais;
            }
            set
            {
                dataGridPais = value;
            }
        }
        public event EventHandler Gravar;
        public event EventHandler Novo;
        public event EventHandler Editar;
        public event EventHandler Anular;
        public event EventHandler Listar;
        public FormPais()
        {
            InitializeComponent();
            btnGravar.Click += (sender, e) =>
            {
                Gravar?.Invoke(sender, e);
            };
            btnNovo.Click += (sender, e) => Novo?.Invoke(sender, e);
            btnEditar.Click += (sender, e) => Editar?.Invoke(sender, e);
            btnAnular.Click += (sender, e) => Anular?.Invoke(sender, e);
            btnListar.Click += (sender, e) => Listar?.Invoke(sender, e);
        }

        private void FormPais_Load(object sender, EventArgs e)
        {

        }
    }
}
