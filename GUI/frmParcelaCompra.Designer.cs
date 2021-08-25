
namespace GUI
{
    partial class frmParcelaCompra
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
            this.pnFinalizaCompra = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbtotal = new System.Windows.Forms.Label();
            this.texto = new System.Windows.Forms.Label();
            this.btnCancelarParcelas = new System.Windows.Forms.PictureBox();
            this.btnSalvarFinal = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.pco_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_datavencto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnFinalizaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvarFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnFinalizaCompra
            // 
            this.pnFinalizaCompra.Controls.Add(this.pictureBox3);
            this.pnFinalizaCompra.Controls.Add(this.lbtotal);
            this.pnFinalizaCompra.Controls.Add(this.texto);
            this.pnFinalizaCompra.Controls.Add(this.btnCancelarParcelas);
            this.pnFinalizaCompra.Controls.Add(this.btnSalvarFinal);
            this.pnFinalizaCompra.Controls.Add(this.label17);
            this.pnFinalizaCompra.Controls.Add(this.label18);
            this.pnFinalizaCompra.Controls.Add(this.label16);
            this.pnFinalizaCompra.Controls.Add(this.dgvParcelas);
            this.pnFinalizaCompra.Location = new System.Drawing.Point(3, 11);
            this.pnFinalizaCompra.Name = "pnFinalizaCompra";
            this.pnFinalizaCompra.Size = new System.Drawing.Size(503, 529);
            this.pnFinalizaCompra.TabIndex = 3;
            this.pnFinalizaCompra.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.real;
            this.pictureBox3.Location = new System.Drawing.Point(377, 388);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // lbtotal
            // 
            this.lbtotal.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbtotal.Location = new System.Drawing.Point(404, 389);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(70, 15);
            this.lbtotal.TabIndex = 25;
            this.lbtotal.Text = "00,00";
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Location = new System.Drawing.Point(288, 389);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(83, 13);
            this.texto.TabIndex = 24;
            this.texto.Text = "Tota da Compra";
            // 
            // btnCancelarParcelas
            // 
            this.btnCancelarParcelas.Image = global::GUI.Properties.Resources.Cancelar;
            this.btnCancelarParcelas.Location = new System.Drawing.Point(432, 471);
            this.btnCancelarParcelas.Name = "btnCancelarParcelas";
            this.btnCancelarParcelas.Size = new System.Drawing.Size(51, 50);
            this.btnCancelarParcelas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancelarParcelas.TabIndex = 23;
            this.btnCancelarParcelas.TabStop = false;
            // 
            // btnSalvarFinal
            // 
            this.btnSalvarFinal.Image = global::GUI.Properties.Resources.saveblack1;
            this.btnSalvarFinal.Location = new System.Drawing.Point(365, 471);
            this.btnSalvarFinal.Name = "btnSalvarFinal";
            this.btnSalvarFinal.Size = new System.Drawing.Size(48, 50);
            this.btnSalvarFinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalvarFinal.TabIndex = 22;
            this.btnSalvarFinal.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 25);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(481, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "_______________________________________________________________________________";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Parcelas da compra";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Dados do Pagamento";
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pco_cod,
            this.pco_valor,
            this.pco_datavencto});
            this.dgvParcelas.Location = new System.Drawing.Point(6, 57);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.Size = new System.Drawing.Size(502, 329);
            this.dgvParcelas.TabIndex = 0;
            // 
            // pco_cod
            // 
            this.pco_cod.HeaderText = "Parcela";
            this.pco_cod.Name = "pco_cod";
            // 
            // pco_valor
            // 
            this.pco_valor.HeaderText = "Valor da Parcela";
            this.pco_valor.Name = "pco_valor";
            // 
            // pco_datavencto
            // 
            this.pco_datavencto.HeaderText = "Data da vencimento";
            this.pco_datavencto.Name = "pco_datavencto";
            this.pco_datavencto.Width = 300;
            // 
            // frmParcelaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 540);
            this.Controls.Add(this.pnFinalizaCompra);
            this.Name = "frmParcelaCompra";
            this.Text = "frmParcelaCompra";
            this.pnFinalizaCompra.ResumeLayout(false);
            this.pnFinalizaCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvarFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFinalizaCompra;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.PictureBox btnCancelarParcelas;
        private System.Windows.Forms.PictureBox btnSalvarFinal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_datavencto;
    }
}