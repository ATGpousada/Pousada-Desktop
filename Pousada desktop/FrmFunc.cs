using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PousadaClass;

namespace Pousada_desktop
{
    public partial class CadastrarFuncionario : Form
    {
        public CadastrarFuncionario()
        {
            InitializeComponent();

        }

        private void PgsFun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CadastrarFuncionario_Load(object sender, EventArgs e)
        {
            CarregaCargo();
            dtpDataNasc.Format = DateTimePickerFormat.Custom;
            dtpDataNasc.CustomFormat = "dd/MM/yyyy";
        }

        private void CarregaCargo()
        {
            cmbCargo.DataSource = Cargo.Listar();
            cmbCargo.ValueMember = "Id";
            cmbCargo.DisplayMember = "NOME";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario(
                txtNome.Text, dtpDataNasc.Value, txtCpf.Text, txtRg.Text, Convert.ToDouble(txtSalario.Text), txtEmail.Text, txtSenha.Text, cmbPeriodo.Text, Cargo.ObterPorId(Convert.ToInt32(cmbCargo.SelectedValue)));
            func.Inserir();
            MessageBox.Show("Funcionario Cadastrado com Sucesso!");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
