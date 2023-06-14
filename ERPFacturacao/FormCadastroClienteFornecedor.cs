using ERPFacturacao.Model.Enum;
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
    public partial class FormCadastroClienteFornecedor : Form
    {
        public ComboBox GeneroComboBox
        {
            get
            {
                return cmbGenero;
            }
            set
            {
                cmbGenero = value;
            }
        }
        public ComboBox EstadoCivilComboBox
        {
            get
            {
                return cmbEstadoCivil;
            }
            set
            {
                cmbEstadoCivil = value;
            }
        }
        public ComboBox TipoContribuinteComboBox
        {
            get
            {
                return cmbTipoContribuinte;
            }
            set
            {
                cmbTipoContribuinte = value;
            }
        }
        public FormCadastroClienteFornecedor()
        {
            InitializeComponent();
            cmbGenero.DataSource = Enum.GetValues(typeof(Genero));
            cmbEstadoCivil.DataSource = Enum.GetValues(typeof(EstadoCivil));
            cmbTipoContribuinte.DataSource = Enum.GetValues(typeof(TipoContribuinte));
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
