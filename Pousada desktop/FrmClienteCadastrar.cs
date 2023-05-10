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
    public partial class FrmClienteCadastrar : Form
    {
        public FrmClienteCadastrar()
        {
            InitializeComponent();
        }

        private void TxtSenhacli_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtCepEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmClienteCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void BTNInserir_Click(object sender, EventArgs e)
        {
            if (TxtNomecli.Text.Length > 0 && TxtSenhacli.Text.Length > 0 && TxtRgcli.MaskCompleted && TxtCpfcli.MaskCompleted && TxtEmailcli.Text.Length > 0)
            {
                List<ClienteEndereco> Enderecos = new List<ClienteEndereco>();
                List<ClienteTelefone> Telefones = new List<ClienteTelefone>();



                if (txtCidadeEndcli.Text.Length > 0 && labelTipo.Text.Length > 0 && cmbUfEndcli.Text.Length > 0 && txtLogradouroend.Text.Length > 0 && txtNumeroend.Text.Length > 0)
                {
                    Enderecos = new List<ClienteEndereco>();
                    Enderecos.Add(new ClienteEndereco(txtCepEndcli.Text, txtCidadeEndcli.Text, cmbUfEndcli.Text, txtNumeroend.Text, txtLogradouroend.Text));



                    Telefones = new List<ClienteTelefone>();
                    Telefones.Add(new ClienteTelefone(cmbTipoTelcli.Text, txtNumeroTelcli.Text));



                    if (txtNumeroTel2cli.Text.Length > 0 && cmbTipoTel2cli.Text.Length > 0)
                    {
                        Telefones.Add(new ClienteTelefone(cmbTipoTel2cli.Text, txtNumeroTel2cli.Text));
                        txtNumeroTel2cli.Clear(); cmbTipoTel2cli.Text = "";
                    }
                }

                Cliente cli = new Cliente(
                TxtNomecli.Text, TxtCpfcli.Text, TxtRgcli.Text, TxtSenhacli.Text,  TxtEmailcli.Text, Enderecos, Telefones);

                cli.Inserir();
                TxtNomecli.Clear(); TxtCpfcli.Clear(); TxtRgcli.Clear(); TxtSenhacli.Clear(); TxtEmailcli.Clear();
                txtCidadeEndcli.Clear();
                txtNumeroTelcli.Clear();

                labelNumero.Visible = false;
                labelTipo.Visible = false;
                txtNumeroTel2cli.Visible = false;
                cmbTipoTel2cli.Visible = false;
                btnAdicionarNumerocli.Enabled = false;
                MessageBox.Show("Cliente Cadastrado com Sucesso!");
            }
            else
                MessageBox.Show("Cliente não cadastrado por falta de informações.(Por favor preencha todos os campos.)");
        }

        private void btnAdicionarNumerocli_Click(object sender, EventArgs e)
        {
            labelNumero.Visible = true;
            labelTipo.Visible = true;
            txtNumeroTel2cli.Visible = true;
            cmbTipoTel2cli.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TxtCpfcli_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCpfcli_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            TxtCpfcli.SelectionStart = 0;
        }

        private void TxtRgcli_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            TxtRgcli.SelectionStart = 0;
        }

        private void txtCepEndcli_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtCepEndcli.SelectionStart = 0;
        }

        private void txtNumeroTelcli_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtNumeroend.SelectionStart = 0;
        }

        private void txtNumeroTelcli_TextChanged_1(object sender, EventArgs e)
        {
            if (txtNumeroTelcli.Text.Length > 0)
            {
                btnAdicionarNumerocli.Enabled = true;
            }
        }
    }
}
