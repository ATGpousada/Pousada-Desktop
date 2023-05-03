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
            if (txtNome.Text.Length > 0 && txtSenha.Text.Length > 0)
            {
                List<FuncionarioEndereco> Enderecos = new List<FuncionarioEndereco>();
                List<FuncionarioTelefone> Telefones = new List<FuncionarioTelefone>();

                if (txtLogradouroEnd.Text.Length > 0 && cmbUfEnd.Text.Length > 0 && txtNumeroTel.Text.Length > 0)
                {
                    Enderecos = new List<FuncionarioEndereco>();
                    Enderecos.Add(new FuncionarioEndereco(txtLogradouroEnd.Text, txtNumeroEnd.Text, txtCepEnd.Text, txtBairroEnd.Text, txtCidadeEnd.Text, cmbUfEnd.Text));

                    Telefones = new List<FuncionarioTelefone>();
                    Telefones.Add(new FuncionarioTelefone(cmbTipoTel.Text, txtNumeroTel.Text));
                }

                Funcionario func = new Funcionario(
                    txtNome.Text, dtpDataNasc.Value, txtCpf.Text, txtRg.Text, Convert.ToDouble(txtSalario.Text), txtEmail.Text, txtSenha.Text, cmbPeriodo.Text, Cargo.ObterPorId(Convert.ToInt32(cmbCargo.SelectedValue)), Enderecos, Telefones);

                func.Inserir();
                txtNome.Clear(); txtCpf.Clear(); txtRg.Clear(); txtSalario.Clear(); txtSenha.Clear();
                txtLogradouroEnd.Clear(); txtNumeroEnd.Clear(); txtCepEnd.Clear(); txtBairroEnd.Clear(); txtCidadeEnd.Clear();
                txtNumeroTel.Clear();
                MessageBox.Show("Funcionario Cadastrado com Sucesso!");
            }
            else
                MessageBox.Show("Funcionario não cadastrado por falta de informações.");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void btnOlhoSenha_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !txtSenha.UseSystemPasswordChar;
        }
    }
}
