using ERPFacturacao.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ERPFacturacao
{
    public partial class FormCargo : Form
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
        public string SiglaTextBox
        {
            get
            {
                return txtSigla.Text;
            }
            set
            {
                txtSigla.Text = value;
            }
        }
        public string CargoTextBox
        {
            get
            {
                return txtCargo.Text;
            }
            set
            {
                txtCargo.Text = value;
            }
        }
        public DataGridView tblCargo
        {
            get
            {
                return dataGridCargo;
            }
            set
            {
                dataGridCargo = value;
            }
        }
        public event EventHandler Gravar;
        public event EventHandler Novo;
        public event EventHandler Editar;
        public event EventHandler Anular;
        public event EventHandler Listar;
        public FormCargo()
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormCargo_Load(object sender, EventArgs e)
        {

        }
    }
}
