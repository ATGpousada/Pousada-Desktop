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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnIdEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLogradouroEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumeroEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCepEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBairroEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCidadeEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUfEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFuncionarioEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarioPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dgvFuncionarioPrincipal.Location = new System.Drawing.Point(36, 101);
            this.dgvFuncionarioPrincipal.Name = "dgvFuncionarioPrincipal";
            this.dgvFuncionarioPrincipal.ReadOnly = true;
            this.dgvFuncionarioPrincipal.RowHeadersVisible = false;
            this.dgvFuncionarioPrincipal.Size = new System.Drawing.Size(964, 233);
            this.dgvFuncionarioPrincipal.TabIndex = 0;
            // 
            // clnId
            // 
            this.clnId.Frozen = true;
            this.clnId.HeaderText = "ID";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 60;
            // 
            // clnNome
            // 
            this.clnNome.Frozen = true;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            // 
            // clnDataNasc
            // 
            this.clnDataNasc.Frozen = true;
            this.clnDataNasc.HeaderText = "Data de Nasc.";
            this.clnDataNasc.Name = "clnDataNasc";
            this.clnDataNasc.ReadOnly = true;
            // 
            // clnCpf
            // 
            this.clnCpf.Frozen = true;
            this.clnCpf.HeaderText = "CPF";
            this.clnCpf.Name = "clnCpf";
            this.clnCpf.ReadOnly = true;
            // 
            // clnRG
            // 
            this.clnRG.Frozen = true;
            this.clnRG.HeaderText = "RG";
            this.clnRG.Name = "clnRG";
            this.clnRG.ReadOnly = true;
            // 
            // clnSalario
            // 
            this.clnSalario.Frozen = true;
            this.clnSalario.HeaderText = "Salário";
            this.clnSalario.Name = "clnSalario";
            this.clnSalario.ReadOnly = true;
            // 
            // clnEmail
            // 
            this.clnEmail.Frozen = true;
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            // 
            // clnPeriodo
            // 
            this.clnPeriodo.Frozen = true;
            this.clnPeriodo.HeaderText = "Período";
            this.clnPeriodo.Name = "clnPeriodo";
            this.clnPeriodo.ReadOnly = true;
            // 
            // clnAdmissao
            // 
            this.clnAdmissao.Frozen = true;
            this.clnAdmissao.HeaderText = "Admissão";
            this.clnAdmissao.Name = "clnAdmissao";
            this.clnAdmissao.ReadOnly = true;
            // 
            // clnCargo
            // 
            this.clnCargo.Frozen = true;
            this.clnCargo.HeaderText = "Cargo";
            this.clnCargo.Name = "clnCargo";
            this.clnCargo.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdEndereco,
            this.clnLogradouroEndereco,
            this.clnNumeroEndereco,
            this.clnCepEndereco,
            this.clnBairroEndereco,
            this.clnCidadeEndereco,
            this.clnUfEndereco,
            this.clnFuncionarioEndereco});
            this.dataGridView1.Location = new System.Drawing.Point(36, 393);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(803, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // clnIdEndereco
            // 
            this.clnIdEndereco.Frozen = true;
            this.clnIdEndereco.HeaderText = "ID";
            this.clnIdEndereco.Name = "clnIdEndereco";
            this.clnIdEndereco.ReadOnly = true;
            // 
            // clnLogradouroEndereco
            // 
            this.clnLogradouroEndereco.Frozen = true;
            this.clnLogradouroEndereco.HeaderText = "Logradouro";
            this.clnLogradouroEndereco.Name = "clnLogradouroEndereco";
            this.clnLogradouroEndereco.ReadOnly = true;
            // 
            // clnNumeroEndereco
            // 
            this.clnNumeroEndereco.Frozen = true;
            this.clnNumeroEndereco.HeaderText = "Número";
            this.clnNumeroEndereco.Name = "clnNumeroEndereco";
            this.clnNumeroEndereco.ReadOnly = true;
            // 
            // clnCepEndereco
            // 
            this.clnCepEndereco.Frozen = true;
            this.clnCepEndereco.HeaderText = "CEP";
            this.clnCepEndereco.Name = "clnCepEndereco";
            this.clnCepEndereco.ReadOnly = true;
            // 
            // clnBairroEndereco
            // 
            this.clnBairroEndereco.Frozen = true;
            this.clnBairroEndereco.HeaderText = "Bairro";
            this.clnBairroEndereco.Name = "clnBairroEndereco";
            this.clnBairroEndereco.ReadOnly = true;
            // 
            // clnCidadeEndereco
            // 
            this.clnCidadeEndereco.Frozen = true;
            this.clnCidadeEndereco.HeaderText = "Cidade";
            this.clnCidadeEndereco.Name = "clnCidadeEndereco";
            this.clnCidadeEndereco.ReadOnly = true;
            // 
            // clnUfEndereco
            // 
            this.clnUfEndereco.Frozen = true;
            this.clnUfEndereco.HeaderText = "UF";
            this.clnUfEndereco.Name = "clnUfEndereco";
            this.clnUfEndereco.ReadOnly = true;
            // 
            // clnFuncionarioEndereco
            // 
            this.clnFuncionarioEndereco.Frozen = true;
            this.clnFuncionarioEndereco.HeaderText = "Funcionario";
            this.clnFuncionarioEndereco.Name = "clnFuncionarioEndereco";
            this.clnFuncionarioEndereco.ReadOnly = true;
            // 
            // FrmFuncionarioListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1151, 656);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvFuncionarioPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFuncionarioListar";
            this.Text = "FrmFuncionarioListar";
            this.Load += new System.EventHandler(this.FrmFuncionarioListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarioPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionarioPrincipal;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLogradouroEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCepEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBairroEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCidadeEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUfEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFuncionarioEndereco;
    }
}