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
    public partial class FormTipoEndereco : Form
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
        public string TipoEnderecoTextBox
        {
            get
            {
                return txtTipoEndereco.Text;
            }
            set
            {
                txtTipoEndereco.Text = value;
            }
        }
        public AdvancedDataGridView TipoEnderecoDataGrid
        {
            get
            {
                return dataGridTipoEndereco;
            }
            set
            {
                dataGridTipoEndereco = value;
            }
        }
        public event EventHandler Gravar;
        public event EventHandler Novo;
        public event EventHandler Editar;
        public event EventHandler Anular;
        public event EventHandler Listar;
        public FormTipoEndereco()
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
