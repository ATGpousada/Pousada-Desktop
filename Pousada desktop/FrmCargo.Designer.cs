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
            this.btnArquivar = new System.Windows.Forms.CheckBox();
            this.btnObterID = new System.Windows.Forms.Button();
            this.label_ID = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAparecerInserir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvCargos = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnArquivar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbInserir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(69, 194);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(129, 33);
            this.cmbCargo.TabIndex = 0;
            this.cmbCargo.SelectedIndexChanged += new System.EventHandler(this.cmbCargo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(66, 173);
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
            this.txtNomeCargo.Size = new System.Drawing.Size(264, 24);
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
            this.txtDescricao.Size = new System.Drawing.Size(264, 77);
            this.txtDescricao.TabIndex = 6;
            this.txtDescricao.Text = "";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.DarkGreen;
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInserir.Location = new System.Drawing.Point(554, 314);
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
            this.gpbInserir.Controls.Add(this.btnArquivar);
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
            this.gpbInserir.Size = new System.Drawing.Size(303, 240);
            this.gpbInserir.TabIndex = 42;
            this.gpbInserir.TabStop = false;
            this.gpbInserir.Text = "Dados do Cargo";
            this.gpbInserir.Visible = false;
            // 
            // btnArquivar
            // 
            this.btnArquivar.AutoSize = true;
            this.btnArquivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArquivar.Location = new System.Drawing.Point(190, 27);
            this.btnArquivar.Margin = new System.Windows.Forms.Padding(2);
            this.btnArquivar.Name = "btnArquivar";
            this.btnArquivar.Size = new System.Drawing.Size(94, 24);
            this.btnArquivar.TabIndex = 47;
            this.btnArquivar.Text = "Arquivar";
            this.btnArquivar.UseVisualStyleBackColor = true;
            this.btnArquivar.CheckedChanged += new System.EventHandler(this.btnArquivar_CheckedChanged);
            // 
            // btnObterID
            // 
            this.btnObterID.BackColor = System.Drawing.Color.SteelBlue;
            this.btnObterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObterID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnObterID.Location = new System.Drawing.Point(101, 25);
            this.btnObterID.Name = "btnObterID";
            this.btnObterID.Size = new System.Drawing.Size(41, 27);
            this.btnObterID.TabIndex = 46;
            this.btnObterID.Text = "...";
            this.btnObterID.UseVisualStyleBackColor = false;
            this.btnObterID.Visible = false;
            this.btnObterID.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.ForeColor = System.Drawing.SystemColors.Control;
            this.label_ID.Location = new System.Drawing.Point(20, 28);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(26, 20);
            this.label_ID.TabIndex = 8;
            this.label_ID.Text = "ID";
            this.label_ID.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(49, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(47, 24);
            this.txtId.TabIndex = 7;
            this.txtId.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlterar.Location = new System.Drawing.Point(554, 314);
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
            this.btnAparecerInserir.Location = new System.Drawing.Point(99, 63);
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
            this.button1.Location = new System.Drawing.Point(238, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 39);
            this.button1.TabIndex = 45;
            this.button1.Text = "Alterar Cargo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvCargos
            // 
            this.dgvCargos.AllowUserToAddRows = false;
            this.dgvCargos.AllowUserToDeleteRows = false;
            this.dgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnDescricao,
            this.clnArquivar});
            this.dgvCargos.Location = new System.Drawing.Point(58, 395);
            this.dgvCargos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCargos.Name = "dgvCargos";
            this.dgvCargos.ReadOnly = true;
            this.dgvCargos.RowHeadersVisible = false;
            this.dgvCargos.RowHeadersWidth = 51;
            this.dgvCargos.RowTemplate.Height = 24;
            this.dgvCargos.Size = new System.Drawing.Size(686, 185);
            this.dgvCargos.TabIndex = 46;
            this.dgvCargos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargos_CellContentClick);
            this.dgvCargos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCargos_CellFormatting);
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
            this.clnNome.HeaderText = "Cargo";
            this.clnNome.MinimumWidth = 6;
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            // 
            // clnDescricao
            // 
            this.clnDescricao.Frozen = true;
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.MinimumWidth = 6;
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 480;
            // 
            // clnArquivar
            // 
            this.clnArquivar.Frozen = true;
            this.clnArquivar.HeaderText = "Arquivado";
            this.clnArquivar.MinimumWidth = 6;
            this.clnArquivar.Name = "clnArquivar";
            this.clnArquivar.ReadOnly = true;
            this.clnArquivar.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(57, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "Cargos";
            // 
            // FrmCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(821, 590);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCargos);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvCargos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnArquivar;
        private System.Windows.Forms.CheckBox btnArquivar;
        private System.Windows.Forms.Label label4;
    }
}