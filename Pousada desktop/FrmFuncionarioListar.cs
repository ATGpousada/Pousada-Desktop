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
            CarregaGridDemitidos();
            CarregaGridEnderecoDemitidos();
            CarregaGridTelefoneDemitidos();
            CarregaGrid();
            CarregaGridEndereco();
            CarregaGridTelefone();
        }

        /// <summary>
        /// Carrega do Banco de Dados todos os funcionarios cadastrados e ativos
        /// </summary>
        /// <param name="nome"></param>
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

        /// <summary>
        /// Carrega do Banco de Dados todos os endereços de funcionarios cadastrados e ativos
        /// </summary>
        /// <param name="nome"></param>
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

        /// <summary>
        /// Carrega do Banco de Dados todos os telefones de funcionarios cadastrados e ativos
        /// </summary>
        /// <param name="nome"></param>
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

        /// <summary>
        /// Carrega do Banco de Dados todos os funcionarios cadastrados e demitidos
        /// </summary>
        /// <param name="nome"></param>
        private void CarregaGridDemitidos(string nome = "")
        {
            List<Funcionario> lista = null;
            if (nome != string.Empty)
                lista = Funcionario.ListarDemitido(nome);
            else
                lista = Funcionario.ListarDemitido();

            int contador = 0;
            dgvDadosDemitidos.Rows.Clear();
            foreach (Funcionario func in lista)
            {
                dgvDadosDemitidos.Rows.Add();
                dgvDadosDemitidos.Rows[contador].Cells[0].Value = func.Id;
                dgvDadosDemitidos.Rows[contador].Cells[1].Value = func.Nome;
                dgvDadosDemitidos.Rows[contador].Cells[2].Value = func.Data_nasc.ToString("dd/MM/yyyy");
                dgvDadosDemitidos.Rows[contador].Cells[3].Value = func.Cpf;
                dgvDadosDemitidos.Rows[contador].Cells[4].Value = func.Rg;
                dgvDadosDemitidos.Rows[contador].Cells[5].Value = func.Salario.ToString("R$ ##,###");
                dgvDadosDemitidos.Rows[contador].Cells[6].Value = func.Email;
                dgvDadosDemitidos.Rows[contador].Cells[7].Value = func.Periodo1;
                dgvDadosDemitidos.Rows[contador].Cells[8].Value = func.Admissao;
                dgvDadosDemitidos.Rows[contador].Cells[9].Value = func.Demissao;
                contador++;
            }
        }

        /// <summary>
        /// Carrega do Banco de Dados todos os endereços de funcionarios cadastrados e demitidos
        /// </summary>
        /// <param name="nome"></param>
        private void CarregaGridEnderecoDemitidos(string nome = "")
        {
            List<FuncionarioEndereco> lista = null;
            if (nome != string.Empty)
                lista = FuncionarioEndereco.ListarDemitidos(nome);
            else
                lista = FuncionarioEndereco.ListarDemitidos();
            int c = 0;
            dgvEnderecoDemitidos.Rows.Clear();
            foreach (FuncionarioEndereco func in lista)
            {
                dgvEnderecoDemitidos.Rows.Add();
                dgvEnderecoDemitidos.Rows[c].Cells[0].Value = func.Id;
                dgvEnderecoDemitidos.Rows[c].Cells[1].Value = func.Logradouro;
                dgvEnderecoDemitidos.Rows[c].Cells[2].Value = func.Numero;
                dgvEnderecoDemitidos.Rows[c].Cells[3].Value = func.Cep;
                dgvEnderecoDemitidos.Rows[c].Cells[4].Value = func.Bairro;
                dgvEnderecoDemitidos.Rows[c].Cells[5].Value = func.Cidade;
                dgvEnderecoDemitidos.Rows[c].Cells[6].Value = func.Uf;
                dgvEnderecoDemitidos.Rows[c].Cells[7].Value = func.Funcionario.Nome;
                c++;
            }
        }

        /// <summary>
        /// Carrega do Banco de Dados todos os telefones de funcionarios cadastrados e demitidos
        /// </summary>
        /// <param name="nome"></param>
        private void CarregaGridTelefoneDemitidos(string nome = "")
        {
            List<FuncionarioTelefone> lista = null;
            if (nome != string.Empty)
                lista = FuncionarioTelefone.ListarDemitidos(nome);
            else
                lista = FuncionarioTelefone.ListarDemitidos();
            int c = 0;
            dgvTelefone.Rows.Clear();
            foreach (FuncionarioTelefone func in lista)
            {
                dgvTelefoneDemitidos.Rows.Add();
                dgvTelefoneDemitidos.Rows[c].Cells[0].Value = func.Id;
                dgvTelefoneDemitidos.Rows[c].Cells[1].Value = func.Tipo;
                dgvTelefoneDemitidos.Rows[c].Cells[2].Value = func.Telefone;
                dgvTelefoneDemitidos.Rows[c].Cells[3].Value = func.Funcionario.Nome;
                c++;
            }
        }
        private void dgvFuncionarioPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Caso clicar no botão "Demitidos" irá aparecer um GroupBox listando todos os Funcionarios demitidos
        private void btnDemitido_Click(object sender, EventArgs e)
        {
            gpListaDemitidos.Visible = true;
            gpListaAtivos.Visible = false;
        }

        // Caso clicar no botão "Ativos" irá aparecer um GroupBox listando todos os Funcionarios ativos
        private void btnAtivos_Click(object sender, EventArgs e)
        {
            gpListaAtivos.Visible = true;
            gpListaDemitidos.Visible = false;
        }

    }
}
