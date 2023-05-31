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
    public partial class FormProvincia : Form
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
        public string CodigoProvinciaTextBox
        {
            get
            {
                return txtCodigoProvincia.Text;
            }
            set
            {
                txtCodigoProvincia.Text = value;
            }
        }
        public string ProvinciaTextBox
        {
            get
            {
                return txtProvincia.Text;
            }
            set
            {
                txtProvincia.Text = value;
            }
        }
        public ComboBox PaisComboBox
        {
            get
            {
                return cmbPais;
            }
            set
            {
                cmbPais = value;
            }
        }
        public AdvancedDataGridView ProvinciaAdvancedDataGridView
        {
            get
            {
                return dataGridProvincia;
            }
            set
            {
                dataGridProvincia = value;
            }
        }
        public event EventHandler Gravar;
        public event EventHandler Novo;
        public event EventHandler Editar;
        public event EventHandler Anular;
        public event EventHandler Listar;
        public FormProvincia()
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

        private void FormProvincia_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
