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

        // Varivel de Trocar Campo Unico
        private string TrocarEmail;
        private string TrocarCpf;
        private string TrocarRg;


        public FrmClienteAlterar()
        {
            InitializeComponent();
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        { }
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
                    kdfkdfkn.Text = cliente.Cpf;
                    TxtRgcli.Text = cliente.Rg;
                    TxtEmailcli.Text = cliente.Email;

                    // Retorna endereço do cliente
                    txtCidadeEndcli.Text = endereco.Cidade;
                    txtCepEndcli.Text = endereco.Cep;
                    cmbUfEndcli.Text = endereco.Uf;
                    txtLogradouroend.Text = endereco.Logradouro;
                    txtnnumeroend.Text = endereco.Numero;

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
        {

        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
          

            // Confirmando que não faltará dados para ser gravado
            if (txtCepEndcli.Text.Length > 0 && txtCidadeEndcli.Text.Length > 0 && cmbUfEndcli.Text.Length > 0 && cmbTipoTelcli.Text.Length > 0 && txtNumeroTelcli.Text.Length > 0 &&
            TxtNomecli.Text.Length > 0 && kdfkdfkn.Text.Length > 0 && TxtRgcli.Text.Length > 0 && TxtEmailcli.Text.Length > 0)
            {
                List<ClienteEndereco> Enderecos;
                List<ClienteTelefone> Telefones;

                // Alterando Endereço do Cliente
                Enderecos = new List<ClienteEndereco>();
                Enderecos.Add(new ClienteEndereco(txtCepEndcli.Text, txtCidadeEndcli.Text, cmbUfEndcli.Text, txtnnumeroend.Text, txtLogradouroend.Text));

                // Alterando Telefone do Cliente
                Telefones = new List<ClienteTelefone>();
                Telefones.Add(new ClienteTelefone(cmbTipoTelcli.Text, txtNumeroTelcli.Text));

                // Caso o Cliente possuia 2 Telefones, altera o segundo telefone do Funcionario
                if (txtNumeroTel2cli.Text.Length > 0 && cmbTipoTel2cli.Text.Length > 0)
                {
                    Telefones.Add(new ClienteTelefone(cmbTipoTel2cli.Text, txtNumeroTel2cli.Text));
                }
                // Verificando se houve alteração no email
                bool existe;
                Cliente cliente;

                if (TrocarEmail != TxtEmailcli.Text)
                {
                    existe = Cliente.BuscarEmail(TxtEmailcli.Text);

                    if (existe)
                    {
                        MessageBox.Show("Email já cadastrado em outro Cliente!");
                        return;
                    }

                    cliente = new Cliente(
                        TxtNomecli.Text,kdfkdfkn.Text,TxtRgcli.Text,TxtEmailcli.Text,Enderecos);
                    cliente.AlterarEmail(Convert.ToInt32(txtId.Text));
                }

                // Verificando se houve alteração no RG
                if (TrocarRg != TxtRgcli.Text)
                {
                    existe = Cliente.BuscarRG(TxtRgcli.Text);

                    if (existe)
                    {
                        MessageBox.Show("RG já cadastrado em outro Cliente!");
                        return;
                    }

                    cliente = new Cliente(
                        TxtNomecli.Text, kdfkdfkn.Text, TxtRgcli.Text, TxtEmailcli.Text);
                    cliente.AlterarRG(Convert.ToInt32(txtId.Text));
                }

                // Verificando se houve alteração no CPF
                if (TrocarCpf != kdfkdfkn.Text)
                {
                    existe = Cliente.BuscarCPF(kdfkdfkn.Text);

                    if (existe)
                    {
                        MessageBox.Show("CPF já cadastrado em outro Cliente!");
                        return;
                    }

                    cliente = new Cliente(
                        TxtNomecli.Text, kdfkdfkn.Text, TxtRgcli.Text,TxtEmailcli.Text,Enderecos );
                    cliente.AlterarCPF(Convert.ToInt32(txtId.Text));
                }



                // Gravando tudo em um unico metodo construtor
                Cliente cli = new Cliente(
               TxtNomecli.Text, kdfkdfkn.Text, TxtRgcli.Text, TxtEmailcli.Text,Enderecos);

                // Chamando metodo de classe Alterar
                cli.Alterar(Convert.ToInt32(txtId.Text));
                foreach (ClienteTelefone tel in Telefones)
                {
                    tel.Alterar(cmbTipoTelcli.Text, txtNumeroTelcli.Text, Convert.ToInt32(txtId.Text), NumeroAntigo, TipoAntigo); 


                // Como citado acima, caso possua 2 telefones alterará o segundo nesse IF 
                if (txtNumeroTel2cli.Text.Length > 0 && add == 2) // Se passar pelo IF de telefone existente, apenas altera se não ele irá inserir
                    {
                        tel.Alterar(cmbTipoTel2cli.Text, txtNumeroTel2cli.Text, Convert.ToInt32(txtId.Text), NumeroAntigo2, TipoAntigo2);
                        txtNumeroTel2cli.Clear(); cmbTipoTel2cli.Items.Add(""); cmbTipoTel2cli.SelectedIndex = -1;
                    }
                    else if (add == 1)
                    {
                        tel.InserirTelExistente(Convert.ToInt32(txtId.Text), txtNumeroTel2cli.Text, cmbTipoTel2cli.Text);
                        txtNumeroTel2cli.Clear(); cmbTipoTel2cli.Items.Add(""); cmbTipoTel2cli.SelectedIndex = -1;
                        break;
                    }
                }
                MessageBox.Show("Funcionario alterado com sucesso!");

                // Botão Alterar volta a ser desabilitado
                btnAlterar.Enabled = false;

                // Limpando TextBox que foram gravados no Banco
                TxtNomecli.Clear(); kdfkdfkn.Clear(); TxtRgcli.Clear(); TxtEmailcli.Clear();
                cmbUfEndcli.Items.Add(""); cmbUfEndcli.SelectedIndex = -1; txtCepEndcli.Clear();
                txtCidadeEndcli.Clear(); txtNumeroTelcli.Clear(); cmbTipoTelcli.Items.Add(""); cmbTipoTelcli.SelectedIndex = -1;
            }

            else {
                MessageBox.Show("Cliente não foi alterado por falta de dados");
            }
        }

        private void txtNumeroend_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


