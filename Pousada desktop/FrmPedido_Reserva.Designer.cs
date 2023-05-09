namespace Pousada_desktop
{
    partial class FrmPedido_Reserva
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.clnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnData_Reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnData_Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnData_Saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAcompanhantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnID_Quartos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDataReserva = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPessoas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataSaida = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultar.Location = new System.Drawing.Point(178, 310);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(85, 39);
            this.btnConsultar.TabIndex = 57;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlterar.Location = new System.Drawing.Point(779, 24);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(91, 45);
            this.btnAlterar.TabIndex = 56;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(77, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(104, 321);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 20);
            this.txtId.TabIndex = 52;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnID,
            this.clnData_Reserva,
            this.clnData_Entrada,
            this.clnData_Saida,
            this.clnNome,
            this.clnCpf,
            this.clnEmail,
            this.clnAcompanhantes,
            this.clnID_Quartos,
            this.clnStatus_ID});
            this.dgvPedidos.Location = new System.Drawing.Point(29, 63);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.Size = new System.Drawing.Size(943, 199);
            this.dgvPedidos.TabIndex = 58;
            // 
            // clnID
            // 
            this.clnID.Frozen = true;
            this.clnID.HeaderText = "Id";
            this.clnID.MinimumWidth = 6;
            this.clnID.Name = "clnID";
            this.clnID.ReadOnly = true;
            this.clnID.Width = 40;
            // 
            // clnData_Reserva
            // 
            this.clnData_Reserva.Frozen = true;
            this.clnData_Reserva.HeaderText = "Data da Reserva";
            this.clnData_Reserva.MinimumWidth = 6;
            this.clnData_Reserva.Name = "clnData_Reserva";
            this.clnData_Reserva.ReadOnly = true;
            this.clnData_Reserva.Width = 125;
            // 
            // clnData_Entrada
            // 
            this.clnData_Entrada.Frozen = true;
            this.clnData_Entrada.HeaderText = "Data de Entrada";
            this.clnData_Entrada.MinimumWidth = 6;
            this.clnData_Entrada.Name = "clnData_Entrada";
            this.clnData_Entrada.ReadOnly = true;
            this.clnData_Entrada.Width = 125;
            // 
            // clnData_Saida
            // 
            this.clnData_Saida.Frozen = true;
            this.clnData_Saida.HeaderText = "Data de Saída";
            this.clnData_Saida.MinimumWidth = 6;
            this.clnData_Saida.Name = "clnData_Saida";
            this.clnData_Saida.ReadOnly = true;
            this.clnData_Saida.Width = 125;
            // 
            // clnNome
            // 
            this.clnNome.Frozen = true;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.MinimumWidth = 6;
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 125;
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
            // clnEmail
            // 
            this.clnEmail.Frozen = true;
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.MinimumWidth = 6;
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Width = 125;
            // 
            // clnAcompanhantes
            // 
            this.clnAcompanhantes.Frozen = true;
            this.clnAcompanhantes.HeaderText = "N° Pessoas";
            this.clnAcompanhantes.MinimumWidth = 6;
            this.clnAcompanhantes.Name = "clnAcompanhantes";
            this.clnAcompanhantes.ReadOnly = true;
            this.clnAcompanhantes.Width = 125;
            // 
            // clnID_Quartos
            // 
            this.clnID_Quartos.Frozen = true;
            this.clnID_Quartos.HeaderText = "Quarto";
            this.clnID_Quartos.MinimumWidth = 6;
            this.clnID_Quartos.Name = "clnID_Quartos";
            this.clnID_Quartos.ReadOnly = true;
            this.clnID_Quartos.Width = 125;
            // 
            // clnStatus_ID
            // 
            this.clnStatus_ID.Frozen = true;
            this.clnStatus_ID.HeaderText = "Status";
            this.clnStatus_ID.MinimumWidth = 6;
            this.clnStatus_ID.Name = "clnStatus_ID";
            this.clnStatus_ID.ReadOnly = true;
            this.clnStatus_ID.Width = 125;
            // 
            // txtDataReserva
            // 
            this.txtDataReserva.Enabled = false;
            this.txtDataReserva.Location = new System.Drawing.Point(86, 71);
            this.txtDataReserva.Mask = "00/00/0000 90:00";
            this.txtDataReserva.Name = "txtDataReserva";
            this.txtDataReserva.Size = new System.Drawing.Size(118, 24);
            this.txtDataReserva.TabIndex = 59;
            this.txtDataReserva.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.txtQuarto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPessoas);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCpf);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDataSaida);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDataEntrada);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDataReserva);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 296);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Reserva";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(519, 154);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(186, 26);
            this.cmbStatus.TabIndex = 78;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // txtQuarto
            // 
            this.txtQuarto.Enabled = false;
            this.txtQuarto.Location = new System.Drawing.Point(519, 71);
            this.txtQuarto.Name = "txtQuarto";
            this.txtQuarto.Size = new System.Drawing.Size(186, 24);
            this.txtQuarto.TabIndex = 77;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(516, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 76;
            this.label10.Text = "Quartos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(516, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 74;
            this.label9.Text = "Status";
            // 
            // txtPessoas
            // 
            this.txtPessoas.Enabled = false;
            this.txtPessoas.Location = new System.Drawing.Point(519, 234);
            this.txtPessoas.Name = "txtPessoas";
            this.txtPessoas.Size = new System.Drawing.Size(98, 24);
            this.txtPessoas.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(516, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 71;
            this.label8.Text = "N° de Pessoas";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(289, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 24);
            this.txtEmail.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 69;
            this.label7.Text = "Email";
            // 
            // txtCpf
            // 
            this.txtCpf.Enabled = false;
            this.txtCpf.Location = new System.Drawing.Point(289, 234);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(112, 24);
            this.txtCpf.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 67;
            this.label6.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(289, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(180, 24);
            this.txtNome.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 65;
            this.label5.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 64;
            this.label4.Text = "Data de Saída";
            // 
            // txtDataSaida
            // 
            this.txtDataSaida.Enabled = false;
            this.txtDataSaida.Location = new System.Drawing.Point(86, 234);
            this.txtDataSaida.Mask = "00/00/0000 90:00";
            this.txtDataSaida.Name = "txtDataSaida";
            this.txtDataSaida.Size = new System.Drawing.Size(118, 24);
            this.txtDataSaida.TabIndex = 63;
            this.txtDataSaida.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 62;
            this.label3.Text = "Data de Entrada";
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Enabled = false;
            this.txtDataEntrada.Location = new System.Drawing.Point(83, 157);
            this.txtDataEntrada.Mask = "00/00/0000 90:00";
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(118, 24);
            this.txtDataEntrada.TabIndex = 61;
            this.txtDataEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "Data da Reserva";
            // 
            // FrmPedido_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1014, 787);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Name = "FrmPedido_Reserva";
            this.Text = "FrmPedido_Reserva";
            this.Load += new System.EventHandler(this.FrmPedido_Reserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnData_Reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnData_Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnData_Saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAcompanhantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnID_Quartos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus_ID;
        private System.Windows.Forms.MaskedTextBox txtDataReserva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPessoas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtDataSaida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtDataEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}