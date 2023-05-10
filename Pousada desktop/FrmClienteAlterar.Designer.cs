namespace Pousada_desktop
{
    partial class FrmClienteAlterar
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNumeroTel2cli = new System.Windows.Forms.MaskedTextBox();
            this.txtNumeroTelcli = new System.Windows.Forms.MaskedTextBox();
            this.btnAdicionarNumerocli = new System.Windows.Forms.Button();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.cmbTipoTel2cli = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoTelcli = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCepEndcli = new System.Windows.Forms.MaskedTextBox();
            this.txtnnumeroend = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLogradouroend = new System.Windows.Forms.TextBox();
            this.cmbUfEndcli = new System.Windows.Forms.ComboBox();
            this.txtCidadeEndcli = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtRgcli = new System.Windows.Forms.MaskedTextBox();
            this.TxtCpfcli = new System.Windows.Forms.MaskedTextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtEmailcli = new System.Windows.Forms.TextBox();
            this.TxtNomecli = new System.Windows.Forms.TextBox();
            this.Label222 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtclienteEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNumeroTel2cli);
            this.groupBox3.Controls.Add(this.txtNumeroTelcli);
            this.groupBox3.Controls.Add(this.btnAdicionarNumerocli);
            this.groupBox3.Controls.Add(this.labelTipo);
            this.groupBox3.Controls.Add(this.labelNumero);
            this.groupBox3.Controls.Add(this.cmbTipoTel2cli);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbTipoTelcli);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(68, 634);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(951, 261);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Telefone";
            // 
            // txtNumeroTel2cli
            // 
            this.txtNumeroTel2cli.Location = new System.Drawing.Point(441, 80);
            this.txtNumeroTel2cli.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroTel2cli.Mask = "+(00) 00 000000000 ";
            this.txtNumeroTel2cli.Name = "txtNumeroTel2cli";
            this.txtNumeroTel2cli.Size = new System.Drawing.Size(203, 29);
            this.txtNumeroTel2cli.TabIndex = 48;
            // 
            // txtNumeroTelcli
            // 
            this.txtNumeroTelcli.Location = new System.Drawing.Point(43, 76);
            this.txtNumeroTelcli.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroTelcli.Mask = "+(00) 00 000000000 ";
            this.txtNumeroTelcli.Name = "txtNumeroTelcli";
            this.txtNumeroTelcli.Size = new System.Drawing.Size(209, 29);
            this.txtNumeroTelcli.TabIndex = 47;
            this.txtNumeroTelcli.TextChanged += new System.EventHandler(this.txtNumeroTelcli_TextChanged);
            // 
            // btnAdicionarNumerocli
            // 
            this.btnAdicionarNumerocli.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAdicionarNumerocli.Enabled = false;
            this.btnAdicionarNumerocli.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicionarNumerocli.Location = new System.Drawing.Point(867, 30);
            this.btnAdicionarNumerocli.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarNumerocli.Name = "btnAdicionarNumerocli";
            this.btnAdicionarNumerocli.Size = new System.Drawing.Size(65, 58);
            this.btnAdicionarNumerocli.TabIndex = 46;
            this.btnAdicionarNumerocli.Text = "+";
            this.btnAdicionarNumerocli.UseVisualStyleBackColor = false;
            this.btnAdicionarNumerocli.Click += new System.EventHandler(this.btnAdicionarNumerocli_Click);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTipo.Location = new System.Drawing.Point(436, 140);
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
            this.labelNumero.Location = new System.Drawing.Point(436, 47);
            this.labelNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(132, 25);
            this.labelNumero.TabIndex = 31;
            this.labelNumero.Text = "2° NÚMERO";
            this.labelNumero.Visible = false;
            // 
            // cmbTipoTel2cli
            // 
            this.cmbTipoTel2cli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTel2cli.FormattingEnabled = true;
            this.cmbTipoTel2cli.Items.AddRange(new object[] {
            "Pessoal",
            "Comercial",
            "Residencial"});
            this.cmbTipoTel2cli.Location = new System.Drawing.Point(441, 169);
            this.cmbTipoTel2cli.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoTel2cli.Name = "cmbTipoTel2cli";
            this.cmbTipoTel2cli.Size = new System.Drawing.Size(184, 32);
            this.cmbTipoTel2cli.TabIndex = 29;
            this.cmbTipoTel2cli.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(37, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "TIPO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(37, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "NÚMERO";
            // 
            // cmbTipoTelcli
            // 
            this.cmbTipoTelcli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTelcli.FormattingEnabled = true;
            this.cmbTipoTelcli.Items.AddRange(new object[] {
            "Pessoal",
            "Comercial",
            "Residencial"});
            this.cmbTipoTelcli.Location = new System.Drawing.Point(43, 169);
            this.cmbTipoTelcli.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoTelcli.Name = "cmbTipoTelcli";
            this.cmbTipoTelcli.Size = new System.Drawing.Size(184, 32);
            this.cmbTipoTelcli.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCepEndcli);
            this.groupBox2.Controls.Add(this.txtnnumeroend);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtLogradouroend);
            this.groupBox2.Controls.Add(this.cmbUfEndcli);
            this.groupBox2.Controls.Add(this.txtCidadeEndcli);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(68, 391);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(951, 217);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // txtCepEndcli
            // 
            this.txtCepEndcli.Location = new System.Drawing.Point(403, 73);
            this.txtCepEndcli.Margin = new System.Windows.Forms.Padding(4);
            this.txtCepEndcli.Mask = "00000 - 00";
            this.txtCepEndcli.Name = "txtCepEndcli";
            this.txtCepEndcli.Size = new System.Drawing.Size(132, 29);
            this.txtCepEndcli.TabIndex = 32;
            // 
            // txtnnumeroend
            // 
            this.txtnnumeroend.Location = new System.Drawing.Point(409, 170);
            this.txtnnumeroend.Margin = new System.Windows.Forms.Padding(4);
            this.txtnnumeroend.Name = "txtnnumeroend";
            this.txtnnumeroend.Size = new System.Drawing.Size(109, 29);
            this.txtnnumeroend.TabIndex = 31;
            this.txtnnumeroend.TextChanged += new System.EventHandler(this.txtNumeroend_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(397, 135);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 31);
            this.label10.TabIndex = 30;
            this.label10.Text = "NUMERO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(51, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 31);
            this.label9.TabIndex = 29;
            this.label9.Text = "LOGRADOURO";
            // 
            // txtLogradouroend
            // 
            this.txtLogradouroend.Location = new System.Drawing.Point(57, 170);
            this.txtLogradouroend.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogradouroend.Name = "txtLogradouroend";
            this.txtLogradouroend.Size = new System.Drawing.Size(215, 29);
            this.txtLogradouroend.TabIndex = 28;
            // 
            // cmbUfEndcli
            // 
            this.cmbUfEndcli.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbUfEndcli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUfEndcli.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbUfEndcli.FormattingEnabled = true;
            this.cmbUfEndcli.Items.AddRange(new object[] {
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
            this.cmbUfEndcli.Location = new System.Drawing.Point(711, 73);
            this.cmbUfEndcli.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUfEndcli.Name = "cmbUfEndcli";
            this.cmbUfEndcli.Size = new System.Drawing.Size(63, 32);
            this.cmbUfEndcli.TabIndex = 24;
            // 
            // txtCidadeEndcli
            // 
            this.txtCidadeEndcli.Location = new System.Drawing.Point(57, 73);
            this.txtCidadeEndcli.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidadeEndcli.Name = "txtCidadeEndcli";
            this.txtCidadeEndcli.Size = new System.Drawing.Size(192, 29);
            this.txtCidadeEndcli.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(397, 43);
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
            this.label13.Location = new System.Drawing.Point(716, 43);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = "UF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(52, 43);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 25);
            this.label14.TabIndex = 15;
            this.label14.Text = "CIDADE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtRgcli);
            this.groupBox1.Controls.Add(this.TxtCpfcli);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.TxtEmailcli);
            this.groupBox1.Controls.Add(this.TxtNomecli);
            this.groupBox1.Controls.Add(this.Label222);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(68, 153);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(951, 230);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // TxtRgcli
            // 
            this.TxtRgcli.Location = new System.Drawing.Point(629, 76);
            this.TxtRgcli.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRgcli.Mask = "00.000.000 -  0";
            this.TxtRgcli.Name = "TxtRgcli";
            this.TxtRgcli.Size = new System.Drawing.Size(164, 30);
            this.TxtRgcli.TabIndex = 11;
            this.TxtRgcli.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxtRgcli_MaskInputRejected);
            // 
            // TxtCpfcli
            // 
            this.TxtCpfcli.Location = new System.Drawing.Point(333, 76);
            this.TxtCpfcli.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCpfcli.Mask = "000.000.000-00";
            this.TxtCpfcli.Name = "TxtCpfcli";
            this.TxtCpfcli.Size = new System.Drawing.Size(167, 30);
            this.TxtCpfcli.TabIndex = 10;
            this.TxtCpfcli.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxtCpfcli_MaskInputRejected);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label3.Location = new System.Drawing.Point(623, 37);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(55, 31);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "RG";
            // 
            // TxtEmailcli
            // 
            this.TxtEmailcli.Location = new System.Drawing.Point(79, 165);
            this.TxtEmailcli.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmailcli.Name = "TxtEmailcli";
            this.TxtEmailcli.Size = new System.Drawing.Size(181, 30);
            this.TxtEmailcli.TabIndex = 9;
            // 
            // TxtNomecli
            // 
            this.TxtNomecli.Location = new System.Drawing.Point(79, 70);
            this.TxtNomecli.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNomecli.Name = "TxtNomecli";
            this.TxtNomecli.Size = new System.Drawing.Size(173, 30);
            this.TxtNomecli.TabIndex = 5;
            // 
            // Label222
            // 
            this.Label222.AutoSize = true;
            this.Label222.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label222.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label222.Location = new System.Drawing.Point(72, 130);
            this.Label222.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label222.Name = "Label222";
            this.Label222.Size = new System.Drawing.Size(95, 31);
            this.Label222.TabIndex = 4;
            this.Label222.Text = "EMAIL";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label1.Location = new System.Drawing.Point(73, 42);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 25);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "NOME";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label2.Location = new System.Drawing.Point(327, 36);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(69, 31);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "CPF";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultar.Location = new System.Drawing.Point(415, 65);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(115, 52);
            this.btnConsultar.TabIndex = 57;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlterar.Location = new System.Drawing.Point(898, 59);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(121, 58);
            this.btnAlterar.TabIndex = 56;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(48, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "EMAIL";
            // 
            // txtclienteEmail
            // 
            this.txtclienteEmail.Location = new System.Drawing.Point(131, 92);
            this.txtclienteEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtclienteEmail.Name = "txtclienteEmail";
            this.txtclienteEmail.Size = new System.Drawing.Size(249, 22);
            this.txtclienteEmail.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(91, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(131, 60);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(72, 22);
            this.txtId.TabIndex = 52;
            // 
            // FrmClienteAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1053, 897);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtclienteEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmClienteAlterar";
            this.Text = "FrmClienteAlterar";
            this.Load += new System.EventHandler(this.FrmClienteAlterar_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdicionarNumerocli;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.ComboBox cmbTipoTel2cli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoTelcli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbUfEndcli;
        private System.Windows.Forms.TextBox txtCidadeEndcli;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox TxtEmailcli;
        private System.Windows.Forms.TextBox TxtNomecli;
        private System.Windows.Forms.Label Label222;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtclienteEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtnnumeroend;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLogradouroend;
        private System.Windows.Forms.MaskedTextBox txtNumeroTel2cli;
        private System.Windows.Forms.MaskedTextBox txtNumeroTelcli;
        private System.Windows.Forms.MaskedTextBox txtCepEndcli;
        private System.Windows.Forms.MaskedTextBox TxtRgcli;
        private System.Windows.Forms.MaskedTextBox TxtCpfcli;
    }
}