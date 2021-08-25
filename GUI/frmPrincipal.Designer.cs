namespace GUI
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadeDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadeDeMedidaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDePagamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoDoBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDoBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLateralLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.iconHideMenu = new System.Windows.Forms.PictureBox();
            this.iconRest = new System.Windows.Forms.PictureBox();
            this.iconMin = new System.Windows.Forms.PictureBox();
            this.iconMaxi = new System.Windows.Forms.PictureBox();
            this.iconClose = new System.Windows.Forms.PictureBox();
            this.pagamentoDeParcelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panelLateralLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHideMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(815, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.AutoSize = false;
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.subCategoriaToolStripMenuItem,
            this.unidadeDeMedidaToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.toolStripSeparator1,
            this.clienteToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.tipoDePagamentoToolStripMenuItem});
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cadastroToolStripMenuItem.Image = global::GUI.Properties.Resources.prodcutos;
            this.cadastroToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // subCategoriaToolStripMenuItem
            // 
            this.subCategoriaToolStripMenuItem.Name = "subCategoriaToolStripMenuItem";
            this.subCategoriaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.subCategoriaToolStripMenuItem.Text = "SubCategoria";
            this.subCategoriaToolStripMenuItem.Click += new System.EventHandler(this.subCategoriaToolStripMenuItem_Click);
            // 
            // unidadeDeMedidaToolStripMenuItem
            // 
            this.unidadeDeMedidaToolStripMenuItem.Name = "unidadeDeMedidaToolStripMenuItem";
            this.unidadeDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.unidadeDeMedidaToolStripMenuItem.Text = "Unidade de Medida";
            this.unidadeDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadeDeMedidaToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // tipoDePagamentoToolStripMenuItem
            // 
            this.tipoDePagamentoToolStripMenuItem.Name = "tipoDePagamentoToolStripMenuItem";
            this.tipoDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.tipoDePagamentoToolStripMenuItem.Text = "Tipo de Pagamento";
            this.tipoDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.tipoDePagamentoToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.AutoSize = false;
            this.consultaToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem1,
            this.subCategoriaToolStripMenuItem1,
            this.unidadeDeMedidaToolStripMenuItem1,
            this.produtoToolStripMenuItem1,
            this.toolStripSeparator2,
            this.clienteToolStripMenuItem1,
            this.fornecedorToolStripMenuItem1,
            this.tipoDePagamentoToolStripMenuItem1,
            this.compraToolStripMenuItem1,
            this.vendaToolStripMenuItem1});
            this.consultaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.consultaToolStripMenuItem.Image = global::GUI.Properties.Resources.prodcutos;
            this.consultaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem1
            // 
            this.categoriaToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.categoriaToolStripMenuItem1.Name = "categoriaToolStripMenuItem1";
            this.categoriaToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.categoriaToolStripMenuItem1.Text = "Categoria";
            this.categoriaToolStripMenuItem1.Click += new System.EventHandler(this.categoriaToolStripMenuItem1_Click);
            // 
            // subCategoriaToolStripMenuItem1
            // 
            this.subCategoriaToolStripMenuItem1.Name = "subCategoriaToolStripMenuItem1";
            this.subCategoriaToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.subCategoriaToolStripMenuItem1.Text = "SubCategoria";
            this.subCategoriaToolStripMenuItem1.Click += new System.EventHandler(this.subCategoriaToolStripMenuItem1_Click);
            // 
            // unidadeDeMedidaToolStripMenuItem1
            // 
            this.unidadeDeMedidaToolStripMenuItem1.Name = "unidadeDeMedidaToolStripMenuItem1";
            this.unidadeDeMedidaToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.unidadeDeMedidaToolStripMenuItem1.Text = "Unidade de Medida";
            this.unidadeDeMedidaToolStripMenuItem1.Click += new System.EventHandler(this.unidadeDeMedidaToolStripMenuItem1_Click);
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.produtoToolStripMenuItem1.Text = "Produto";
            this.produtoToolStripMenuItem1.Click += new System.EventHandler(this.produtoToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(174, 6);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // fornecedorToolStripMenuItem1
            // 
            this.fornecedorToolStripMenuItem1.Name = "fornecedorToolStripMenuItem1";
            this.fornecedorToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.fornecedorToolStripMenuItem1.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem1.Click += new System.EventHandler(this.fornecedorToolStripMenuItem1_Click);
            // 
            // tipoDePagamentoToolStripMenuItem1
            // 
            this.tipoDePagamentoToolStripMenuItem1.Name = "tipoDePagamentoToolStripMenuItem1";
            this.tipoDePagamentoToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.tipoDePagamentoToolStripMenuItem1.Text = "Tipo de Pagamento";
            this.tipoDePagamentoToolStripMenuItem1.Click += new System.EventHandler(this.tipoDePagamentoToolStripMenuItem1_Click);
            // 
            // compraToolStripMenuItem1
            // 
            this.compraToolStripMenuItem1.Name = "compraToolStripMenuItem1";
            this.compraToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.compraToolStripMenuItem1.Text = "Compra";
            this.compraToolStripMenuItem1.Click += new System.EventHandler(this.compraToolStripMenuItem1_Click);
            // 
            // vendaToolStripMenuItem1
            // 
            this.vendaToolStripMenuItem1.Name = "vendaToolStripMenuItem1";
            this.vendaToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.vendaToolStripMenuItem1.Text = "Venda";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.AutoSize = false;
            this.movimentaçãoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraToolStripMenuItem,
            this.vendaToolStripMenuItem});
            this.movimentaçãoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.movimentaçãoToolStripMenuItem.Image = global::GUI.Properties.Resources.compras;
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            this.movimentaçãoToolStripMenuItem.Click += new System.EventHandler(this.movimentaçãoToolStripMenuItem_Click);
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagamentoDeParcelasToolStripMenuItem});
            this.compraToolStripMenuItem.Image = global::GUI.Properties.Resources.compras1;
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.compraToolStripMenuItem.Text = "Compra";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Image = global::GUI.Properties.Resources.ventas;
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.AutoSize = false;
            this.relatórioToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.relatórioToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            this.relatórioToolStripMenuItem.Click += new System.EventHandler(this.relatórioToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.AutoSize = false;
            this.ferramentasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçãoDoBancoDeDadosToolStripMenuItem,
            this.backupDoBancoDeDadosToolStripMenuItem,
            this.toolStripSeparator3,
            this.calculadoraToolStripMenuItem,
            this.explorerToolStripMenuItem,
            this.blocoDeNotasToolStripMenuItem});
            this.ferramentasToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            this.ferramentasToolStripMenuItem.Click += new System.EventHandler(this.ferramentasToolStripMenuItem_Click);
            // 
            // configuraçãoDoBancoDeDadosToolStripMenuItem
            // 
            this.configuraçãoDoBancoDeDadosToolStripMenuItem.Name = "configuraçãoDoBancoDeDadosToolStripMenuItem";
            this.configuraçãoDoBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.configuraçãoDoBancoDeDadosToolStripMenuItem.Text = "Configuração do Banco de Dados";
            this.configuraçãoDoBancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoDoBancoDeDadosToolStripMenuItem_Click);
            // 
            // backupDoBancoDeDadosToolStripMenuItem
            // 
            this.backupDoBancoDeDadosToolStripMenuItem.Name = "backupDoBancoDeDadosToolStripMenuItem";
            this.backupDoBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.backupDoBancoDeDadosToolStripMenuItem.Text = "Backup do Banco de Dados";
            this.backupDoBancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.backupDoBancoDeDadosToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(248, 6);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // explorerToolStripMenuItem
            // 
            this.explorerToolStripMenuItem.Name = "explorerToolStripMenuItem";
            this.explorerToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.explorerToolStripMenuItem.Text = "Explorer";
            this.explorerToolStripMenuItem.Click += new System.EventHandler(this.explorerToolStripMenuItem_Click);
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            this.blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            this.blocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.blocoDeNotasToolStripMenuItem.Text = "Bloco de Notas";
            this.blocoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.blocoDeNotasToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.AutoSize = false;
            this.sobreToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // panelLateralLeft
            // 
            this.panelLateralLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelLateralLeft.Controls.Add(this.panel1);
            this.panelLateralLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateralLeft.Location = new System.Drawing.Point(0, 34);
            this.panelLateralLeft.Name = "panelLateralLeft";
            this.panelLateralLeft.Size = new System.Drawing.Size(168, 415);
            this.panelLateralLeft.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 100);
            this.panel1.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 51);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail";
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnlogout.Location = new System.Drawing.Point(6, 74);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(81, 23);
            this.btnlogout.TabIndex = 1;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 3);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(3, 26);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Cargo";
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCentral.Controls.Add(this.iconHideMenu);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(168, 34);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(647, 415);
            this.panelCentral.TabIndex = 2;
            this.panelCentral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCentral_MouseDown);
            // 
            // iconHideMenu
            // 
            this.iconHideMenu.Image = global::GUI.Properties.Resources.menu;
            this.iconHideMenu.Location = new System.Drawing.Point(0, 0);
            this.iconHideMenu.Name = "iconHideMenu";
            this.iconHideMenu.Size = new System.Drawing.Size(28, 31);
            this.iconHideMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconHideMenu.TabIndex = 0;
            this.iconHideMenu.TabStop = false;
            this.iconHideMenu.Click += new System.EventHandler(this.iconHideMenu_Click);
            // 
            // iconRest
            // 
            this.iconRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRest.BackColor = System.Drawing.Color.Transparent;
            this.iconRest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconRest.Image = global::GUI.Properties.Resources.restore;
            this.iconRest.Location = new System.Drawing.Point(770, 2);
            this.iconRest.Name = "iconRest";
            this.iconRest.Size = new System.Drawing.Size(16, 17);
            this.iconRest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconRest.TabIndex = 4;
            this.iconRest.TabStop = false;
            this.iconRest.Click += new System.EventHandler(this.iconRest_Click);
            // 
            // iconMin
            // 
            this.iconMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMin.BackColor = System.Drawing.Color.Transparent;
            this.iconMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMin.Image = global::GUI.Properties.Resources.miniBlack;
            this.iconMin.Location = new System.Drawing.Point(746, 1);
            this.iconMin.Name = "iconMin";
            this.iconMin.Size = new System.Drawing.Size(17, 17);
            this.iconMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMin.TabIndex = 4;
            this.iconMin.TabStop = false;
            this.iconMin.Click += new System.EventHandler(this.iconMin_Click);
            // 
            // iconMaxi
            // 
            this.iconMaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaxi.BackColor = System.Drawing.Color.Transparent;
            this.iconMaxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMaxi.Image = global::GUI.Properties.Resources.maxBlack;
            this.iconMaxi.Location = new System.Drawing.Point(770, 0);
            this.iconMaxi.Name = "iconMaxi";
            this.iconMaxi.Size = new System.Drawing.Size(17, 17);
            this.iconMaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMaxi.TabIndex = 4;
            this.iconMaxi.TabStop = false;
            this.iconMaxi.Click += new System.EventHandler(this.iconMaxi_Click);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.BackColor = System.Drawing.Color.Transparent;
            this.iconClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconClose.Image = global::GUI.Properties.Resources.closeBlack;
            this.iconClose.Location = new System.Drawing.Point(792, 1);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(17, 17);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconClose.TabIndex = 3;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // pagamentoDeParcelasToolStripMenuItem
            // 
            this.pagamentoDeParcelasToolStripMenuItem.Name = "pagamentoDeParcelasToolStripMenuItem";
            this.pagamentoDeParcelasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.pagamentoDeParcelasToolStripMenuItem.Text = "Pagamento de parcelas";
            this.pagamentoDeParcelasToolStripMenuItem.Click += new System.EventHandler(this.pagamentoDeParcelasToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(815, 449);
            this.Controls.Add(this.iconMaxi);
            this.Controls.Add(this.iconMin);
            this.Controls.Add(this.iconRest);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelLateralLeft);
            this.Controls.Add(this.iconClose);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelLateralLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconHideMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadeDeMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem subCategoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unidadeDeMedidaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoDoBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupDoBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDePagamentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.Panel panelLateralLeft;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.PictureBox iconClose;
        private System.Windows.Forms.PictureBox iconMaxi;
        private System.Windows.Forms.PictureBox iconMin;
        private System.Windows.Forms.PictureBox iconRest;
        private System.Windows.Forms.PictureBox iconHideMenu;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pagamentoDeParcelasToolStripMenuItem;
    }
}