﻿using System;
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

        /// <summary>
        /// Carrega do Banco de Dados todos os cargos cadastrados.
        /// </summary>
        private void CarregaCargo()
        {
            cmbCargo.DataSource = Cargo.Listar();
            cmbCargo.ValueMember = "Id";
            cmbCargo.DisplayMember = "NOME";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificando se todos os campos estão preenchidos
            if (txtLogradouroEnd.Text.Length > 0 && txtNumeroEnd.Text.Length > 0 && txtCepEnd.MaskCompleted && txtBairroEnd.Text.Length > 0 &&
                txtCidadeEnd.Text.Length > 0 && cmbUfEnd.Text.Length > 0 && cmbTipoTel.Text.Length > 0 && txtNumeroTel.MaskCompleted && txtSenha.Text.Length > 0 &&
                txtNome.Text.Length > 0 && dtpDataNasc.Text.Length > 0 && txtCpf.MaskCompleted && txtRg.MaskCompleted && txtSalario.Text.Length > 0 &&
                txtEmail.Text.Length > 0 && cmbPeriodo.Text.Length > 0)
            {
                List<FuncionarioEndereco> Enderecos = new List<FuncionarioEndereco>();
                List<FuncionarioTelefone> Telefones = new List<FuncionarioTelefone>();

                Enderecos = new List<FuncionarioEndereco>();
                Enderecos.Add(new FuncionarioEndereco(txtLogradouroEnd.Text, txtNumeroEnd.Text, txtCepEnd.Text, txtBairroEnd.Text, txtCidadeEnd.Text, cmbUfEnd.Text));

                Telefones = new List<FuncionarioTelefone>();
                Telefones.Add(new FuncionarioTelefone(cmbTipoTel.Text, txtNumeroTel.Text));

                // Verificando se o Segundo telefone foi preenchido
                if (txtNumeroTel2.Text.Length > 0 && cmbTipoTel2.Text.Length > 0)
                {
                    Telefones.Add(new FuncionarioTelefone(cmbTipoTel2.Text, txtNumeroTel2.Text));
                    txtNumeroTel2.Clear(); cmbTipoTel2.Text = "";
                }

                // Verificando se o Email, RG e CPF não já foram cadastrados.
                bool existe = Funcionario.BuscarCampos(txtEmail.Text, txtRg.Text, txtCpf.Text);

                // Se na pesquisa retornar verdadeiro, o formulario avisará que já possui um funcionario com essas credenciais
                if (existe == true)
                {
                    MessageBox.Show("Esse Funcionario já foi cadastrado!");
                    return;
                }

                Funcionario func = new Funcionario(
                    txtNome.Text, dtpDataNasc.Value, txtCpf.Text, txtRg.Text, Convert.ToDouble(txtSalario.Text), txtEmail.Text, txtSenha.Text, cmbPeriodo.Text, Cargo.ObterPorId(Convert.ToInt32(cmbCargo.SelectedValue)), Enderecos, Telefones);

                // Chamando classe de inserir no banco de dados
                func.Inserir();

                // Limpando campos que foram preenchidos
                txtNome.Clear(); txtCpf.Clear(); txtRg.Clear(); txtSalario.Clear(); txtSenha.Clear(); txtEmail.Clear();
                txtLogradouroEnd.Clear(); txtNumeroEnd.Clear(); txtCepEnd.Clear(); txtBairroEnd.Clear(); txtCidadeEnd.Clear();
                txtNumeroTel.Clear();

                // Sumindo todos os campos do Segundo telefone
                labelNumero.Visible = false;
                labelTipo.Visible = false;
                txtNumeroTel2.Visible = false;
                cmbTipoTel2.Visible = false;
                btnAdicionarNumero.Enabled = false;

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
            // Ocultando a Senha ou Visualizar a senha clicando no botão
            txtSenha.UseSystemPasswordChar = !txtSenha.UseSystemPasswordChar;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void btnAdicionarNumero_Click(object sender, EventArgs e)
        {
            // Aparece os TextBox do Segundo Telefone
            labelNumero.Visible = true;
            labelTipo.Visible = true;
            txtNumeroTel2.Visible = true;
            cmbTipoTel2.Visible = true;
        }

        private void cmbTipoTel_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNumeroTel_TextChanged_1(object sender, EventArgs e)
        {
            // Se o TextBox de Telefone for preenchido poderá adicionar o Segundo Telefone
            if (txtNumeroTel.Text.Length > 0)
            {
                btnAdicionarNumero.Enabled = true;
            }
        }

        private void txtRg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtRg.SelectionStart = 0;
        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtCpf.SelectionStart = 0;
        }

        private void txtNumeroTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtNumeroTel.SelectionStart = 0;
        }

        private void txtCepEnd_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtCepEnd.SelectionStart = 0;
        }

        private void txtNumeroTel2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtNumeroTel2.SelectionStart = 0;
        }
    }
}
