namespace ERPFacturacao
{
    partial class FormCadastroProductoServico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProductoServico));
            toolStrip1 = new ToolStrip();
            btnGravar = new ToolStripButton();
            btnNovo = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnAnular = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnListar = new ToolStripButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cmbTipoIVA = new ComboBox();
            label12 = new Label();
            cmbFornecedor = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            txtGarantia = new TextBox();
            chkDevolucao = new CheckBox();
            chkMovimentaStock = new CheckBox();
            label9 = new Label();
            txtDesconto = new TextBox();
            cmbModelo = new ComboBox();
            label8 = new Label();
            cmbMarca = new ComboBox();
            label7 = new Label();
            cmbFamiliaArtigo = new ComboBox();
            label6 = new Label();
            cmbCategoriaArtigo = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            txtPrecoVenda = new TextBox();
            label3 = new Label();
            txtTaxaLucro = new TextBox();
            label2 = new Label();
            txtPrecoCompra = new TextBox();
            label1 = new Label();
            txtCodigoBarra = new TextBox();
            cmbTipoArtigo = new ComboBox();
            label30 = new Label();
            label24 = new Label();
            txtCodigoArtigo = new TextBox();
            chkActivo = new CheckBox();
            label23 = new Label();
            txtDescricao = new TextBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnGravar, btnNovo, btnEditar, btnAnular, toolStripSeparator1, btnListar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnGravar
            // 
            btnGravar.Image = (Image)resources.GetObject("btnGravar.Image");
            btnGravar.ImageTransparentColor = Color.Magenta;
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(61, 22);
            btnGravar.Text = "Gravar";
            // 
            // btnNovo
            // 
            btnNovo.Image = (Image)resources.GetObject("btnNovo.Image");
            btnNovo.ImageTransparentColor = Color.Magenta;
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(56, 22);
            btnNovo.Text = "Novo";
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(57, 22);
            btnEditar.Text = "Editar";
            // 
            // btnAnular
            // 
            btnAnular.Image = (Image)resources.GetObject("btnAnular.Image");
            btnAnular.ImageTransparentColor = Color.Magenta;
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(62, 22);
            btnAnular.Text = "Anular";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnListar
            // 
            btnListar.Image = (Image)resources.GetObject("btnListar.Image");
            btnListar.ImageTransparentColor = Color.Magenta;
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(55, 22);
            btnListar.Text = "Listar";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 422);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cmbTipoIVA);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(cmbFornecedor);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(txtGarantia);
            tabPage1.Controls.Add(chkDevolucao);
            tabPage1.Controls.Add(chkMovimentaStock);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(txtDesconto);
            tabPage1.Controls.Add(cmbModelo);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(cmbMarca);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(cmbFamiliaArtigo);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(cmbCategoriaArtigo);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtPrecoVenda);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtTaxaLucro);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtPrecoCompra);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtCodigoBarra);
            tabPage1.Controls.Add(cmbTipoArtigo);
            tabPage1.Controls.Add(label30);
            tabPage1.Controls.Add(label24);
            tabPage1.Controls.Add(txtCodigoArtigo);
            tabPage1.Controls.Add(chkActivo);
            tabPage1.Controls.Add(label23);
            tabPage1.Controls.Add(txtDescricao);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 394);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Geral";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbTipoIVA
            // 
            cmbTipoIVA.FormattingEnabled = true;
            cmbTipoIVA.Location = new Point(264, 197);
            cmbTipoIVA.Name = "cmbTipoIVA";
            cmbTipoIVA.Size = new Size(210, 23);
            cmbTipoIVA.TabIndex = 76;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(264, 179);
            label12.Name = "label12";
            label12.Size = new Size(66, 15);
            label12.TabIndex = 75;
            label12.Text = "Tipo de IVA";
            // 
            // cmbFornecedor
            // 
            cmbFornecedor.FormattingEnabled = true;
            cmbFornecedor.Location = new Point(254, 79);
            cmbFornecedor.Name = "cmbFornecedor";
            cmbFornecedor.Size = new Size(210, 23);
            cmbFornecedor.TabIndex = 74;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(254, 61);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 73;
            label11.Text = "Fornecedor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(541, 251);
            label10.Name = "label10";
            label10.Size = new Size(150, 15);
            label10.TabIndex = 72;
            label10.Text = "Garantia  dias p. Devolução";
            // 
            // txtGarantia
            // 
            txtGarantia.Location = new Point(541, 269);
            txtGarantia.Name = "txtGarantia";
            txtGarantia.Size = new Size(211, 23);
            txtGarantia.TabIndex = 71;
            // 
            // chkDevolucao
            // 
            chkDevolucao.AutoSize = true;
            chkDevolucao.Location = new Point(541, 222);
            chkDevolucao.Name = "chkDevolucao";
            chkDevolucao.Size = new Size(82, 19);
            chkDevolucao.TabIndex = 70;
            chkDevolucao.Text = "Devolução";
            chkDevolucao.UseVisualStyleBackColor = true;
            // 
            // chkMovimentaStock
            // 
            chkMovimentaStock.AutoSize = true;
            chkMovimentaStock.Location = new Point(541, 197);
            chkMovimentaStock.Name = "chkMovimentaStock";
            chkMovimentaStock.Size = new Size(119, 19);
            chkMovimentaStock.TabIndex = 69;
            chkMovimentaStock.Text = "Movimenta Stock";
            chkMovimentaStock.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(541, 345);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 68;
            label9.Text = "Desconto";
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(541, 363);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(211, 23);
            txtDesconto.TabIndex = 67;
            // 
            // cmbModelo
            // 
            cmbModelo.FormattingEnabled = true;
            cmbModelo.Location = new Point(9, 345);
            cmbModelo.Name = "cmbModelo";
            cmbModelo.Size = new Size(210, 23);
            cmbModelo.TabIndex = 66;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 327);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 65;
            label8.Text = "Modelo";
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(9, 295);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(210, 23);
            cmbMarca.TabIndex = 64;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 277);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 63;
            label7.Text = "Marca";
            // 
            // cmbFamiliaArtigo
            // 
            cmbFamiliaArtigo.FormattingEnabled = true;
            cmbFamiliaArtigo.Location = new Point(9, 246);
            cmbFamiliaArtigo.Name = "cmbFamiliaArtigo";
            cmbFamiliaArtigo.Size = new Size(210, 23);
            cmbFamiliaArtigo.TabIndex = 62;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 228);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 61;
            label6.Text = "Família";
            // 
            // cmbCategoriaArtigo
            // 
            cmbCategoriaArtigo.FormattingEnabled = true;
            cmbCategoriaArtigo.Location = new Point(9, 197);
            cmbCategoriaArtigo.Name = "cmbCategoriaArtigo";
            cmbCategoriaArtigo.Size = new Size(210, 23);
            cmbCategoriaArtigo.TabIndex = 60;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 179);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 59;
            label5.Text = "Categorias";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(490, 112);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 58;
            label4.Text = "Preço de Venda";
            // 
            // txtPrecoVenda
            // 
            txtPrecoVenda.Location = new Point(490, 130);
            txtPrecoVenda.Name = "txtPrecoVenda";
            txtPrecoVenda.Size = new Size(211, 23);
            txtPrecoVenda.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 112);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 56;
            label3.Text = "Taxa de Lucro";
            // 
            // txtTaxaLucro
            // 
            txtTaxaLucro.Location = new Point(254, 130);
            txtTaxaLucro.Name = "txtTaxaLucro";
            txtTaxaLucro.Size = new Size(211, 23);
            txtTaxaLucro.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 112);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 54;
            label2.Text = "Preço de Compra";
            // 
            // txtPrecoCompra
            // 
            txtPrecoCompra.Location = new Point(6, 130);
            txtPrecoCompra.Name = "txtPrecoCompra";
            txtPrecoCompra.Size = new Size(211, 23);
            txtPrecoCompra.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(490, 61);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 52;
            label1.Text = "Código de Barras";
            // 
            // txtCodigoBarra
            // 
            txtCodigoBarra.Location = new Point(490, 79);
            txtCodigoBarra.Name = "txtCodigoBarra";
            txtCodigoBarra.Size = new Size(211, 23);
            txtCodigoBarra.TabIndex = 51;
            // 
            // cmbTipoArtigo
            // 
            cmbTipoArtigo.FormattingEnabled = true;
            cmbTipoArtigo.Location = new Point(6, 79);
            cmbTipoArtigo.Name = "cmbTipoArtigo";
            cmbTipoArtigo.Size = new Size(210, 23);
            cmbTipoArtigo.TabIndex = 50;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(6, 61);
            label30.Name = "label30";
            label30.Size = new Size(82, 15);
            label30.TabIndex = 49;
            label30.Text = "Tipo de Artigo";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(5, 5);
            label24.Name = "label24";
            label24.Size = new Size(46, 15);
            label24.TabIndex = 39;
            label24.Text = "Código";
            // 
            // txtCodigoArtigo
            // 
            txtCodigoArtigo.Location = new Point(5, 23);
            txtCodigoArtigo.Name = "txtCodigoArtigo";
            txtCodigoArtigo.Size = new Size(92, 23);
            txtCodigoArtigo.TabIndex = 38;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(707, 25);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(74, 19);
            chkActivo.TabIndex = 37;
            chkActivo.Text = "Desativar";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(103, 5);
            label23.Name = "label23";
            label23.Size = new Size(58, 15);
            label23.TabIndex = 36;
            label23.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(103, 23);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(598, 23);
            txtDescricao.TabIndex = 35;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 394);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Unidades";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 394);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Dimenções";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // FormCadastroProductoServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Name = "FormCadastroProductoServico";
            Text = "FormProductoServico";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnGravar;
        private ToolStripButton btnNovo;
        private ToolStripButton btnEditar;
        private ToolStripButton btnAnular;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnListar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label24;
        private TextBox txtCodigoArtigo;
        private CheckBox chkActivo;
        private Label label23;
        private TextBox txtDescricao;
        private Label label1;
        private TextBox txtCodigoBarra;
        private ComboBox cmbTipoArtigo;
        private Label label30;
        private Label label4;
        private TextBox txtPrecoVenda;
        private Label label3;
        private TextBox txtTaxaLucro;
        private Label label2;
        private TextBox txtPrecoCompra;
        private TabPage tabPage3;
        private Label label9;
        private TextBox txtDesconto;
        private ComboBox cmbModelo;
        private Label label8;
        private ComboBox cmbMarca;
        private Label label7;
        private ComboBox cmbFamiliaArtigo;
        private Label label6;
        private ComboBox cmbCategoriaArtigo;
        private Label label5;
        private CheckBox chkDevolucao;
        private CheckBox chkMovimentaStock;
        private Label label10;
        private TextBox txtGarantia;
        private ComboBox cmbFornecedor;
        private Label label11;
        private ComboBox cmbTipoIVA;
        private Label label12;
    }
}