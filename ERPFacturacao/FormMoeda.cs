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
    public partial class FormMoeda : Form
    {
        public string IdTextBox
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
        public string SimboloTextBox
        {
            get
            {
                return txtSimbolo.Text;
            }
            set
            {
                txtSimbolo.Text = value;
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

        public DataGridView MoedaDataGrid
        {
            get
            {
                return dataGridMoeda;
            }
            set
            {
                dataGridMoeda = value;
            }
        }
        public event EventHandler Gravar;
        public event EventHandler Novo;
        public event EventHandler Editar;
        public event EventHandler Anular;
        public event EventHandler Listar;
        public FormMoeda()
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

        private void FormMoeda_Load(object sender, EventArgs e)
        {

        }
    }
}
