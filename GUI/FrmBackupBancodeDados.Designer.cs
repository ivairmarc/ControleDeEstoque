namespace GUI
{
    partial class FrmBackupBancodeDados
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
            this.btBackupBd = new System.Windows.Forms.Button();
            this.btRestaurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBackupBd
            // 
            this.btBackupBd.Location = new System.Drawing.Point(100, 28);
            this.btBackupBd.Name = "btBackupBd";
            this.btBackupBd.Size = new System.Drawing.Size(219, 33);
            this.btBackupBd.TabIndex = 1;
            this.btBackupBd.Text = "Backup do banco de dados";
            this.btBackupBd.UseVisualStyleBackColor = true;
            this.btBackupBd.Click += new System.EventHandler(this.btBackupBd_Click);
            // 
            // btRestaurar
            // 
            this.btRestaurar.Location = new System.Drawing.Point(100, 90);
            this.btRestaurar.Name = "btRestaurar";
            this.btRestaurar.Size = new System.Drawing.Size(219, 35);
            this.btRestaurar.TabIndex = 3;
            this.btRestaurar.Text = "Restaurar banco de dados";
            this.btRestaurar.UseVisualStyleBackColor = true;
            this.btRestaurar.Click += new System.EventHandler(this.btRestaurar_Click);
            // 
            // FrmBackupBancodeDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 152);
            this.Controls.Add(this.btRestaurar);
            this.Controls.Add(this.btBackupBd);
            this.Name = "FrmBackupBancodeDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Banco de Dados";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btBackupBd;
        private System.Windows.Forms.Button btRestaurar;
    }
}