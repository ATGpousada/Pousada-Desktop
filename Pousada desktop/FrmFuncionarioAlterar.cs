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
using Google.Protobuf.WellKnownTypes;
using PousadaClass;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pousada_desktop
{
    public partial class FrmFuncionarioAlterar : Form
    {
        // Variveis de Troca De Telefone
        private string NumeroAntigo;
        private string TipoAntigo;
        private string NumeroAntigo2;
        private string TipoAntigo2;
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
                txtPesquisaEmail.Enabled = true;
                txtId.Focus();
                btnConsultar.Text = "OBTER";
            }
            else if (txtId.Text.Length > 0 || txtPesquisaEmail.Text.Length > 0)
                {
                txtId.Enabled = false;
                btnConsultar.Text = "CONSULTAR";
                var funcionario = (Funcionario)null;

                // Verificando se há conteúdo no TextBox do ID
                if (txtId.Text.Length > 0)
                {
                    funcionario = Funcionario.ObterPorId(int.Parse(txtId.Text));
                }
                else // Caso não houver, pesquisará por Email
                {
                    funcionario = Funcionario.ObterPorEmail(txtPesquisaEmail.Text);
                    if (funcionario != null)
                        txtId.Text = funcionario.Id.ToString();
                    else
                    {
                        MessageBox.Show("Email não cadastrado!");
                        return;
                    }
                }

                // Variaveis para consultar Endereço e Telefone
                var endereco = FuncionarioEndereco.ObterPorIdForeign(int.Parse(txtId.Text));
                var telefone = FuncionarioTelefone.ObterPorIdForeign(int.Parse(txtId.Text));
                var telefone2 = FuncionarioTelefone.ObterPorIdForeign2(int.Parse(txtId.Text));
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

                    // Variaveis de Troca de telefone
                    NumeroAntigo = txtNumeroTel.Text;
                    TipoAntigo = cmbTipoTel.Text;

                    // Retorna Segundo telefone do funcionario (Caso tenha cadastrado)
                    txtNumeroTel2.Text = telefone2.Telefone;
                    cmbTipoTel2.Text = telefone2.Tipo;

                    // Variaveis de Troca do segundo telefone
                    NumeroAntigo2 = txtNumeroTel2.Text;
                    TipoAntigo2 = cmbTipoTel2.Text;

                    // Caso o Funcionario possua apenas 1 telefone o segundo textbox não estará preenchido
                    if (txtNumeroTel.Text == txtNumeroTel2.Text)
                    {
                        txtNumeroTel2.Clear();
                        cmbTipoTel2.Items.Add("");
                        cmbTipoTel2.SelectedIndex = -1;
                    }

                    // Caso Não possua dois endereços aparecerá apenas 1 TextBox e 1 ComboBox
                    if (txtNumeroTel2.Text.Length > 0)
                    {
                        labelNumero.Visible = true;
                        labelTipo.Visible = true;
                        txtNumeroTel2.Visible = true;
                        cmbTipoTel2.Visible = true;
                        txtNumeroTel2.Visible = true;
                        cmbTipoTel2.Visible = true;
                    }
                    else
                    {
                        labelNumero.Visible = false;
                        labelTipo.Visible = false;
                        txtNumeroTel2.Visible = false;
                        cmbTipoTel2.Visible = false;
                        txtNumeroTel2.Visible = false;
                        cmbTipoTel2.Visible = false;
                    }

                    btnAlterar.Enabled = true;
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

        /// <summary>
        /// Carrega todos os Cargos que possui no banco de dados
        /// </summary>
        private void CarregaCargo()
        {
            cmbCargo.DataSource = Cargo.Listar();
            cmbCargo.ValueMember = "Id";
            cmbCargo.DisplayMember = "NOME";
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 0)
            {
                txtPesquisaEmail.Enabled = false;
                txtPesquisaEmail.Clear();
            }
            else
            {
                txtPesquisaEmail.Enabled = true;
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitindo apenas numeros no TextBox de ID
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Confirmando que não faltará dados para ser gravado
            if (txtLogradouroEnd.Text.Length > 0 && txtNumeroEnd.Text.Length > 0 && txtCepEnd.Text.Length > 0 && txtBairroEnd.Text.Length > 0 && 
                txtCidadeEnd.Text.Length > 0 && cmbUfEnd.Text.Length > 0 && cmbTipoTel.Text.Length > 0 && txtNumeroTel.Text.Length > 0 &&
                txtNome.Text.Length > 0 && dtpDataNasc.Text.Length > 0 && txtCpf.Text.Length > 0 && txtRg.Text.Length > 0 && txtSalario.Text.Length > 0 &&
                txtEmail.Text.Length > 0 && cmbPeriodo.Text.Length > 0)
            {
                List<FuncionarioEndereco> Enderecos;
                List<FuncionarioTelefone> Telefones;

                // Alterando Endereço do Funcionario
                Enderecos = new List<FuncionarioEndereco>();
                Enderecos.Add(new FuncionarioEndereco(txtLogradouroEnd.Text, txtNumeroEnd.Text, txtCepEnd.Text, txtBairroEnd.Text, txtCidadeEnd.Text, cmbUfEnd.Text));

                // Alterando Telefone do Funcionario
                Telefones = new List<FuncionarioTelefone>();
                Telefones.Add(new FuncionarioTelefone(cmbTipoTel.Text, txtNumeroTel.Text));

                // Caso o Funcionario possuia 2 Telefones, altera o segundo telefone do Funcionario
                if (txtNumeroTel2.Text.Length > 0 && cmbTipoTel2.Text.Length > 0)
                {
                    Telefones.Add(new FuncionarioTelefone(cmbTipoTel2.Text, txtNumeroTel2.Text));
                }

                // Gravando tudo em um unico metodo construtor
                Funcionario func = new Funcionario(
                txtNome.Text, dtpDataNasc.Value, txtCpf.Text, txtRg.Text, Convert.ToDouble(txtSalario.Text), txtEmail.Text, cmbPeriodo.Text, Cargo.ObterPorId(Convert.ToInt32(cmbCargo.SelectedValue)), Enderecos);

                // Chamando metodo de classe Alterar
                func.Alterar(Convert.ToInt32(txtId.Text));
                foreach (FuncionarioTelefone tel in Telefones)
                {
                    tel.Alterar(cmbTipoTel.Text, txtNumeroTel.Text, Convert.ToInt32(txtId.Text), NumeroAntigo, TipoAntigo);

                    // Como citado acima, caso possua 2 telefones alterará o segundo nesse IF 
                    if (txtNumeroTel2.Text.Length > 0)
                    {
                        tel.Alterar(cmbTipoTel2.Text, txtNumeroTel2.Text, Convert.ToInt32(txtId.Text), NumeroAntigo2, TipoAntigo2);
                        txtNumeroTel2.Clear();  cmbTipoTel2.Items.Add(""); cmbTipoTel2.SelectedIndex = -1;
                    }
                }
                MessageBox.Show("Funcionario alterado com sucesso!");

                // Botão Alterar volta a ser desabilitado
                btnAlterar.Enabled = false;

                // Limpando TextBox que foram gravados no Banco
                txtNome.Clear(); txtCpf.Clear(); txtRg.Clear(); txtSalario.Clear(); txtEmail.Clear(); cmbPeriodo.Items.Add(""); cmbPeriodo.SelectedIndex = -1;
                cmbUfEnd.Items.Add(""); cmbUfEnd.SelectedIndex = -1; txtLogradouroEnd.Clear(); txtNumeroEnd.Clear(); txtCepEnd.Clear();
                txtBairroEnd.Clear(); txtCidadeEnd.Clear(); txtNumeroTel.Clear(); cmbTipoTel.Items.Add(""); cmbTipoTel.SelectedIndex = -1;
            }
            else
                MessageBox.Show("Funcionaro não foi alterado por falta de dados");      
        }

        private void txtPesquisaEmail_TextChanged(object sender, EventArgs e)
        {
            // Filtrando caso usar o TextBox de ID o de Email desabilitará e vice versa
            if (txtPesquisaEmail.Text.Length > 0)
            {
                txtId.Enabled = true;
                txtId.Clear();
            }else
                txtId.Enabled = false;
        }
    }
}
