
namespace GUI
{
    partial class FormPagamentoCompra
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
            this.DtPagamento = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DtCompra = new System.Windows.Forms.DateTimePicker();
            this.BtImprimir = new System.Windows.Forms.Button();
            this.BtPagar = new System.Windows.Forms.Button();
            this.DgvDados = new System.Windows.Forms.DataGridView();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtBusca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // DtPagamento
            // 
            this.DtPagamento.Enabled = false;
            this.DtPagamento.Location = new System.Drawing.Point(12, 289);
            this.DtPagamento.Name = "DtPagamento";
            this.DtPagamento.Size = new System.Drawing.Size(218, 20);
            this.DtPagamento.TabIndex = 32;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(9, 273);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(102, 13);
            this.label.TabIndex = 31;
            this.label.Text = "Data do Pagamento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Parcelas";
            // 
            // DtCompra
            // 
            this.DtCompra.Enabled = false;
            this.DtCompra.Location = new System.Drawing.Point(8, 75);
            this.DtCompra.Name = "DtCompra";
            this.DtCompra.Size = new System.Drawing.Size(218, 20);
            this.DtCompra.TabIndex = 28;
            // 
            // BtImprimir
            // 
            this.BtImprimir.Location = new System.Drawing.Point(316, 286);
            this.BtImprimir.Name = "BtImprimir";
            this.BtImprimir.Size = new System.Drawing.Size(75, 23);
            this.BtImprimir.TabIndex = 27;
            this.BtImprimir.Text = "Imprimir";
            this.BtImprimir.UseVisualStyleBackColor = true;
            // 
            // BtPagar
            // 
            this.BtPagar.Enabled = false;
            this.BtPagar.Location = new System.Drawing.Point(478, 286);
            this.BtPagar.Name = "BtPagar";
            this.BtPagar.Size = new System.Drawing.Size(75, 23);
            this.BtPagar.TabIndex = 26;
            this.BtPagar.Text = "Pagar";
            this.BtPagar.UseVisualStyleBackColor = true;
            this.BtPagar.Click += new System.EventHandler(this.BtPagar_Click_1);
            // 
            // DgvDados
            // 
            this.DgvDados.AllowUserToAddRows = false;
            this.DgvDados.AllowUserToDeleteRows = false;
            this.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDados.Location = new System.Drawing.Point(12, 116);
            this.DgvDados.Name = "DgvDados";
            this.DgvDados.ReadOnly = true;
            this.DgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDados.Size = new System.Drawing.Size(548, 150);
            this.DgvDados.TabIndex = 25;
            this.DgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDados_CellClick_1);
            // 
            // TxtValor
            // 
            this.TxtValor.Enabled = false;
            this.TxtValor.Location = new System.Drawing.Point(245, 75);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(100, 20);
            this.TxtValor.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Data";
            // 
            // TxtNome
            // 
            this.TxtNome.Enabled = false;
            this.TxtNome.Location = new System.Drawing.Point(143, 20);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(410, 20);
            this.TxtNome.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(8, 20);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(106, 20);
            this.TxtCodigo.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Código";
            // 
            // BtBusca
            // 
            this.BtBusca.Location = new System.Drawing.Point(416, 76);
            this.BtBusca.Name = "BtBusca";
            this.BtBusca.Size = new System.Drawing.Size(140, 23);
            this.BtBusca.TabIndex = 17;
            this.BtBusca.Text = "Localizar Compra";
            this.BtBusca.UseVisualStyleBackColor = true;
            this.BtBusca.Click += new System.EventHandler(this.BtBusca_Click_1);
            // 
            // FormPagamentoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 328);
            this.Controls.Add(this.DtPagamento);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtCompra);
            this.Controls.Add(this.BtImprimir);
            this.Controls.Add(this.BtPagar);
            this.Controls.Add(this.DgvDados);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtBusca);
            this.Name = "FormPagamentoCompra";
            this.Text = "FormPagamentoCompra";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtPagamento;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtCompra;
        private System.Windows.Forms.Button BtImprimir;
        private System.Windows.Forms.Button BtPagar;
        private System.Windows.Forms.DataGridView DgvDados;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtBusca;
    }
}