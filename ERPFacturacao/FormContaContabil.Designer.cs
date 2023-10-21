namespace ERPFacturacao
{
    partial class FormContaContabil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContaContabil));
            toolStrip1 = new ToolStrip();
            btnGravar = new ToolStripButton();
            btnNovo = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnAnular = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnListar = new ToolStripButton();
            dataGridContaContabil = new ADGV.AdvancedDataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDescricao = new TextBox();
            txtCodigoCantaPai = new TextBox();
            txtID = new TextBox();
            cmbClasseContabil = new ComboBox();
            cmbContaContabilAgregadora = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSequencia = new TextBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridContaContabil).BeginInit();
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
            // dataGridContaContabil
            // 
            dataGridContaContabil.AutoGenerateContextFilters = true;
            dataGridContaContabil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridContaContabil.DateWithTime = false;
            dataGridContaContabil.Location = new Point(13, 152);
            dataGridContaContabil.Name = "dataGridContaContabil";
            dataGridContaContabil.RowTemplate.Height = 25;
            dataGridContaContabil.Size = new Size(535, 265);
            dataGridContaContabil.TabIndex = 22;
            dataGridContaContabil.TimeFilter = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 86);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 21;
            label3.Text = "Desscricao";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 86);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 20;
            label2.Text = "Conta Pai";
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
            txtDescricao.Location = new Point(225, 104);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(323, 23);
            txtDescricao.TabIndex = 18;
            // 
            // txtCodigoCantaPai
            // 
            txtCodigoCantaPai.Enabled = false;
            txtCodigoCantaPai.Location = new Point(13, 104);
            txtCodigoCantaPai.Name = "txtCodigoCantaPai";
            txtCodigoCantaPai.Size = new Size(100, 23);
            txtCodigoCantaPai.TabIndex = 17;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(13, 51);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 16;
            // 
            // cmbClasseContabil
            // 
            cmbClasseContabil.FormattingEnabled = true;
            cmbClasseContabil.Location = new Point(119, 51);
            cmbClasseContabil.Name = "cmbClasseContabil";
            cmbClasseContabil.Size = new Size(213, 23);
            cmbClasseContabil.TabIndex = 23;
            // 
            // cmbContaContabilAgregadora
            // 
            cmbContaContabilAgregadora.FormattingEnabled = true;
            cmbContaContabilAgregadora.Location = new Point(334, 51);
            cmbContaContabilAgregadora.Name = "cmbContaContabilAgregadora";
            cmbContaContabilAgregadora.Size = new Size(213, 23);
            cmbContaContabilAgregadora.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 33);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 25;
            label4.Text = "Classe Contábil";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 33);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 26;
            label5.Text = "Conta Agregadora";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(119, 86);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 28;
            label6.Text = "Sequència";
            // 
            // txtSequencia
            // 
            txtSequencia.Location = new Point(119, 104);
            txtSequencia.Name = "txtSequencia";
            txtSequencia.Size = new Size(100, 23);
            txtSequencia.TabIndex = 27;
            // 
            // FormContaContabil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 450);
            Controls.Add(label6);
            Controls.Add(txtSequencia);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbContaContabilAgregadora);
            Controls.Add(cmbClasseContabil);
            Controls.Add(dataGridContaContabil);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescricao);
            Controls.Add(txtCodigoCantaPai);
            Controls.Add(txtID);
            Controls.Add(toolStrip1);
            Name = "FormContaContabil";
            Text = "FormContaContabil";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridContaContabil).EndInit();
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
        private ADGV.AdvancedDataGridView dataGridContaContabil;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDescricao;
        private TextBox txtCodigoCantaPai;
        private TextBox txtID;
        private ComboBox cmbClasseContabil;
        private ComboBox cmbContaContabilAgregadora;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtSequencia;
    }
}