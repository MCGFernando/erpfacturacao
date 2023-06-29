namespace ERPFacturacao
{
    partial class FormCategoriaProductoServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoriaProductoServico));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnListar = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dataGridTipoIVA = new ADGV.AdvancedDataGridView();
            this.label33 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.cmbCategoriaPai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTipoIVA)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGravar,
            this.btnNovo,
            this.btnEditar,
            this.btnAnular,
            this.toolStripSeparator1,
            this.btnListar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(560, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGravar
            // 
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(61, 22);
            this.btnGravar.Text = "Gravar";
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(56, 22);
            this.btnNovo.Text = "Novo";
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 22);
            this.btnEditar.Text = "Editar";
            // 
            // btnAnular
            // 
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(62, 22);
            this.btnAnular.Text = "Anular";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnListar
            // 
            this.btnListar.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Image")));
            this.btnListar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(55, 22);
            this.btnListar.Text = "Listar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nivel";
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(459, 96);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(89, 23);
            this.txtNivel.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(11, 52);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(89, 23);
            this.txtId.TabIndex = 36;
            // 
            // dataGridTipoIVA
            // 
            this.dataGridTipoIVA.AutoGenerateContextFilters = true;
            this.dataGridTipoIVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTipoIVA.DateWithTime = false;
            this.dataGridTipoIVA.Location = new System.Drawing.Point(11, 125);
            this.dataGridTipoIVA.Name = "dataGridTipoIVA";
            this.dataGridTipoIVA.RowTemplate.Height = 25;
            this.dataGridTipoIVA.Size = new System.Drawing.Size(538, 292);
            this.dataGridTipoIVA.TabIndex = 35;
            this.dataGridTipoIVA.TimeFilter = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(106, 78);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(58, 15);
            this.label33.TabIndex = 34;
            this.label33.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(106, 96);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(347, 23);
            this.txtDescricao.TabIndex = 33;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(11, 78);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(58, 15);
            this.label31.TabIndex = 32;
            this.label31.Text = "Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(11, 96);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(89, 23);
            this.txtCategoria.TabIndex = 31;
            // 
            // cmbCategoriaPai
            // 
            this.cmbCategoriaPai.FormattingEnabled = true;
            this.cmbCategoriaPai.Location = new System.Drawing.Point(106, 52);
            this.cmbCategoriaPai.Name = "cmbCategoriaPai";
            this.cmbCategoriaPai.Size = new System.Drawing.Size(347, 23);
            this.cmbCategoriaPai.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "Categoria Pai";
            // 
            // FormCategoriaProductoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCategoriaPai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridTipoIVA);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormCategoriaProductoServico";
            this.Text = "FormCategoriaProductoServico";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTipoIVA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnGravar;
        private ToolStripButton btnNovo;
        private ToolStripButton btnEditar;
        private ToolStripButton btnAnular;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnListar;
        private Label label2;
        private TextBox txtNivel;
        private Label label1;
        private TextBox txtId;
        private ADGV.AdvancedDataGridView dataGridTipoIVA;
        private Label label33;
        private TextBox txtDescricao;
        private Label label31;
        private TextBox txtCategoria;
        private ComboBox cmbCategoriaPai;
        private Label label3;
    }
}