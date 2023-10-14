using ERPFacturacao.Controller;
using ERPFacturacao.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPFacturacao
{
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void sectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSector frmSector = new FormSector();
            frmSector.MdiParent = this;
            frmSector.Show();
        }

        private void cargoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormCargo frmCargo = new FormCargo();
            frmCargo.MdiParent = this;
            frmCargo.Show();
            new CargoController(frmCargo);
        }

        private void formularioTesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPais frmPais = new FormPais();
            frmPais.MdiParent = this;
            frmPais.Show();
            new PaisController(frmPais);
        }

        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProvincia frmProvincia = new FormProvincia();
            frmProvincia.MdiParent = this;
            frmProvincia.Show();
            new ProvinciaController(frmProvincia);
        }

        private void municipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMunicipio frmMunicipio = new FormMunicipio();
            frmMunicipio.MdiParent = this;
            frmMunicipio.Show();
            new MunicipioController(frmMunicipio);
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ramoDeActividadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRamoActividade frmRamoActividade = new FormRamoActividade();
            frmRamoActividade.MdiParent = this;
            frmRamoActividade.Show();
            new RamoActividadeController(frmRamoActividade);
        }

        private void moedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMoeda frmMoeda = new FormMoeda();
            frmMoeda.MdiParent = this;
            frmMoeda.Show();
            new MoedaController(frmMoeda);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroClienteFornecedor frmClienteFornecedor = new FormCadastroClienteFornecedor();
            frmClienteFornecedor.MdiParent = this;
            frmClienteFornecedor.Show();
            new ClienteFornecedorController(frmClienteFornecedor, Model.Enum.TipoClienteFornecedor.CLIENTE);
        }

        private void tipoContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoContacto frmTipoContacto = new FormTipoContacto();
            frmTipoContacto.MdiParent = this;
            frmTipoContacto.Show();
            new TipoContactoController(frmTipoContacto);
        }

        private void tipoEnderecoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoEndereco frmTipoEndereco = new FormTipoEndereco();
            frmTipoEndereco.MdiParent = this;
            frmTipoEndereco.Show();
            new TipoEnderecoController(frmTipoEndereco);
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBanco frmBanco = new FormBanco();
            frmBanco.MdiParent = this;
            frmBanco.Show();
            new BancoController(frmBanco);
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroProductoServico formCadastroProductoServico = new FormCadastroProductoServico();
            formCadastroProductoServico.MdiParent = this;
            formCadastroProductoServico.Show();
            new ArtigoController(formCadastroProductoServico);
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroClienteFornecedor frmClienteFornecedor = new FormCadastroClienteFornecedor();
            frmClienteFornecedor.MdiParent = this;
            frmClienteFornecedor.Show();
            new ClienteFornecedorController(frmClienteFornecedor, Model.Enum.TipoClienteFornecedor.FORNECEDOR);
        }

        private void productosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormCadastroProductoServico formCadastroProductoServico = new FormCadastroProductoServico();
            formCadastroProductoServico.MdiParent = this;
            formCadastroProductoServico.Show();
            new ArtigoController(formCadastroProductoServico);
        }

        private void tipoDeDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoDocumento formTipoDocumento = new FormTipoDocumento();
            formTipoDocumento.MdiParent = this;
            formTipoDocumento.Show();
            new TipoDocumentoController(formTipoDocumento);
        }

        private void tipoIVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoIVA formTipoIVA = new FormTipoIVA();
            formTipoIVA.MdiParent = this;
            formTipoIVA.Show();
            new TipoIVAController(formTipoIVA);
        }

        private void tipoArtigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoArtigo formTipoArtigo = new FormTipoArtigo();
            formTipoArtigo.MdiParent = this;
            formTipoArtigo.Show();
            new TipoArtigoController(formTipoArtigo);
        }

        private void contaContabilAgregadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContaContabilAgragadora formContaContabilAgragadora = new FormContaContabilAgragadora();
            formContaContabilAgragadora.MdiParent = this;
            formContaContabilAgragadora.Show();
            new ContaContabilAgragadoraController(formContaContabilAgragadora);
        }

        private void contaContábilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContaContabil formContaContabil = new FormContaContabil();
            formContaContabil.MdiParent = this;
            formContaContabil.Show();
            new ContaContabilController(formContaContabil);
        }

        /*private void municipioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }*/
    }
}
