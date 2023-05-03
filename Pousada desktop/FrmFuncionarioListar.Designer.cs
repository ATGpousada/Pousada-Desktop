namespace Pousada_desktop
{
    partial class FrmFuncionarioListar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionarioListar));
            this.dgvFuncionarioPrincipal = new System.Windows.Forms.DataGridView();
            this.dgvEndereco = new System.Windows.Forms.DataGridView();
            this.clnIdEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLogradouroEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumeroEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCepEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBairroEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCidadeEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUfEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFuncionarioEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAdmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dgvTelefone = new System.Windows.Forms.DataGridView();
            this.clnIdTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTipoTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumeroTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFuncionarioTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarioPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionarioPrincipal
            // 
            this.dgvFuncionarioPrincipal.AllowUserToAddRows = false;
            this.dgvFuncionarioPrincipal.AllowUserToDeleteRows = false;
            this.dgvFuncionarioPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarioPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnDataNasc,
            this.clnCpf,
            this.clnRG,
            this.clnSalario,
            this.clnEmail,
            this.clnPeriodo,
            this.clnAdmissao,
            this.clnCargo});
            this.dgvFuncionarioPrincipal.Location = new System.Drawing.Point(48, 124);
            this.dgvFuncionarioPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFuncionarioPrincipal.Name = "dgvFuncionarioPrincipal";
            this.dgvFuncionarioPrincipal.ReadOnly = true;
            this.dgvFuncionarioPrincipal.RowHeadersVisible = false;
            this.dgvFuncionarioPrincipal.RowHeadersWidth = 51;
            this.dgvFuncionarioPrincipal.Size = new System.Drawing.Size(1316, 287);
            this.dgvFuncionarioPrincipal.TabIndex = 0;
            this.dgvFuncionarioPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarioPrincipal_CellContentClick);
            // 
            // dgvEndereco
            // 
            this.dgvEndereco.AllowUserToAddRows = false;
            this.dgvEndereco.AllowUserToDeleteRows = false;
            this.dgvEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdEndereco,
            this.clnLogradouroEndereco,
            this.clnNumeroEndereco,
            this.clnCepEndereco,
            this.clnBairroEndereco,
            this.clnCidadeEndereco,
            this.clnUfEndereco,
            this.clnFuncionarioEndereco});
            this.dgvEndereco.Location = new System.Drawing.Point(48, 444);
            this.dgvEndereco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEndereco.Name = "dgvEndereco";
            this.dgvEndereco.ReadOnly = true;
            this.dgvEndereco.RowHeadersVisible = false;
            this.dgvEndereco.RowHeadersWidth = 51;
            this.dgvEndereco.Size = new System.Drawing.Size(1316, 185);
            this.dgvEndereco.TabIndex = 1;
            // 
            // clnIdEndereco
            // 
            this.clnIdEndereco.Frozen = true;
            this.clnIdEndereco.HeaderText = "ID";
            this.clnIdEndereco.MinimumWidth = 6;
            this.clnIdEndereco.Name = "clnIdEndereco";
            this.clnIdEndereco.ReadOnly = true;
            this.clnIdEndereco.Width = 125;
            // 
            // clnLogradouroEndereco
            // 
            this.clnLogradouroEndereco.Frozen = true;
            this.clnLogradouroEndereco.HeaderText = "Logradouro";
            this.clnLogradouroEndereco.MinimumWidth = 6;
            this.clnLogradouroEndereco.Name = "clnLogradouroEndereco";
            this.clnLogradouroEndereco.ReadOnly = true;
            this.clnLogradouroEndereco.Width = 125;
            // 
            // clnNumeroEndereco
            // 
            this.clnNumeroEndereco.Frozen = true;
            this.clnNumeroEndereco.HeaderText = "Número";
            this.clnNumeroEndereco.MinimumWidth = 6;
            this.clnNumeroEndereco.Name = "clnNumeroEndereco";
            this.clnNumeroEndereco.ReadOnly = true;
            this.clnNumeroEndereco.Width = 125;
            // 
            // clnCepEndereco
            // 
            this.clnCepEndereco.Frozen = true;
            this.clnCepEndereco.HeaderText = "CEP";
            this.clnCepEndereco.MinimumWidth = 6;
            this.clnCepEndereco.Name = "clnCepEndereco";
            this.clnCepEndereco.ReadOnly = true;
            this.clnCepEndereco.Width = 125;
            // 
            // clnBairroEndereco
            // 
            this.clnBairroEndereco.Frozen = true;
            this.clnBairroEndereco.HeaderText = "Bairro";
            this.clnBairroEndereco.MinimumWidth = 6;
            this.clnBairroEndereco.Name = "clnBairroEndereco";
            this.clnBairroEndereco.ReadOnly = true;
            this.clnBairroEndereco.Width = 125;
            // 
            // clnCidadeEndereco
            // 
            this.clnCidadeEndereco.Frozen = true;
            this.clnCidadeEndereco.HeaderText = "Cidade";
            this.clnCidadeEndereco.MinimumWidth = 6;
            this.clnCidadeEndereco.Name = "clnCidadeEndereco";
            this.clnCidadeEndereco.ReadOnly = true;
            this.clnCidadeEndereco.Width = 125;
            // 
            // clnUfEndereco
            // 
            this.clnUfEndereco.Frozen = true;
            this.clnUfEndereco.HeaderText = "UF";
            this.clnUfEndereco.MinimumWidth = 6;
            this.clnUfEndereco.Name = "clnUfEndereco";
            this.clnUfEndereco.ReadOnly = true;
            this.clnUfEndereco.Width = 125;
            // 
            // clnFuncionarioEndereco
            // 
            this.clnFuncionarioEndereco.Frozen = true;
            this.clnFuncionarioEndereco.HeaderText = "Funcionario";
            this.clnFuncionarioEndereco.MinimumWidth = 6;
            this.clnFuncionarioEndereco.Name = "clnFuncionarioEndereco";
            this.clnFuncionarioEndereco.ReadOnly = true;
            this.clnFuncionarioEndereco.Width = 125;
            // 
            // clnId
            // 
            this.clnId.Frozen = true;
            this.clnId.HeaderText = "ID";
            this.clnId.MinimumWidth = 6;
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 40;
            // 
            // clnNome
            // 
            this.clnNome.Frozen = true;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.MinimumWidth = 6;
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 120;
            // 
            // clnDataNasc
            // 
            this.clnDataNasc.Frozen = true;
            this.clnDataNasc.HeaderText = "Data de Nasc.";
            this.clnDataNasc.MinimumWidth = 6;
            this.clnDataNasc.Name = "clnDataNasc";
            this.clnDataNasc.ReadOnly = true;
            // 
            // clnCpf
            // 
            this.clnCpf.Frozen = true;
            this.clnCpf.HeaderText = "CPF";
            this.clnCpf.MinimumWidth = 6;
            this.clnCpf.Name = "clnCpf";
            this.clnCpf.ReadOnly = true;
            // 
            // clnRG
            // 
            this.clnRG.Frozen = true;
            this.clnRG.HeaderText = "RG";
            this.clnRG.MinimumWidth = 6;
            this.clnRG.Name = "clnRG";
            this.clnRG.ReadOnly = true;
            // 
            // clnSalario
            // 
            this.clnSalario.Frozen = true;
            this.clnSalario.HeaderText = "Salário";
            this.clnSalario.MinimumWidth = 6;
            this.clnSalario.Name = "clnSalario";
            this.clnSalario.ReadOnly = true;
            this.clnSalario.Width = 80;
            // 
            // clnEmail
            // 
            this.clnEmail.Frozen = true;
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.MinimumWidth = 6;
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Width = 150;
            // 
            // clnPeriodo
            // 
            this.clnPeriodo.Frozen = true;
            this.clnPeriodo.HeaderText = "Período";
            this.clnPeriodo.MinimumWidth = 6;
            this.clnPeriodo.Name = "clnPeriodo";
            this.clnPeriodo.ReadOnly = true;
            // 
            // clnAdmissao
            // 
            this.clnAdmissao.Frozen = true;
            this.clnAdmissao.HeaderText = "Admissão";
            this.clnAdmissao.MinimumWidth = 6;
            this.clnAdmissao.Name = "clnAdmissao";
            this.clnAdmissao.ReadOnly = true;
            this.clnAdmissao.Width = 115;
            // 
            // clnCargo
            // 
            this.clnCargo.Frozen = true;
            this.clnCargo.HeaderText = "Cargo";
            this.clnCargo.MinimumWidth = 6;
            this.clnCargo.Name = "clnCargo";
            this.clnCargo.ReadOnly = true;
            this.clnCargo.Width = 125;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(75, 71);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(464, 22);
            this.txtPesquisar.TabIndex = 2;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // dgvTelefone
            // 
            this.dgvTelefone.AllowUserToAddRows = false;
            this.dgvTelefone.AllowUserToDeleteRows = false;
            this.dgvTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdTelefone,
            this.clnTipoTelefone,
            this.clnNumeroTelefone,
            this.clnFuncionarioTelefone});
            this.dgvTelefone.Location = new System.Drawing.Point(48, 654);
            this.dgvTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTelefone.Name = "dgvTelefone";
            this.dgvTelefone.ReadOnly = true;
            this.dgvTelefone.RowHeadersVisible = false;
            this.dgvTelefone.RowHeadersWidth = 51;
            this.dgvTelefone.Size = new System.Drawing.Size(1316, 185);
            this.dgvTelefone.TabIndex = 3;
            // 
            // clnIdTelefone
            // 
            this.clnIdTelefone.Frozen = true;
            this.clnIdTelefone.HeaderText = "ID";
            this.clnIdTelefone.MinimumWidth = 6;
            this.clnIdTelefone.Name = "clnIdTelefone";
            this.clnIdTelefone.ReadOnly = true;
            this.clnIdTelefone.Width = 125;
            // 
            // clnTipoTelefone
            // 
            this.clnTipoTelefone.Frozen = true;
            this.clnTipoTelefone.HeaderText = "Tipo";
            this.clnTipoTelefone.MinimumWidth = 6;
            this.clnTipoTelefone.Name = "clnTipoTelefone";
            this.clnTipoTelefone.ReadOnly = true;
            this.clnTipoTelefone.Width = 125;
            // 
            // clnNumeroTelefone
            // 
            this.clnNumeroTelefone.Frozen = true;
            this.clnNumeroTelefone.HeaderText = "Número";
            this.clnNumeroTelefone.MinimumWidth = 6;
            this.clnNumeroTelefone.Name = "clnNumeroTelefone";
            this.clnNumeroTelefone.ReadOnly = true;
            this.clnNumeroTelefone.Width = 125;
            // 
            // clnFuncionarioTelefone
            // 
            this.clnFuncionarioTelefone.Frozen = true;
            this.clnFuncionarioTelefone.HeaderText = "Funcionario";
            this.clnFuncionarioTelefone.MinimumWidth = 6;
            this.clnFuncionarioTelefone.Name = "clnFuncionarioTelefone";
            this.clnFuncionarioTelefone.ReadOnly = true;
            this.clnFuncionarioTelefone.Width = 125;
            // 
            // FrmFuncionarioListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1424, 903);
            this.Controls.Add(this.dgvTelefone);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dgvEndereco);
            this.Controls.Add(this.dgvFuncionarioPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmFuncionarioListar";
            this.Text = "FrmFuncionarioListar";
            this.Load += new System.EventHandler(this.FrmFuncionarioListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarioPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionarioPrincipal;
        private System.Windows.Forms.DataGridView dgvEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLogradouroEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCepEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBairroEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCidadeEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUfEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFuncionarioEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAdmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCargo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dgvTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipoTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFuncionarioTelefone;
    }
}