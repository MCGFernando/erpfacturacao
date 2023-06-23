namespace ERPFacturacao
{
    partial class FormBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanco));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnListar = new System.Windows.Forms.ToolStripButton();
            this.dataGridBanco = new ADGV.AdvancedDataGridView();
            this.label33 = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtSiglaBanco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBanco)).BeginInit();
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
            this.toolStrip1.TabIndex = 9;
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
            // dataGridBanco
            // 
            this.dataGridBanco.AutoGenerateContextFilters = true;
            this.dataGridBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBanco.DateWithTime = false;
            this.dataGridBanco.Location = new System.Drawing.Point(10, 133);
            this.dataGridBanco.Name = "dataGridBanco";
            this.dataGridBanco.RowTemplate.Height = 25;
            this.dataGridBanco.Size = new System.Drawing.Size(538, 292);
            this.dataGridBanco.TabIndex = 19;
            this.dataGridBanco.TimeFilter = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(105, 86);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(40, 15);
            this.label33.TabIndex = 18;
            this.label33.Text = "Banco";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(105, 104);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(443, 23);
            this.txtBanco.TabIndex = 17;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(10, 86);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(32, 15);
            this.label31.TabIndex = 16;
            this.label31.Text = "Sigla";
            // 
            // txtSiglaBanco
            // 
            this.txtSiglaBanco.Location = new System.Drawing.Point(10, 104);
            this.txtSiglaBanco.Name = "txtSiglaBanco";
            this.txtSiglaBanco.Size = new System.Drawing.Size(89, 23);
            this.txtSiglaBanco.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(10, 60);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(89, 23);
            this.txtId.TabIndex = 20;
            // 
            // FormBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridBanco);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.txtSiglaBanco);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormBanco";
            this.Text = "FormBanco";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBanco)).EndInit();
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
        private ADGV.AdvancedDataGridView dataGridBanco;
        private Label label33;
        private TextBox txtBanco;
        private Label label31;
        private TextBox txtSiglaBanco;
        private Label label1;
        private TextBox txtId;
    }
}