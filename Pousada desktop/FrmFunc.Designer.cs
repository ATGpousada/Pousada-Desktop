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
            this.PgsFun = new System.Windows.Forms.TabControl();
            this.tbEndereço = new System.Windows.Forms.TabPage();
            this.tbContato = new System.Windows.Forms.TabPage();
            this.tbDados = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.MskDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.CbCargo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtRG = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CbPeriodo = new System.Windows.Forms.ComboBox();
            this.btnInserirFunc = new System.Windows.Forms.Button();
            this.btnAlterarFunc = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdFunc = new System.Windows.Forms.TextBox();
            this.PgsFun.SuspendLayout();
            this.tbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // PgsFun
            // 
            this.PgsFun.Controls.Add(this.tbDados);
            this.PgsFun.Controls.Add(this.tbEndereço);
            this.PgsFun.Controls.Add(this.tbContato);
            this.PgsFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PgsFun.Location = new System.Drawing.Point(56, 28);
            this.PgsFun.Name = "PgsFun";
            this.PgsFun.SelectedIndex = 0;
            this.PgsFun.Size = new System.Drawing.Size(1066, 593);
            this.PgsFun.TabIndex = 0;
            this.PgsFun.SelectedIndexChanged += new System.EventHandler(this.PgsFun_SelectedIndexChanged);
            // 
            // tbEndereço
            // 
            this.tbEndereço.Location = new System.Drawing.Point(4, 29);
            this.tbEndereço.Name = "tbEndereço";
            this.tbEndereço.Padding = new System.Windows.Forms.Padding(3);
            this.tbEndereço.Size = new System.Drawing.Size(705, 343);
            this.tbEndereço.TabIndex = 0;
            this.tbEndereço.Text = "Endereço";
            this.tbEndereço.UseVisualStyleBackColor = true;
            // 
            // tbContato
            // 
            this.tbContato.Location = new System.Drawing.Point(4, 29);
            this.tbContato.Name = "tbContato";
            this.tbContato.Padding = new System.Windows.Forms.Padding(3);
            this.tbContato.Size = new System.Drawing.Size(705, 343);
            this.tbContato.TabIndex = 1;
            this.tbContato.Text = "Contato";
            this.tbContato.UseVisualStyleBackColor = true;
            // 
            // tbDados
            // 
            this.tbDados.Controls.Add(this.txtIdFunc);
            this.tbDados.Controls.Add(this.label9);
            this.tbDados.Controls.Add(this.btnAlterarFunc);
            this.tbDados.Controls.Add(this.btnInserirFunc);
            this.tbDados.Controls.Add(this.CbPeriodo);
            this.tbDados.Controls.Add(this.label8);
            this.tbDados.Controls.Add(this.label7);
            this.tbDados.Controls.Add(this.txtCpf);
            this.tbDados.Controls.Add(this.TxtRG);
            this.tbDados.Controls.Add(this.label6);
            this.tbDados.Controls.Add(this.label5);
            this.tbDados.Controls.Add(this.CbCargo);
            this.tbDados.Controls.Add(this.TxtSalario);
            this.tbDados.Controls.Add(this.label4);
            this.tbDados.Controls.Add(this.label3);
            this.tbDados.Controls.Add(this.MskDataNasc);
            this.tbDados.Controls.Add(this.TxtEmail);
            this.tbDados.Controls.Add(this.label2);
            this.tbDados.Controls.Add(this.TxtName);
            this.tbDados.Controls.Add(this.label1);
            this.tbDados.Location = new System.Drawing.Point(4, 29);
            this.tbDados.Name = "tbDados";
            this.tbDados.Padding = new System.Windows.Forms.Padding(3);
            this.tbDados.Size = new System.Drawing.Size(1058, 560);
            this.tbDados.TabIndex = 2;
            this.tbDados.Text = "Dados Pessoais";
            this.tbDados.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(65, 137);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(166, 26);
            this.TxtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email :";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(324, 139);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(152, 26);
            this.TxtEmail.TabIndex = 3;
            // 
            // MskDataNasc
            // 
            this.MskDataNasc.Location = new System.Drawing.Point(579, 137);
            this.MskDataNasc.Margin = new System.Windows.Forms.Padding(5);
            this.MskDataNasc.Mask = "00/00/0000";
            this.MskDataNasc.Name = "MskDataNasc";
            this.MskDataNasc.Size = new System.Drawing.Size(144, 26);
            this.MskDataNasc.TabIndex = 4;
            this.MskDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data de Nascimento :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salário :";
            // 
            // TxtSalario
            // 
            this.TxtSalario.Location = new System.Drawing.Point(65, 320);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(166, 26);
            this.TxtSalario.TabIndex = 7;
            // 
            // CbCargo
            // 
            this.CbCargo.FormattingEnabled = true;
            this.CbCargo.Location = new System.Drawing.Point(324, 316);
            this.CbCargo.Name = "CbCargo";
            this.CbCargo.Size = new System.Drawing.Size(152, 28);
            this.CbCargo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cargo :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(617, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "RG :";
            // 
            // TxtRG
            // 
            this.TxtRG.Location = new System.Drawing.Point(579, 318);
            this.TxtRG.Name = "TxtRG";
            this.TxtRG.Size = new System.Drawing.Size(144, 26);
            this.TxtRG.TabIndex = 12;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(817, 318);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(166, 26);
            this.txtCpf.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(871, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "CPF :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(848, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Periodo :";
            // 
            // CbPeriodo
            // 
            this.CbPeriodo.FormattingEnabled = true;
            this.CbPeriodo.Location = new System.Drawing.Point(817, 137);
            this.CbPeriodo.Name = "CbPeriodo";
            this.CbPeriodo.Size = new System.Drawing.Size(152, 28);
            this.CbPeriodo.TabIndex = 16;
            // 
            // btnInserirFunc
            // 
            this.btnInserirFunc.Location = new System.Drawing.Point(292, 463);
            this.btnInserirFunc.Name = "btnInserirFunc";
            this.btnInserirFunc.Size = new System.Drawing.Size(140, 39);
            this.btnInserirFunc.TabIndex = 17;
            this.btnInserirFunc.Text = "Inserir";
            this.btnInserirFunc.UseVisualStyleBackColor = true;
            // 
            // btnAlterarFunc
            // 
            this.btnAlterarFunc.Location = new System.Drawing.Point(552, 463);
            this.btnAlterarFunc.Name = "btnAlterarFunc";
            this.btnAlterarFunc.Size = new System.Drawing.Size(140, 39);
            this.btnAlterarFunc.TabIndex = 18;
            this.btnAlterarFunc.Text = "Alterar";
            this.btnAlterarFunc.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(719, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "ID:";
            // 
            // txtIdFunc
            // 
            this.txtIdFunc.Location = new System.Drawing.Point(754, 469);
            this.txtIdFunc.Name = "txtIdFunc";
            this.txtIdFunc.Size = new System.Drawing.Size(38, 26);
            this.txtIdFunc.TabIndex = 20;
            // 
            // CadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 662);
            this.Controls.Add(this.PgsFun);
            this.Name = "CadastrarFuncionario";
            this.Text = "Cadastrar";
            this.PgsFun.ResumeLayout(false);
            this.tbDados.ResumeLayout(false);
            this.tbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PgsFun;
        private System.Windows.Forms.TabPage tbEndereço;
        private System.Windows.Forms.TabPage tbContato;
        private System.Windows.Forms.TabPage tbDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSalario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskDataNasc;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.ComboBox CbPeriodo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox TxtRG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbCargo;
        private System.Windows.Forms.TextBox txtIdFunc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAlterarFunc;
        private System.Windows.Forms.Button btnInserirFunc;
    }
}