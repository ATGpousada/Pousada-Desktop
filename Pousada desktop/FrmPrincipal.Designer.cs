namespace PousadaDesk
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarConsultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroFuncionarioToolStripMenuItem,
            this.reservaToolStripMenuItem,
            this.quartoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1359, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cadastroFuncionarioToolStripMenuItem
            // 
            this.cadastroFuncionarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionarioToolStripMenuItem,
            this.alterarConsultarToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.cadastroFuncionarioToolStripMenuItem.Name = "cadastroFuncionarioToolStripMenuItem";
            this.cadastroFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.cadastroFuncionarioToolStripMenuItem.Text = "&Funcionario";
            this.cadastroFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.cadastroFuncionarioToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.funcionarioToolStripMenuItem.Text = "&Cadastrar";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // alterarConsultarToolStripMenuItem
            // 
            this.alterarConsultarToolStripMenuItem.Name = "alterarConsultarToolStripMenuItem";
            this.alterarConsultarToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.alterarConsultarToolStripMenuItem.Text = "&Alterar/Consultar";
            this.alterarConsultarToolStripMenuItem.Click += new System.EventHandler(this.alterarConsultarToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.listarToolStripMenuItem.Text = "&Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reservaToolStripMenuItem.Text = "Re&serva";
            // 
            // quartoToolStripMenuItem
            // 
            this.quartoToolStripMenuItem.Name = "quartoToolStripMenuItem";
            this.quartoToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.quartoToolStripMenuItem.Text = "Qua&rto";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 578);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Pousada Do Sossego";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarConsultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
    }
}

