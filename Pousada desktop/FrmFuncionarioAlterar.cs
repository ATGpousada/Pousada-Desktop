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
    public partial class FrmFuncionarioAlterar : Form
    {
        public FrmFuncionarioAlterar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "Consultar")
            {
                txtId.ReadOnly = false;
                txtId.Focus();
                btnConsultar.Text = "Obter";
            }
            else if (txtId.Text != String.Empty)
                {
                txtId.ReadOnly = true;
                btnConsultar.Text = "Consultar";
                var funcionario = Funcionario.ObterPorId(int.Parse(txtId.Text));
                var endereco = FuncionarioEndereco.ObterPorIdForeign(int.Parse(txtId.Text));

                if (funcionario == null)
                    MessageBox.Show("Não há um ID cadastrado com este numero");
                else
                {
                    // Retorna dados pessoais do funcionario
                    txtNome.Text = funcionario.Nome;
                    txtEmail.Text = funcionario.Email;
                    cmbPeriodo.Text = funcionario.Periodo1;
                    dtpDataNasc.Text = funcionario.Data_nasc.ToString();
                    cmbCargo.Text = funcionario.Cargo.Nome;
                    txtRg.Text = funcionario.Rg;
                    txtSalario.Text = funcionario.Salario.ToString();
                    txtCpf.Text = funcionario.Cpf;

                    // Retorna endereço do funcionario
                    txtLogradouro.Text = endereco.Logradouro;
                    txtNumeroEnd.Text = endereco.Numero;
                    txtCidadeEnd.Text = endereco.Cidade;
                    txtCepEnd.Text = endereco.Cep;
                    txtBairroEnd.Text = endereco.Bairro;
                    cmbUfEnd.Text = endereco.Uf;
                    btnAlterar.Enabled = !btnAlterar.Enabled;
                }
            }
        }

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmFuncionarioAlterar_Load(object sender, EventArgs e)
        {
            CarregaCargo();
        }

        private void CarregaCargo()
        {
            cmbCargo.DataSource = Cargo.Listar();
            cmbCargo.ValueMember = "Id";
            cmbCargo.DisplayMember = "NOME";
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
