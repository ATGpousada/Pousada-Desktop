using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PousadaClass;

namespace Pousada_desktop
{
    public partial class FrmFuncionarioAlterar : Form
    {
        private string NumeroAntigo;
        private string TipoAntigo;
        public FrmFuncionarioAlterar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "CONSULTAR")
            {
                txtId.Enabled = true;
                txtId.Focus();
                btnConsultar.Text = "OBTER";
            }
            else if (txtId.Text != String.Empty)
                {
                txtId.Enabled = false;
                btnConsultar.Text = "CONSULTAR";
                var funcionario = Funcionario.ObterPorId(int.Parse(txtId.Text));
                var endereco = FuncionarioEndereco.ObterPorIdForeign(int.Parse(txtId.Text));
                var telefone = FuncionarioTelefone.ObterPorIdForeign(int.Parse(txtId.Text));

                

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
                    txtLogradouroEnd.Text = endereco.Logradouro;
                    txtNumeroEnd.Text = endereco.Numero;
                    txtCidadeEnd.Text = endereco.Cidade;
                    txtCepEnd.Text = endereco.Cep;
                    txtBairroEnd.Text = endereco.Bairro;
                    cmbUfEnd.Text = endereco.Uf;

                    // Retorna telefone do funcionario

                    txtNumeroTel.Text = telefone.Telefone;
                    cmbTipoTel.Text = telefone.Tipo;

/*                  txtNumeroTel2.Text = telefone.Telefone;
                    cmbTipoTel2.Text = telefone.Tipo;*/

                    /*labelNumero.Visible = true;
                    labelTipo.Visible = true;
                    txtNumeroTel2.Visible = true;
                    cmbTipoTel2.Visible = true;
                    txtNumeroTel2.Visible = true;
                    cmbTipoTel2.Visible = true;*/

                    NumeroAntigo = txtNumeroTel.Text;
                    TipoAntigo = cmbTipoTel.Text;
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            List<FuncionarioEndereco> Enderecos;
            List<FuncionarioTelefone> Telefones;

            Enderecos = new List<FuncionarioEndereco>();
            Enderecos.Add(new FuncionarioEndereco(txtLogradouroEnd.Text, txtNumeroEnd.Text, txtCepEnd.Text, txtBairroEnd.Text, txtCidadeEnd.Text, cmbUfEnd.Text));

            Telefones = new List<FuncionarioTelefone>();
            Telefones.Add(new FuncionarioTelefone(cmbTipoTel.Text, txtNumeroTel.Text));

           if (txtNumeroTel2.Text.Length > 0)
           {
                Telefones.Add(new FuncionarioTelefone(cmbTipoTel2.Text, txtNumeroTel2.Text));
           }

            Funcionario func = new Funcionario(
            txtNome.Text, dtpDataNasc.Value, txtCpf.Text, txtRg.Text, Convert.ToDouble(txtSalario.Text), txtEmail.Text, cmbPeriodo.Text, Cargo.ObterPorId(Convert.ToInt32(cmbCargo.SelectedValue)), Enderecos);

            func.Alterar(Convert.ToInt32(txtId.Text));
            foreach (FuncionarioTelefone tel in Telefones)
            {
                tel.Alterar(cmbTipoTel.Text, txtNumeroTel.Text, Convert.ToInt32(txtId.Text), NumeroAntigo, TipoAntigo);
            }
            }
    }
}
