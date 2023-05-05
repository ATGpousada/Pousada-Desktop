using PousadaClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pousada_desktop
{
    public partial class FrmClienteAlterar : Form
    {  
        // Variveis de Troca De Telefone
        private string NumeroAntigo;
        private string TipoAntigo;
        private string NumeroAntigo2;
        private string TipoAntigo2;

        // Varivel para saber se o telefone vai ser alterado ou inserido
        private int add;
        public FrmClienteAlterar()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void btnAlterar_Click(object sender, EventArgs e)
=======
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "CONSULTAR")
            {
                txtId.Enabled = true;
                txtclienteEmail.Enabled = true;
                txtId.Focus();
                btnConsultar.Text = "OBTER";
            }
            else if (txtId.Text.Length > 0 || txtclienteEmail.Text.Length > 0)
            {
                txtId.Enabled = false;
                btnConsultar.Text = "CONSULTAR";
                var cliente = (Cliente)null;

                // Verificando se há conteúdo no TextBox do ID
                if (txtId.Text.Length > 0)
                {
                    cliente = Cliente.ObterPorId(int.Parse(txtId.Text));
                }
                else // Caso não houver, pesquisará por Email do cliente
                {
                    cliente = Cliente.ObterPorEmail(txtclienteEmail.Text);
                    if (cliente != null)
                        txtId.Text = cliente.Id.ToString();
                    else
                    {
                        MessageBox.Show("Email não cadastrado!");
                        return;
                    }
                }

                // Variaveis para consultar Endereço e Telefone do cliente
                var endereco = ClienteEndereco.ObterPorIdForeign(int.Parse(txtId.Text));
                var telefone = ClienteTelefone.ObterPorIdForeign(int.Parse(txtId.Text));
                var telefone2 = ClienteTelefone.ObterPorIdForeign2(int.Parse(txtId.Text));
                if (cliente == null)
                    MessageBox.Show("Não há um ID cadastrado com este numero");
                else
                {
                    // Retorna dados pessoais do cliente
                    TxtNomecli.Text = cliente.Nome;
                    TxtCpfcli.Text = cliente.Cpf;
                    TxtRgcli.Text = cliente.Rg;
                    TxtEmailcli.Text = cliente.Email;

                    // Retorna endereço do cliente
                    txtCidadeEndcli.Text = endereco.Cidade;
                    txtCepEndcli.Text = endereco.Cep;
                    cmbUfEndcli.Text = endereco.Uf;

                    // Retorna telefone do cliente
                    txtNumeroTelcli.Text = telefone.Telefone;
                    cmbTipoTelcli.Text = telefone.Tipo;

                    // Variaveis de Troca de telefone
                    NumeroAntigo = txtNumeroTelcli.Text;
                    TipoAntigo = cmbTipoTelcli.Text;

                    // Retorna Segundo telefone do cliente (Caso tenha cadastrado)
                    txtNumeroTel2cli.Text = telefone2.Telefone;
                    cmbTipoTel2cli.Text = telefone2.Tipo;

                    // Variaveis de Troca do segundo telefone
                    NumeroAntigo2 = txtNumeroTel2cli.Text;
                    TipoAntigo2 = cmbTipoTel2cli.Text;

                    // Caso o Cliente possua apenas 1 telefone o segundo textbox não estará preenchido
                    if (txtNumeroTelcli.Text == txtNumeroTel2cli.Text)
                    {
                        txtNumeroTel2cli.Clear();
                        cmbTipoTel2cli.Items.Add("");
                        cmbTipoTel2cli.SelectedIndex = -1;
                    }

                    // Caso Não possua dois endereços aparecerá apenas 1 TextBox e 1 ComboBox
                    if (txtNumeroTel2cli.Text.Length > 0)
                    {
                        labelNumero.Visible = true;
                        labelTipo.Visible = true;
                        txtNumeroTel2cli.Visible = true;
                        cmbTipoTel2cli.Visible = true;
                        txtNumeroTel2cli.Visible = true;
                        cmbTipoTel2cli.Visible = true;

                        // Confirmação que telefone irá alterar
                        add = 2;
                    }
                    else
                    {
                        labelNumero.Visible = false;
                        labelTipo.Visible = false;
                        txtNumeroTel2cli.Visible = false;
                        cmbTipoTel2cli.Visible = false;
                        txtNumeroTel2cli.Visible = false;
                        cmbTipoTel2cli.Visible = false;
                    }

                    // Caso não possua nenhum valor no Segundo TextBox de telefone, aparece 1 botão para adicionar
                    if (txtNumeroTel2cli.Text.Length == 0 && cmbTipoTel2cli.Text.Length == 0)
                    {
                        btnAdicionarNumerocli.Visible = true;
                    }

                    btnAlterar.Enabled = true;
                }
            }
        }

        private void FrmClienteAlterar_Load(object sender, EventArgs e)
>>>>>>> 6b22a533e3ca4d8f96d3761776e00002259e688c
        {

        }
    }
}
