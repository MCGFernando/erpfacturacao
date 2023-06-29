namespace ERPFacturacao
{
    partial class FormTipoProductoServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoProductoServico));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnListar = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dataGridTipoProductoServico = new ADGV.AdvancedDataGridView();
            this.label33 = new System.Windows.Forms.Label();
            this.txtTipoProductoServico = new System.Windows.Forms.TextBox();
            this.cmbTipoFiscal = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTipoProductoServico)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(394, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tipo Fiscal";
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
            // dataGridTipoProductoServico
            // 
            this.dataGridTipoProductoServico.AutoGenerateContextFilters = true;
            this.dataGridTipoProductoServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTipoProductoServico.DateWithTime = false;
            this.dataGridTipoProductoServico.Location = new System.Drawing.Point(11, 125);
            this.dataGridTipoProductoServico.Name = "dataGridTipoProductoServico";
            this.dataGridTipoProductoServico.RowTemplate.Height = 25;
            this.dataGridTipoProductoServico.Size = new System.Drawing.Size(538, 292);
            this.dataGridTipoProductoServico.TabIndex = 35;
            this.dataGridTipoProductoServico.TimeFilter = false;
            this.dataGridTipoProductoServico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTipoIVA_CellContentClick);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(12, 78);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(30, 15);
            this.label33.TabIndex = 34;
            this.label33.Text = "Tipo";
            // 
            // txtTipoProductoServico
            // 
            this.txtTipoProductoServico.Location = new System.Drawing.Point(12, 96);
            this.txtTipoProductoServico.Name = "txtTipoProductoServico";
            this.txtTipoProductoServico.Size = new System.Drawing.Size(376, 23);
            this.txtTipoProductoServico.TabIndex = 33;
            // 
            // cmbTipoFiscal
            // 
            this.cmbTipoFiscal.FormattingEnabled = true;
            this.cmbTipoFiscal.Location = new System.Drawing.Point(394, 96);
            this.cmbTipoFiscal.Name = "cmbTipoFiscal";
            this.cmbTipoFiscal.Size = new System.Drawing.Size(154, 23);
            this.cmbTipoFiscal.TabIndex = 40;
            // 
            // FormTipoProductoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.cmbTipoFiscal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridTipoProductoServico);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.txtTipoProductoServico);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormTipoProductoServico";
            this.Text = "FormTipoProductoServico";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTipoProductoServico)).EndInit();
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
        private Label label1;
        private TextBox txtId;
        private ADGV.AdvancedDataGridView dataGridTipoProductoServico;
        private Label label33;
        private TextBox txtTipoProductoServico;
        private ComboBox cmbTipoFiscal;
    }
}