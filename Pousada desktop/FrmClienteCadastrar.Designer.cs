namespace Pousada_desktop
{
    partial class FrmCliente
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtEmailcli = new System.Windows.Forms.Label();
            this.TxtNomecli = new System.Windows.Forms.TextBox();
            this.TxtCpfcli = new System.Windows.Forms.TextBox();
            this.TxtRgcli = new System.Windows.Forms.TextBox();
            this.TxtSenhacli = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label1.Location = new System.Drawing.Point(55, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "NOME";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label2.Location = new System.Drawing.Point(245, 29);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(54, 25);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "CPF";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label4.Location = new System.Drawing.Point(55, 106);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(65, 20);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "SENHA";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label3.Location = new System.Drawing.Point(467, 30);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(43, 25);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "RG";
            // 
            // TxtEmailcli
            // 
            this.TxtEmailcli.AutoSize = true;
            this.TxtEmailcli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailcli.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtEmailcli.Location = new System.Drawing.Point(224, 101);
            this.TxtEmailcli.Name = "TxtEmailcli";
            this.TxtEmailcli.Size = new System.Drawing.Size(75, 25);
            this.TxtEmailcli.TabIndex = 4;
            this.TxtEmailcli.Text = "EMAIL";
            // 
            // TxtNomecli
            // 
            this.TxtNomecli.Location = new System.Drawing.Point(27, 57);
            this.TxtNomecli.Name = "TxtNomecli";
            this.TxtNomecli.Size = new System.Drawing.Size(131, 26);
            this.TxtNomecli.TabIndex = 5;
            // 
            // TxtCpfcli
            // 
            this.TxtCpfcli.Location = new System.Drawing.Point(205, 57);
            this.TxtCpfcli.Name = "TxtCpfcli";
            this.TxtCpfcli.Size = new System.Drawing.Size(137, 26);
            this.TxtCpfcli.TabIndex = 6;
            // 
            // TxtRgcli
            // 
            this.TxtRgcli.Location = new System.Drawing.Point(428, 57);
            this.TxtRgcli.Name = "TxtRgcli";
            this.TxtRgcli.Size = new System.Drawing.Size(140, 26);
            this.TxtRgcli.TabIndex = 7;
            // 
            // TxtSenhacli
            // 
            this.TxtSenhacli.Location = new System.Drawing.Point(27, 129);
            this.TxtSenhacli.Name = "TxtSenhacli";
            this.TxtSenhacli.Size = new System.Drawing.Size(131, 26);
            this.TxtSenhacli.TabIndex = 8;
            this.TxtSenhacli.TextChanged += new System.EventHandler(this.TxtSenhacli_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(205, 129);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(137, 26);
            this.textBox5.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSenhacli);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.TxtRgcli);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.TxtNomecli);
            this.groupBox1.Controls.Add(this.TxtEmailcli);
            this.groupBox1.Controls.Add(this.TxtCpfcli);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(58, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 206);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1207, 834);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label TxtEmailcli;
        private System.Windows.Forms.TextBox TxtNomecli;
        private System.Windows.Forms.TextBox TxtCpfcli;
        private System.Windows.Forms.TextBox TxtRgcli;
        private System.Windows.Forms.TextBox TxtSenhacli;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}