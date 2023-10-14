using ADGV;
using ERPFacturacao.Controller;
using ERPFacturacao.Service;
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
    public partial class FormContaContabil : Form
    {
        public string IDTextBox
        {
            get
            {
                return txtID.Text;
            }
            set
            {
                txtID.Text = value;
            }
        }
        public string CodigoTextBox
        {
            get
            {
                return txtCodigo.Text;
            }
            set
            {
                txtCodigo.Text = value;
            }
        }
        public string DescricaoTextBox
        {
            get
            {
                return txtDescricao.Text;
            }
            set
            {
                txtDescricao.Text = value;
            }
        }
        public ComboBox ClasseContabilComboBox
        {
            get
            {
                return cmbClasseContabil;
            }
            set
            {
                cmbClasseContabil = value;
            }
        }
        public ComboBox ContaContabilAgregadoraComboBox
        {
            get
            {
                return cmbContaContabilAgregadora;
            }
            set
            {
                cmbContaContabilAgregadora = value;
            }
        }
        public AdvancedDataGridView tblContaContabil
        {
            get
            {
                return dataGridContaContabil;
            }
            set
            {
                dataGridContaContabil = value;
            }
        }
        public event EventHandler Gravar;
        public event EventHandler Novo;
        public event EventHandler Editar;
        public event EventHandler Anular;
        public event EventHandler Listar;
        public event EventHandler ClasseContabilChanged;
        public event EventHandler ContaContabilAgregadoraChanged;
        public FormContaContabil()
        {
            InitializeComponent();
            ClasseContabilComboBox.DataSource = new ClasseContabilService(new Data.EFContext()).findAll();
            ClasseContabilComboBox.DisplayMember = "Descricao";
            ClasseContabilComboBox.ValueMember = "Id";   
            btnGravar.Click += (sender, e) =>
            {
                Gravar?.Invoke(sender, e);
            };
            btnNovo.Click += (sender, e) => Novo?.Invoke(sender, e);
            btnEditar.Click += (sender, e) => Editar?.Invoke(sender, e);
            btnAnular.Click += (sender, e) => Anular?.Invoke(sender, e);
            btnListar.Click += (sender, e) => Listar?.Invoke(sender, e);
            ClasseContabilComboBox.SelectedIndexChanged += (sender, e) => ClasseContabilChanged?.Invoke(sender, e);
            ContaContabilAgregadoraComboBox.SelectedIndexChanged += (sender, e) => ContaContabilAgregadoraChanged?.Invoke(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}
