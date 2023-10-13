namespace ERPFacturacao
{
    partial class FormContaContabilAgragadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContaContabilAgragadora));
            toolStrip1 = new ToolStrip();
            btnGravar = new ToolStripButton();
            btnNovo = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnAnular = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnListar = new ToolStripButton();
            dataGridContaContabilAgregadora = new ADGV.AdvancedDataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDescricao = new TextBox();
            txtCodigo = new TextBox();
            txtId = new TextBox();
            cmbClasseContabil = new ComboBox();
            label4 = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridContaContabilAgregadora).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnGravar, btnNovo, btnEditar, btnAnular, toolStripSeparator1, btnListar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(560, 25);
            toolStrip1.TabIndex = 8;
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
            // dataGridContaContabilAgregadora
            // 
            dataGridContaContabilAgregadora.AutoGenerateContextFilters = true;
            dataGridContaContabilAgregadora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridContaContabilAgregadora.DateWithTime = false;
            dataGridContaContabilAgregadora.Location = new Point(13, 153);
            dataGridContaContabilAgregadora.Name = "dataGridContaContabilAgregadora";
            dataGridContaContabilAgregadora.RowTemplate.Height = 25;
            dataGridContaContabilAgregadora.Size = new Size(535, 265);
            dataGridContaContabilAgregadora.TabIndex = 22;
            dataGridContaContabilAgregadora.TimeFilter = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 86);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 21;
            label3.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 86);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 20;
            label2.Text = "Código";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 33);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 19;
            label1.Text = "ID";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(119, 104);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(429, 23);
            txtDescricao.TabIndex = 18;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(13, 104);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 17;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(13, 51);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 16;
            // 
            // cmbClasseContabil
            // 
            cmbClasseContabil.FormattingEnabled = true;
            cmbClasseContabil.Location = new Point(119, 51);
            cmbClasseContabil.Name = "cmbClasseContabil";
            cmbClasseContabil.Size = new Size(429, 23);
            cmbClasseContabil.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 33);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 24;
            label4.Text = "Classe Contabil";
            // 
            // FormContaContabilAgragadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 450);
            Controls.Add(label4);
            Controls.Add(cmbClasseContabil);
            Controls.Add(dataGridContaContabilAgregadora);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescricao);
            Controls.Add(txtCodigo);
            Controls.Add(txtId);
            Controls.Add(toolStrip1);
            Name = "FormContaContabilAgragadora";
            Text = "FormContaContabilAgragadora";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridContaContabilAgregadora).EndInit();
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
        private ADGV.AdvancedDataGridView dataGridContaContabilAgregadora;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDescricao;
        private TextBox txtCodigo;
        private TextBox txtId;
        private ComboBox cmbClasseContabil;
        private Label label4;
    }
}