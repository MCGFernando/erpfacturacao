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
    public partial class FormTipoArtigo : Form
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
        public string TipoArtigoTextBox
        {
            get
            {
                return txtTipoArtigo.Text;
            }
            set
            {
                txtTipoArtigo.Text = value;
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
        public ComboBox TipoFiscalArtigoComboBox
        {
            get
            {
                return cmbTipoFiscalArtigo;
            }
            set
            {
                cmbTipoFiscalArtigo = value;
            }
        }
        public AdvancedDataGridView tblTipoArtigo
        {
            get
            {
                return dataGridTipoArtigo;
            }
            set
            {
                dataGridTipoArtigo = value;
            }
        }
        public event EventHandler Gravar;
        public event EventHandler Novo;
        public event EventHandler Editar;
        public event EventHandler Anular;
        public event EventHandler Listar;
        public FormTipoArtigo()
        {
            InitializeComponent();
            TipoFiscalArtigoComboBox.DataSource = Enum.GetValues(typeof(Model.Enum.TipoFiscalArtigo));
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
