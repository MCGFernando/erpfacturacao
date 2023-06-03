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
    public partial class FormMunicipio : Form
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
        public string CodigoMunicipioTextBox
        {
            get
            {
                return txtCodigoMunicipio.Text;
            }
            set
            {
                txtCodigoMunicipio.Text = value;
            }
        }
        public string MunicipioTextBox
        {
            get
            {
                return txtMunicipio.Text;
            }
            set
            {
                txtMunicipio.Text = value;
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
        
        public ComboBox ProvinciaComboBox
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

        public AdvancedDataGridView MunicipioAdvancedDataGridView
        {
            get
            {
                return dataGridMunicipio;
            }
            set
            {
                dataGridMunicipio = value;
            }
        }
        public event EventHandler Gravar;
        public event EventHandler Novo;
        public event EventHandler Editar;
        public event EventHandler Anular;
        public event EventHandler Listar;
        
        public FormMunicipio()
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

        private void FormMunicipio_Load(object sender, EventArgs e)
        {

        }
    }
}
