namespace Pousada_desktop
{
    partial class FrmCargo
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
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCargo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.gpbInserir = new System.Windows.Forms.GroupBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAparecerInserir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.btnObterID = new System.Windows.Forms.Button();
            this.gpbInserir.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(69, 50);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(129, 33);
            this.cmbCargo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(66, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista dos Cargos";
            // 
            // txtNomeCargo
            // 
            this.txtNomeCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCargo.Location = new System.Drawing.Point(22, 78);
            this.txtNomeCargo.Name = "txtNomeCargo";
            this.txtNomeCargo.Size = new System.Drawing.Size(239, 24);
            this.txtNomeCargo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(18, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(18, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(22, 144);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(239, 77);
            this.txtDescricao.TabIndex = 6;
            this.txtDescricao.Text = "";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInserir.Location = new System.Drawing.Point(483, 323);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(90, 35);
            this.btnInserir.TabIndex = 41;
            this.btnInserir.Text = "Novo";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Visible = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // gpbInserir
            // 
            this.gpbInserir.Controls.Add(this.btnObterID);
            this.gpbInserir.Controls.Add(this.label_ID);
            this.gpbInserir.Controls.Add(this.txtId);
            this.gpbInserir.Controls.Add(this.txtDescricao);
            this.gpbInserir.Controls.Add(this.txtNomeCargo);
            this.gpbInserir.Controls.Add(this.label2);
            this.gpbInserir.Controls.Add(this.label3);
            this.gpbInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInserir.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbInserir.Location = new System.Drawing.Point(441, 50);
            this.gpbInserir.Name = "gpbInserir";
            this.gpbInserir.Size = new System.Drawing.Size(303, 257);
            this.gpbInserir.TabIndex = 42;
            this.gpbInserir.TabStop = false;
            this.gpbInserir.Text = "Dados do Cargo";
            this.gpbInserir.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlterar.Location = new System.Drawing.Point(612, 323);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 35);
            this.btnAlterar.TabIndex = 43;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAparecerInserir
            // 
            this.btnAparecerInserir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAparecerInserir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAparecerInserir.Location = new System.Drawing.Point(69, 133);
            this.btnAparecerInserir.Name = "btnAparecerInserir";
            this.btnAparecerInserir.Size = new System.Drawing.Size(111, 39);
            this.btnAparecerInserir.TabIndex = 44;
            this.btnAparecerInserir.Text = "Cadastrar Cargo";
            this.btnAparecerInserir.UseVisualStyleBackColor = false;
            this.btnAparecerInserir.Click += new System.EventHandler(this.btnAparecerInserir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(69, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 39);
            this.button1.TabIndex = 45;
            this.button1.Text = "Alterar Cargo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(167, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(47, 24);
            this.txtId.TabIndex = 7;
            this.txtId.Visible = false;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.ForeColor = System.Drawing.SystemColors.Control;
            this.label_ID.Location = new System.Drawing.Point(138, 28);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(26, 20);
            this.label_ID.TabIndex = 8;
            this.label_ID.Text = "ID";
            this.label_ID.Visible = false;
            // 
            // btnObterID
            // 
            this.btnObterID.BackColor = System.Drawing.Color.SteelBlue;
            this.btnObterID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnObterID.Location = new System.Drawing.Point(220, 25);
            this.btnObterID.Name = "btnObterID";
            this.btnObterID.Size = new System.Drawing.Size(41, 27);
            this.btnObterID.TabIndex = 46;
            this.btnObterID.Text = "...";
            this.btnObterID.UseVisualStyleBackColor = false;
            this.btnObterID.Visible = false;
            this.btnObterID.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(821, 644);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAparecerInserir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.gpbInserir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCargo);
            this.Name = "FrmCargo";
            this.Text = "FrmCargo";
            this.Load += new System.EventHandler(this.FrmInserirCargo_Load);
            this.gpbInserir.ResumeLayout(false);
            this.gpbInserir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.GroupBox gpbInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAparecerInserir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnObterID;
    }
}