namespace Pousada_desktop
{
    partial class CadastrarFuncionario
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
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.btnOlhoSenha = new System.Windows.Forms.Button();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCepEnd = new System.Windows.Forms.MaskedTextBox();
            this.cmbUfEnd = new System.Windows.Forms.ComboBox();
            this.txtCidadeEnd = new System.Windows.Forms.TextBox();
            this.txtLogradouroEnd = new System.Windows.Forms.TextBox();
            this.txtNumeroEnd = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBairroEnd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNumeroTel2 = new System.Windows.Forms.MaskedTextBox();
            this.txtNumeroTel = new System.Windows.Forms.MaskedTextBox();
            this.btnAdicionarNumero = new System.Windows.Forms.Button();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.cmbTipoTel2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoTel = new System.Windows.Forms.ComboBox();
            this.gbDados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.txtCpf);
            this.gbDados.Controls.Add(this.txtRg);
            this.gbDados.Controls.Add(this.btnOlhoSenha);
            this.gbDados.Controls.Add(this.dtpDataNasc);
            this.gbDados.Controls.Add(this.txtSenha);
            this.gbDados.Controls.Add(this.label17);
            this.gbDados.Controls.Add(this.cmbPeriodo);
            this.gbDados.Controls.Add(this.label19);
            this.gbDados.Controls.Add(this.label20);
            this.gbDados.Controls.Add(this.label21);
            this.gbDados.Controls.Add(this.label22);
            this.gbDados.Controls.Add(this.cmbCargo);
            this.gbDados.Controls.Add(this.txtSalario);
            this.gbDados.Controls.Add(this.label23);
            this.gbDados.Controls.Add(this.label24);
            this.gbDados.Controls.Add(this.txtEmail);
            this.gbDados.Controls.Add(this.label25);
            this.gbDados.Controls.Add(this.txtNome);
            this.gbDados.Controls.Add(this.label26);
            this.gbDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbDados.Location = new System.Drawing.Point(128, 69);
            this.gbDados.Margin = new System.Windows.Forms.Padding(4);
            this.gbDados.Name = "gbDados";
            this.gbDados.Padding = new System.Windows.Forms.Padding(4);
            this.gbDados.Size = new System.Drawing.Size(1017, 306);
            this.gbDados.TabIndex = 1;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados Pessoais";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(755, 241);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(156, 29);
            this.txtCpf.TabIndex = 49;
            this.txtCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCpf_MaskInputRejected);
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(755, 163);
            this.txtRg.Mask = "00.000.000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(156, 29);
            this.txtRg.TabIndex = 48;
            this.txtRg.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtRg_MaskInputRejected);
            // 
            // btnOlhoSenha
            // 
            this.btnOlhoSenha.BackgroundImage = global::Pousada_desktop.Properties.Resources.olho;
            this.btnOlhoSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOlhoSenha.Location = new System.Drawing.Point(299, 240);
            this.btnOlhoSenha.Margin = new System.Windows.Forms.Padding(4);
            this.btnOlhoSenha.Name = "btnOlhoSenha";
            this.btnOlhoSenha.Size = new System.Drawing.Size(49, 30);
            this.btnOlhoSenha.TabIndex = 47;
            this.btnOlhoSenha.UseVisualStyleBackColor = true;
            this.btnOlhoSenha.Click += new System.EventHandler(this.btnOlhoSenha_Click);
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.CustomFormat = "dd/MM/yyyy";
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataNasc.Location = new System.Drawing.Point(72, 161);
            this.dtpDataNasc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDataNasc.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.dtpDataNasc.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(193, 29);
            this.dtpDataNasc.TabIndex = 46;
            this.dtpDataNasc.Value = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dtpDataNasc.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(69, 240);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(220, 29);
            this.txtSenha.TabIndex = 45;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(67, 212);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 25);
            this.label17.TabIndex = 44;
            this.label17.Text = "SENHA";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Items.AddRange(new object[] {
            "Manhã",
            "Tarde",
            "Noturno"});
            this.cmbPeriodo.Location = new System.Drawing.Point(755, 85);
            this.cmbPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(201, 32);
            this.cmbPeriodo.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(756, 57);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 25);
            this.label19.TabIndex = 38;
            this.label19.Text = "PERÍODO";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(749, 212);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 25);
            this.label20.TabIndex = 37;
            this.label20.Text = "CPF";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(756, 134);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 25);
            this.label21.TabIndex = 34;
            this.label21.Text = "RG";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(412, 134);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 25);
            this.label22.TabIndex = 33;
            this.label22.Text = "CARGO";
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(415, 160);
            this.cmbCargo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(201, 32);
            this.cmbCargo.TabIndex = 32;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(417, 240);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(199, 29);
            this.txtSalario.TabIndex = 31;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(412, 214);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 25);
            this.label23.TabIndex = 30;
            this.label23.Text = "SALÁRIO";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label24.Location = new System.Drawing.Point(67, 134);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(179, 25);
            this.label24.TabIndex = 29;
            this.label24.Text = "DATA DE NASC.";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(415, 84);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 29);
            this.txtEmail.TabIndex = 27;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label25.Location = new System.Drawing.Point(409, 57);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 25);
            this.label25.TabIndex = 26;
            this.label25.Text = "EMAIL";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(69, 84);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(220, 29);
            this.txtNome.TabIndex = 25;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label26.Location = new System.Drawing.Point(67, 57);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(76, 25);
            this.label26.TabIndex = 24;
            this.label26.Text = "NOME";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInserir.Location = new System.Drawing.Point(1018, 13);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(137, 58);
            this.btnInserir.TabIndex = 40;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCepEnd);
            this.groupBox1.Controls.Add(this.cmbUfEnd);
            this.groupBox1.Controls.Add(this.txtCidadeEnd);
            this.groupBox1.Controls.Add(this.txtLogradouroEnd);
            this.groupBox1.Controls.Add(this.txtNumeroEnd);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtBairroEnd);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(128, 411);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(578, 418);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCepEnd
            // 
            this.txtCepEnd.Location = new System.Drawing.Point(393, 309);
            this.txtCepEnd.Mask = "00000-000";
            this.txtCepEnd.Name = "txtCepEnd";
            this.txtCepEnd.Size = new System.Drawing.Size(109, 29);
            this.txtCepEnd.TabIndex = 25;
            this.txtCepEnd.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCepEnd_MaskInputRejected);
            // 
            // cmbUfEnd
            // 
            this.cmbUfEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUfEnd.FormattingEnabled = true;
            this.cmbUfEnd.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "RJ",
            "RN",
            "PR",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cmbUfEnd.Location = new System.Drawing.Point(391, 197);
            this.cmbUfEnd.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUfEnd.Name = "cmbUfEnd";
            this.cmbUfEnd.Size = new System.Drawing.Size(63, 32);
            this.cmbUfEnd.TabIndex = 24;
            // 
            // txtCidadeEnd
            // 
            this.txtCidadeEnd.Location = new System.Drawing.Point(69, 200);
            this.txtCidadeEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidadeEnd.Name = "txtCidadeEnd";
            this.txtCidadeEnd.Size = new System.Drawing.Size(213, 29);
            this.txtCidadeEnd.TabIndex = 21;
            // 
            // txtLogradouroEnd
            // 
            this.txtLogradouroEnd.Location = new System.Drawing.Point(69, 80);
            this.txtLogradouroEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogradouroEnd.Name = "txtLogradouroEnd";
            this.txtLogradouroEnd.Size = new System.Drawing.Size(213, 29);
            this.txtLogradouroEnd.TabIndex = 20;
            // 
            // txtNumeroEnd
            // 
            this.txtNumeroEnd.Location = new System.Drawing.Point(391, 73);
            this.txtNumeroEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroEnd.Name = "txtNumeroEnd";
            this.txtNumeroEnd.Size = new System.Drawing.Size(111, 29);
            this.txtNumeroEnd.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(389, 281);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 25);
            this.label16.TabIndex = 17;
            this.label16.Text = "CEP";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(386, 162);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = "UF";
            // 
            // txtBairroEnd
            // 
            this.txtBairroEnd.Location = new System.Drawing.Point(69, 309);
            this.txtBairroEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairroEnd.Name = "txtBairroEnd";
            this.txtBairroEnd.Size = new System.Drawing.Size(203, 29);
            this.txtBairroEnd.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(64, 171);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 25);
            this.label14.TabIndex = 15;
            this.label14.Text = "CIDADE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(388, 44);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "NÚMERO";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(64, 280);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 25);
            this.label15.TabIndex = 16;
            this.label15.Text = "BAIRRO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(64, 51);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "LOGRADOURO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNumeroTel2);
            this.groupBox2.Controls.Add(this.txtNumeroTel);
            this.groupBox2.Controls.Add(this.btnAdicionarNumero);
            this.groupBox2.Controls.Add(this.labelTipo);
            this.groupBox2.Controls.Add(this.labelNumero);
            this.groupBox2.Controls.Add(this.cmbTipoTel2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbTipoTel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(748, 411);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(397, 418);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Telefone";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtNumeroTel2
            // 
            this.txtNumeroTel2.Location = new System.Drawing.Point(93, 253);
            this.txtNumeroTel2.Mask = "+00 (00) 00000-0000";
            this.txtNumeroTel2.Name = "txtNumeroTel2";
            this.txtNumeroTel2.Size = new System.Drawing.Size(206, 29);
            this.txtNumeroTel2.TabIndex = 48;
            this.txtNumeroTel2.Visible = false;
            this.txtNumeroTel2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtNumeroTel2_MaskInputRejected);
            // 
            // txtNumeroTel
            // 
            this.txtNumeroTel.Location = new System.Drawing.Point(93, 80);
            this.txtNumeroTel.Mask = "+00 (00) 00000-0000";
            this.txtNumeroTel.Name = "txtNumeroTel";
            this.txtNumeroTel.Size = new System.Drawing.Size(206, 29);
            this.txtNumeroTel.TabIndex = 47;
            this.txtNumeroTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtNumeroTel_MaskInputRejected);
            this.txtNumeroTel.TextChanged += new System.EventHandler(this.txtNumeroTel_TextChanged_1);
            // 
            // btnAdicionarNumero
            // 
            this.btnAdicionarNumero.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdicionarNumero.Enabled = false;
            this.btnAdicionarNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicionarNumero.Location = new System.Drawing.Point(324, 18);
            this.btnAdicionarNumero.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarNumero.Name = "btnAdicionarNumero";
            this.btnAdicionarNumero.Size = new System.Drawing.Size(65, 58);
            this.btnAdicionarNumero.TabIndex = 46;
            this.btnAdicionarNumero.Text = "+";
            this.btnAdicionarNumero.UseVisualStyleBackColor = false;
            this.btnAdicionarNumero.Click += new System.EventHandler(this.btnAdicionarNumero_Click);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTipo.Location = new System.Drawing.Point(89, 313);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(63, 25);
            this.labelTipo.TabIndex = 32;
            this.labelTipo.Text = "TIPO";
            this.labelTipo.Visible = false;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNumero.Location = new System.Drawing.Point(89, 225);
            this.labelNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(132, 25);
            this.labelNumero.TabIndex = 31;
            this.labelNumero.Text = "2° NÚMERO";
            this.labelNumero.Visible = false;
            // 
            // cmbTipoTel2
            // 
            this.cmbTipoTel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTel2.FormattingEnabled = true;
            this.cmbTipoTel2.Items.AddRange(new object[] {
            "Pessoal",
            "Comercial",
            "Residencial"});
            this.cmbTipoTel2.Location = new System.Drawing.Point(94, 342);
            this.cmbTipoTel2.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoTel2.Name = "cmbTipoTel2";
            this.cmbTipoTel2.Size = new System.Drawing.Size(205, 32);
            this.cmbTipoTel2.TabIndex = 29;
            this.cmbTipoTel2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(88, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "TIPO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(88, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "NÚMERO";
            // 
            // cmbTipoTel
            // 
            this.cmbTipoTel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTel.FormattingEnabled = true;
            this.cmbTipoTel.Items.AddRange(new object[] {
            "Pessoal",
            "Comercial",
            "Residencial"});
            this.cmbTipoTel.Location = new System.Drawing.Point(94, 160);
            this.cmbTipoTel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoTel.Name = "cmbTipoTel";
            this.cmbTipoTel.Size = new System.Drawing.Size(205, 32);
            this.cmbTipoTel.TabIndex = 25;
            this.cmbTipoTel.TextChanged += new System.EventHandler(this.cmbTipoTel_TextChanged);
            // 
            // CadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1291, 980);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDados);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastrarFuncionario";
            this.Text = "Cadastrar Funcionario";
            this.Load += new System.EventHandler(this.CadastrarFuncionario_Load);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCidadeEnd;
        private System.Windows.Forms.TextBox txtLogradouroEnd;
        private System.Windows.Forms.TextBox txtNumeroEnd;
        private System.Windows.Forms.TextBox txtBairroEnd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.ComboBox cmbUfEnd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoTel;
        private System.Windows.Forms.Button btnOlhoSenha;
        private System.Windows.Forms.ComboBox cmbTipoTel2;
        private System.Windows.Forms.Button btnAdicionarNumero;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.MaskedTextBox txtCepEnd;
        private System.Windows.Forms.MaskedTextBox txtNumeroTel2;
        private System.Windows.Forms.MaskedTextBox txtNumeroTel;
    }
}