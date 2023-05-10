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
            this.dgvEndereco = new System.Windows.Forms.DataGridView();
            this.clnIdEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLogradouroEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumeroEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCepEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBairroEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCidadeEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUfEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFuncionarioEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTelefone = new System.Windows.Forms.DataGridView();
            this.clnIdTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTipoTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumeroTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFuncionarioTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtivos = new System.Windows.Forms.Button();
            this.btnDemitido = new System.Windows.Forms.Button();
            this.gpListaAtivos = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gpListaDemitidos = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDadosDemitidos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEnderecoDemitidos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTelefoneDemitidos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarioPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).BeginInit();
            this.gpListaAtivos.SuspendLayout();
            this.gpListaDemitidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosDemitidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecoDemitidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefoneDemitidos)).BeginInit();
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
            this.dgvFuncionarioPrincipal.Location = new System.Drawing.Point(21, 66);
            this.dgvFuncionarioPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFuncionarioPrincipal.Name = "dgvFuncionarioPrincipal";
            this.dgvFuncionarioPrincipal.ReadOnly = true;
            this.dgvFuncionarioPrincipal.RowHeadersVisible = false;
            this.dgvFuncionarioPrincipal.RowHeadersWidth = 51;
            this.dgvFuncionarioPrincipal.Size = new System.Drawing.Size(1365, 287);
            this.dgvFuncionarioPrincipal.TabIndex = 0;
            this.dgvFuncionarioPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarioPrincipal_CellContentClick);
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
            this.clnDataNasc.Width = 125;
            // 
            // clnCpf
            // 
            this.clnCpf.Frozen = true;
            this.clnCpf.HeaderText = "CPF";
            this.clnCpf.MinimumWidth = 6;
            this.clnCpf.Name = "clnCpf";
            this.clnCpf.ReadOnly = true;
            this.clnCpf.Width = 125;
            // 
            // clnRG
            // 
            this.clnRG.Frozen = true;
            this.clnRG.HeaderText = "RG";
            this.clnRG.MinimumWidth = 6;
            this.clnRG.Name = "clnRG";
            this.clnRG.ReadOnly = true;
            this.clnRG.Width = 125;
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
            this.clnPeriodo.Width = 70;
            // 
            // clnAdmissao
            // 
            this.clnAdmissao.Frozen = true;
            this.clnAdmissao.HeaderText = "Admissão";
            this.clnAdmissao.MinimumWidth = 6;
            this.clnAdmissao.Name = "clnAdmissao";
            this.clnAdmissao.ReadOnly = true;
            this.clnAdmissao.Width = 120;
            // 
            // clnCargo
            // 
            this.clnCargo.Frozen = true;
            this.clnCargo.HeaderText = "Cargo";
            this.clnCargo.MinimumWidth = 6;
            this.clnCargo.Name = "clnCargo";
            this.clnCargo.ReadOnly = true;
            this.clnCargo.Width = 120;
            // 
            // dgvEndereco
            // 
            this.dgvEndereco.AllowUserToAddRows = false;
            this.dgvEndereco.AllowUserToDeleteRows = false;
            this.dgvEndereco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.dgvEndereco.Location = new System.Drawing.Point(21, 404);
            this.dgvEndereco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEndereco.Name = "dgvEndereco";
            this.dgvEndereco.ReadOnly = true;
            this.dgvEndereco.RowHeadersVisible = false;
            this.dgvEndereco.RowHeadersWidth = 51;
            this.dgvEndereco.Size = new System.Drawing.Size(807, 185);
            this.dgvEndereco.TabIndex = 1;
            // 
            // clnIdEndereco
            // 
            this.clnIdEndereco.Frozen = true;
            this.clnIdEndereco.HeaderText = "ID";
            this.clnIdEndereco.MinimumWidth = 6;
            this.clnIdEndereco.Name = "clnIdEndereco";
            this.clnIdEndereco.ReadOnly = true;
            this.clnIdEndereco.Width = 49;
            // 
            // clnLogradouroEndereco
            // 
            this.clnLogradouroEndereco.Frozen = true;
            this.clnLogradouroEndereco.HeaderText = "Logradouro";
            this.clnLogradouroEndereco.MinimumWidth = 6;
            this.clnLogradouroEndereco.Name = "clnLogradouroEndereco";
            this.clnLogradouroEndereco.ReadOnly = true;
            this.clnLogradouroEndereco.Width = 106;
            // 
            // clnNumeroEndereco
            // 
            this.clnNumeroEndereco.Frozen = true;
            this.clnNumeroEndereco.HeaderText = "Número";
            this.clnNumeroEndereco.MinimumWidth = 6;
            this.clnNumeroEndereco.Name = "clnNumeroEndereco";
            this.clnNumeroEndereco.ReadOnly = true;
            this.clnNumeroEndereco.Width = 84;
            // 
            // clnCepEndereco
            // 
            this.clnCepEndereco.Frozen = true;
            this.clnCepEndereco.HeaderText = "CEP";
            this.clnCepEndereco.MinimumWidth = 6;
            this.clnCepEndereco.Name = "clnCepEndereco";
            this.clnCepEndereco.ReadOnly = true;
            this.clnCepEndereco.Width = 63;
            // 
            // clnBairroEndereco
            // 
            this.clnBairroEndereco.Frozen = true;
            this.clnBairroEndereco.HeaderText = "Bairro";
            this.clnBairroEndereco.MinimumWidth = 6;
            this.clnBairroEndereco.Name = "clnBairroEndereco";
            this.clnBairroEndereco.ReadOnly = true;
            this.clnBairroEndereco.Width = 72;
            // 
            // clnCidadeEndereco
            // 
            this.clnCidadeEndereco.Frozen = true;
            this.clnCidadeEndereco.HeaderText = "Cidade";
            this.clnCidadeEndereco.MinimumWidth = 6;
            this.clnCidadeEndereco.Name = "clnCidadeEndereco";
            this.clnCidadeEndereco.ReadOnly = true;
            this.clnCidadeEndereco.Width = 80;
            // 
            // clnUfEndereco
            // 
            this.clnUfEndereco.Frozen = true;
            this.clnUfEndereco.HeaderText = "UF";
            this.clnUfEndereco.MinimumWidth = 6;
            this.clnUfEndereco.Name = "clnUfEndereco";
            this.clnUfEndereco.ReadOnly = true;
            this.clnUfEndereco.Width = 54;
            // 
            // clnFuncionarioEndereco
            // 
            this.clnFuncionarioEndereco.Frozen = true;
            this.clnFuncionarioEndereco.HeaderText = "Funcionario";
            this.clnFuncionarioEndereco.MinimumWidth = 6;
            this.clnFuncionarioEndereco.Name = "clnFuncionarioEndereco";
            this.clnFuncionarioEndereco.ReadOnly = true;
            this.clnFuncionarioEndereco.Width = 106;
            // 
            // dgvTelefone
            // 
            this.dgvTelefone.AllowUserToAddRows = false;
            this.dgvTelefone.AllowUserToDeleteRows = false;
            this.dgvTelefone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdTelefone,
            this.clnTipoTelefone,
            this.clnNumeroTelefone,
            this.clnFuncionarioTelefone});
            this.dgvTelefone.Location = new System.Drawing.Point(957, 404);
            this.dgvTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTelefone.Name = "dgvTelefone";
            this.dgvTelefone.ReadOnly = true;
            this.dgvTelefone.RowHeadersVisible = false;
            this.dgvTelefone.RowHeadersWidth = 51;
            this.dgvTelefone.Size = new System.Drawing.Size(431, 185);
            this.dgvTelefone.TabIndex = 3;
            // 
            // clnIdTelefone
            // 
            this.clnIdTelefone.Frozen = true;
            this.clnIdTelefone.HeaderText = "ID";
            this.clnIdTelefone.MinimumWidth = 6;
            this.clnIdTelefone.Name = "clnIdTelefone";
            this.clnIdTelefone.ReadOnly = true;
            this.clnIdTelefone.Width = 49;
            // 
            // clnTipoTelefone
            // 
            this.clnTipoTelefone.Frozen = true;
            this.clnTipoTelefone.HeaderText = "Tipo";
            this.clnTipoTelefone.MinimumWidth = 6;
            this.clnTipoTelefone.Name = "clnTipoTelefone";
            this.clnTipoTelefone.ReadOnly = true;
            this.clnTipoTelefone.Width = 64;
            // 
            // clnNumeroTelefone
            // 
            this.clnNumeroTelefone.Frozen = true;
            this.clnNumeroTelefone.HeaderText = "Número";
            this.clnNumeroTelefone.MinimumWidth = 6;
            this.clnNumeroTelefone.Name = "clnNumeroTelefone";
            this.clnNumeroTelefone.ReadOnly = true;
            this.clnNumeroTelefone.Width = 84;
            // 
            // clnFuncionarioTelefone
            // 
            this.clnFuncionarioTelefone.Frozen = true;
            this.clnFuncionarioTelefone.HeaderText = "Funcionario";
            this.clnFuncionarioTelefone.MinimumWidth = 6;
            this.clnFuncionarioTelefone.Name = "clnFuncionarioTelefone";
            this.clnFuncionarioTelefone.ReadOnly = true;
            this.clnFuncionarioTelefone.Width = 106;
            // 
            // btnAtivos
            // 
            this.btnAtivos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAtivos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtivos.Location = new System.Drawing.Point(583, 46);
            this.btnAtivos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtivos.Name = "btnAtivos";
            this.btnAtivos.Size = new System.Drawing.Size(115, 52);
            this.btnAtivos.TabIndex = 52;
            this.btnAtivos.Text = "ATIVOS";
            this.btnAtivos.UseVisualStyleBackColor = false;
            this.btnAtivos.Click += new System.EventHandler(this.btnAtivos_Click);
            // 
            // btnDemitido
            // 
            this.btnDemitido.BackColor = System.Drawing.Color.Crimson;
            this.btnDemitido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDemitido.Location = new System.Drawing.Point(737, 46);
            this.btnDemitido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDemitido.Name = "btnDemitido";
            this.btnDemitido.Size = new System.Drawing.Size(115, 52);
            this.btnDemitido.TabIndex = 53;
            this.btnDemitido.Text = "DEMITIDOS";
            this.btnDemitido.UseVisualStyleBackColor = false;
            this.btnDemitido.Click += new System.EventHandler(this.btnDemitido_Click);
            // 
            // gpListaAtivos
            // 
            this.gpListaAtivos.Controls.Add(this.label7);
            this.gpListaAtivos.Controls.Add(this.label6);
            this.gpListaAtivos.Controls.Add(this.label5);
            this.gpListaAtivos.Controls.Add(this.dgvFuncionarioPrincipal);
            this.gpListaAtivos.Controls.Add(this.dgvEndereco);
            this.gpListaAtivos.Controls.Add(this.dgvTelefone);
            this.gpListaAtivos.Location = new System.Drawing.Point(37, 156);
            this.gpListaAtivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpListaAtivos.Name = "gpListaAtivos";
            this.gpListaAtivos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpListaAtivos.Size = new System.Drawing.Size(1404, 622);
            this.gpListaAtivos.TabIndex = 54;
            this.gpListaAtivos.TabStop = false;
            this.gpListaAtivos.Text = "Funcionarios Ativos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(939, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Telefones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Endereços";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dados Pessoais";
            // 
            // gpListaDemitidos
            // 
            this.gpListaDemitidos.Controls.Add(this.label4);
            this.gpListaDemitidos.Controls.Add(this.label3);
            this.gpListaDemitidos.Controls.Add(this.label2);
            this.gpListaDemitidos.Controls.Add(this.dgvDadosDemitidos);
            this.gpListaDemitidos.Controls.Add(this.dgvEnderecoDemitidos);
            this.gpListaDemitidos.Controls.Add(this.dgvTelefoneDemitidos);
            this.gpListaDemitidos.Location = new System.Drawing.Point(37, 146);
            this.gpListaDemitidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpListaDemitidos.Name = "gpListaDemitidos";
            this.gpListaDemitidos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpListaDemitidos.Size = new System.Drawing.Size(1471, 610);
            this.gpListaDemitidos.TabIndex = 55;
            this.gpListaDemitidos.TabStop = false;
            this.gpListaDemitidos.Text = "Funcionarios Demitidos";
            this.gpListaDemitidos.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(987, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endereços";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dados Pessoais";
            // 
            // dgvDadosDemitidos
            // 
            this.dgvDadosDemitidos.AllowUserToAddRows = false;
            this.dgvDadosDemitidos.AllowUserToDeleteRows = false;
            this.dgvDadosDemitidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDadosDemitidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosDemitidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvDadosDemitidos.Location = new System.Drawing.Point(21, 65);
            this.dgvDadosDemitidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDadosDemitidos.Name = "dgvDadosDemitidos";
            this.dgvDadosDemitidos.ReadOnly = true;
            this.dgvDadosDemitidos.RowHeadersVisible = false;
            this.dgvDadosDemitidos.RowHeadersWidth = 51;
            this.dgvDadosDemitidos.Size = new System.Drawing.Size(1307, 287);
            this.dgvDadosDemitidos.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 49;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 73;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Data de Nasc.";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 122;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 62;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "RG";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 56;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "Salário";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 79;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "Email";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.Frozen = true;
            this.dataGridViewTextBoxColumn8.HeaderText = "Período";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 84;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.Frozen = true;
            this.dataGridViewTextBoxColumn9.HeaderText = "Admissão";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 97;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.Frozen = true;
            this.dataGridViewTextBoxColumn10.HeaderText = "Cargo";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 73;
            // 
            // dgvEnderecoDemitidos
            // 
            this.dgvEnderecoDemitidos.AllowUserToAddRows = false;
            this.dgvEnderecoDemitidos.AllowUserToDeleteRows = false;
            this.dgvEnderecoDemitidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEnderecoDemitidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnderecoDemitidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.dgvEnderecoDemitidos.Location = new System.Drawing.Point(21, 399);
            this.dgvEnderecoDemitidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEnderecoDemitidos.Name = "dgvEnderecoDemitidos";
            this.dgvEnderecoDemitidos.ReadOnly = true;
            this.dgvEnderecoDemitidos.RowHeadersVisible = false;
            this.dgvEnderecoDemitidos.RowHeadersWidth = 51;
            this.dgvEnderecoDemitidos.Size = new System.Drawing.Size(683, 185);
            this.dgvEnderecoDemitidos.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.Frozen = true;
            this.dataGridViewTextBoxColumn11.HeaderText = "ID";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 49;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.Frozen = true;
            this.dataGridViewTextBoxColumn12.HeaderText = "Logradouro";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 106;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.Frozen = true;
            this.dataGridViewTextBoxColumn13.HeaderText = "Número";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 84;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.Frozen = true;
            this.dataGridViewTextBoxColumn14.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 63;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.Frozen = true;
            this.dataGridViewTextBoxColumn15.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 72;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.Frozen = true;
            this.dataGridViewTextBoxColumn16.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 80;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.Frozen = true;
            this.dataGridViewTextBoxColumn17.HeaderText = "UF";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 54;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.Frozen = true;
            this.dataGridViewTextBoxColumn18.HeaderText = "Funcionario";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 106;
            // 
            // dgvTelefoneDemitidos
            // 
            this.dgvTelefoneDemitidos.AllowUserToAddRows = false;
            this.dgvTelefoneDemitidos.AllowUserToDeleteRows = false;
            this.dgvTelefoneDemitidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTelefoneDemitidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefoneDemitidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22});
            this.dgvTelefoneDemitidos.Location = new System.Drawing.Point(991, 399);
            this.dgvTelefoneDemitidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTelefoneDemitidos.Name = "dgvTelefoneDemitidos";
            this.dgvTelefoneDemitidos.ReadOnly = true;
            this.dgvTelefoneDemitidos.RowHeadersVisible = false;
            this.dgvTelefoneDemitidos.RowHeadersWidth = 51;
            this.dgvTelefoneDemitidos.Size = new System.Drawing.Size(337, 185);
            this.dgvTelefoneDemitidos.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.Frozen = true;
            this.dataGridViewTextBoxColumn19.HeaderText = "ID";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 49;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.Frozen = true;
            this.dataGridViewTextBoxColumn20.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 64;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.Frozen = true;
            this.dataGridViewTextBoxColumn21.HeaderText = "Número";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 84;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.Frozen = true;
            this.dataGridViewTextBoxColumn22.HeaderText = "Funcionario";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 106;
            // 
            // FrmFuncionarioListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1539, 789);
            this.Controls.Add(this.gpListaDemitidos);
            this.Controls.Add(this.gpListaAtivos);
            this.Controls.Add(this.btnDemitido);
            this.Controls.Add(this.btnAtivos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmFuncionarioListar";
            this.Text = "Listar Funcionarios";
            this.Load += new System.EventHandler(this.FrmFuncionarioListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarioPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).EndInit();
            this.gpListaAtivos.ResumeLayout(false);
            this.gpListaAtivos.PerformLayout();
            this.gpListaDemitidos.ResumeLayout(false);
            this.gpListaDemitidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosDemitidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecoDemitidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefoneDemitidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionarioPrincipal;
        private System.Windows.Forms.DataGridView dgvEndereco;
        private System.Windows.Forms.DataGridView dgvTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipoTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFuncionarioTelefone;
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
        private System.Windows.Forms.Button btnAtivos;
        private System.Windows.Forms.Button btnDemitido;
        private System.Windows.Forms.GroupBox gpListaAtivos;
        private System.Windows.Forms.GroupBox gpListaDemitidos;
        private System.Windows.Forms.DataGridView dgvDadosDemitidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridView dgvEnderecoDemitidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridView dgvTelefoneDemitidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}