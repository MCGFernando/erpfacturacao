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
    public partial class FormBanco : Form
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
        public string SiglaTextBox
        {
            get
            {
                return txtSiglaBanco.Text;
            }
            set
            {
                txtSiglaBanco.Text = value;
            }
        }public string BancoTextBox
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
        public FormBanco()
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
    }
}
