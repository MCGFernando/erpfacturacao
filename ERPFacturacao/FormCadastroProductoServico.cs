﻿using ERPFacturacao.Model;
using ERPFacturacao.Model.Enum;
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
    public partial class FormCadastroProductoServico : Form
    {
        public event EventHandler Gravar;
        public event EventHandler Novo;
        public event EventHandler Editar;
        public event EventHandler Anular;
        public event EventHandler Listar;

        public string CodigoArtidoTextBox
        {
            get
            {
                return txtCodigoArtigo.Text;
            }
            set
            {
                txtCodigoArtigo.Text = value;
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
        public string CodigoBarraTextBox
        {
            get
            {
                return txtCodigoBarra.Text;
            }
            set
            {
                txtCodigoBarra.Text = value;
            }
        }
        public string PrecoCompraTextBox
        {
            get
            {
                return txtPrecoCompra.Text;
            }
            set
            {
                txtPrecoCompra.Text = value;
            }
        }
        public string TaxaLucroTextBox
        {
            get
            {
                return txtTaxaLucro.Text;
            }
            set
            {
                txtTaxaLucro.Text = value;
            }
        }
        public string PrecoVendaTextBox
        {
            get
            {
                return txtPrecoVenda.Text;
            }
            set
            {
                txtPrecoVenda.Text = value;
            }
        }
        public string GarantiaTextBox
        {
            get
            {
                return txtGarantia.Text;
            }
            set
            {
                txtGarantia.Text = value;
            }
        }
        public string DescontoTextBox
        {
            get
            {
                return txtDesconto.Text;
            }
            set
            {
                txtDesconto.Text = value;
            }
        }
        /**/
        public bool ActivoCheckBox
        {
            get
            {
                return chkActivo.Checked;
            }
            set
            {
                chkActivo.Checked = value;
            }
        }
        public bool DevolucaoCheckBox
        {
            get
            {
                return chkDevolucao.Checked;
            }
            set
            {
                chkDevolucao.Checked = value;
            }
        }
        public bool MovimentaCheckBox
        {
            get
            {
                return chkMovimentaStock.Checked;
            }
            set
            {
                chkMovimentaStock.Checked = value;
            }
        }
        /**/
        public ComboBox TipoArtigoComboBox
        {
            get
            {
                return cmbTipoArtigo;
            }
            set
            {
                cmbTipoArtigo = value;
            }
        }
        public ComboBox TipoIVAComboBox
        {
            get
            {
                return cmbTipoIVA;
            }
            set
            {
                cmbTipoIVA = value;
            }
        }
        public ComboBox FornecedorComboBox
        {
            get
            {
                return cmbFornecedor;
            }
            set
            {
                cmbFornecedor = value;
            }
        }
        public ComboBox CategoriaArtigoComboBox
        {
            get
            {
                return cmbCategoriaArtigo;
            }
            set
            {
                cmbCategoriaArtigo = value;
            }
        }
        public ComboBox FamiliaArtigoComboBox
        {
            get
            {
                return cmbFamiliaArtigo;
            }
            set
            {
                cmbFamiliaArtigo = value;
            }
        }
        public ComboBox MarcaComboBox
        {
            get
            {
                return cmbMarca;
            }
            set
            {
                cmbMarca = value;
            }
        }
        public ComboBox ModeloComboBox
        {
            get
            {
                return cmbModelo;
            }
            set
            {
                cmbModelo = value;
            }
        }
        public FormCadastroProductoServico()
        {
            InitializeComponent();
            //cmbTipoArtigo.DataSource = Enum.GetValues(typeof(TipoFiscalArtigo));
            cmbTipoArtigo.DataSource = new TipoArtigoService(new Data.EFContext()).findAll();
            cmbTipoArtigo.DisplayMember = "_TipoArtigo";
            cmbTipoArtigo.ValueMember = "Id";

            FornecedorComboBox.DataSource = new FornecedorService(new Data.EFContext()).findAll();
            FornecedorComboBox.DisplayMember = "Nome";
            FornecedorComboBox.ValueMember = "Id";

            TipoIVAComboBox.DataSource = new TipoIVAService(new Data.EFContext()).findAll();
            TipoIVAComboBox.DisplayMember = "IVA";
            TipoIVAComboBox.ValueMember = "Id";

            CategoriaArtigoComboBox.DataSource = new CategoriaArtigoService(new Data.EFContext()).findAll();
            CategoriaArtigoComboBox.DisplayMember = "Categoria";
            CategoriaArtigoComboBox.ValueMember = "Id";

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
