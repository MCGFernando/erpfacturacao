using ADGV;
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
    
    public partial class FormContaContabilAgragadora : Form
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
        public AdvancedDataGridView tblContaContabilAgregadora
        {
            get
            {
                return dataGridContaContabilAgregadora;
            }
            set
            {
                dataGridContaContabilAgregadora = value;
            }
        }
        public event EventHandler Gravar;
        public event EventHandler Novo;
        public event EventHandler Editar;
        public event EventHandler Anular;
        public event EventHandler Listar;
        public FormContaContabilAgragadora()
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
        }
    }
}
