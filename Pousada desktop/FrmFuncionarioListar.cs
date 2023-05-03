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
using Pousada_desktop;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Pousada_desktop
{
    public partial class FrmFuncionarioListar : Form
    {
        public FrmFuncionarioListar()
        {
            InitializeComponent();
        }

        private void FrmFuncionarioListar_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            CarregaGridEndereco();
            CarregaGridTelefone();
        }

        private void CarregaGrid(string nome = "")
        {
            List<Funcionario> lista = null;
            if (nome != string.Empty)
                lista = Funcionario.Listar(nome);
            else
                lista = Funcionario.Listar();

            int contador = 0;
            dgvFuncionarioPrincipal.Rows.Clear();
            foreach (Funcionario func in lista)
            {
                dgvFuncionarioPrincipal.Rows.Add();
                dgvFuncionarioPrincipal.Rows[contador].Cells[0].Value = func.Id;
                dgvFuncionarioPrincipal.Rows[contador].Cells[1].Value = func.Nome;
                dgvFuncionarioPrincipal.Rows[contador].Cells[2].Value = func.Data_nasc.ToString("dd/MM/yyyy");
                dgvFuncionarioPrincipal.Rows[contador].Cells[3].Value = func.Cpf;
                dgvFuncionarioPrincipal.Rows[contador].Cells[4].Value = func.Rg;
                dgvFuncionarioPrincipal.Rows[contador].Cells[5].Value = func.Salario.ToString("R$ ##,###");
                dgvFuncionarioPrincipal.Rows[contador].Cells[6].Value = func.Email;
                dgvFuncionarioPrincipal.Rows[contador].Cells[7].Value = func.Periodo1;
                dgvFuncionarioPrincipal.Rows[contador].Cells[8].Value = func.Admissao;
                dgvFuncionarioPrincipal.Rows[contador].Cells[9].Value = func.Cargo.Nome;
                contador++;
            }
        }

        private void CarregaGridEndereco(string nome = "")
        {
            List<FuncionarioEndereco> lista = null;
            if (nome != string.Empty)
                lista = FuncionarioEndereco.Listar(nome);
            else
                lista = FuncionarioEndereco.Listar();
            int c = 0;
            dgvEndereco.Rows.Clear();
            foreach (FuncionarioEndereco func in lista)
            {
                dgvEndereco.Rows.Add();
                dgvEndereco.Rows[c].Cells[0].Value = func.Id;
                dgvEndereco.Rows[c].Cells[1].Value = func.Logradouro;
                dgvEndereco.Rows[c].Cells[2].Value = func.Numero;
                dgvEndereco.Rows[c].Cells[3].Value = func.Cep;
                dgvEndereco.Rows[c].Cells[4].Value = func.Bairro;
                dgvEndereco.Rows[c].Cells[5].Value = func.Cidade;
                dgvEndereco.Rows[c].Cells[6].Value = func.Uf;
                dgvEndereco.Rows[c].Cells[7].Value = func.Funcionario.Nome;
                c++;
            }
        }

        private void CarregaGridTelefone(string nome = "")
        {
            List<FuncionarioTelefone> lista = null;
            if (nome != string.Empty)
                lista = FuncionarioTelefone.Listar(nome);
            else
                lista = FuncionarioTelefone.Listar();
            int c = 0;
            dgvTelefone.Rows.Clear();
            foreach (FuncionarioTelefone func in lista)
            {
                dgvTelefone.Rows.Add();
                dgvTelefone.Rows[c].Cells[0].Value = func.Id;
                dgvTelefone.Rows[c].Cells[1].Value = func.Tipo;
                dgvTelefone.Rows[c].Cells[2].Value = func.Telefone;
                dgvTelefone.Rows[c].Cells[3].Value = func.Funcionario.Nome;
                c++;
            }
        }

        private void dgvFuncionarioPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text.Length > 1)
            {
                CarregaGrid(txtPesquisar.Text);
                CarregaGridEndereco(txtPesquisar.Text);
                CarregaGridTelefone(txtPesquisar.Text);
            }
            else
            {
                CarregaGrid(txtPesquisar.Text);
                CarregaGridEndereco(txtPesquisar.Text);
                CarregaGridTelefone(txtPesquisar.Text);
            }
        }
    }
}
