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
    public partial class FrmClienteListar : Form
    {
        public FrmClienteListar()
        {
            InitializeComponent();
        }

        private void FrmClienteListar_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            CarregaGridEndereco();
            CarregaGridTelefone();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CarregaGrid(string nome = "")
        {
            List<Cliente> lista = null;
            if (nome != string.Empty)
                lista = Cliente.Listar(nome);
            else
                lista = Cliente.Listar();

            int contador = 0;
            DgvDados.Rows.Clear();
            foreach (Cliente cli in lista)
            {
                DgvDados.Rows.Add();
                DgvDados.Rows[contador].Cells[0].Value = cli.Id;
                DgvDados.Rows[contador].Cells[1].Value = cli.Nome;
                DgvDados.Rows[contador].Cells[2].Value = cli.Cpf;
                DgvDados.Rows[contador].Cells[3].Value = cli.Rg;
                DgvDados.Rows[contador].Cells[4].Value = cli.Email;
                contador++;
            }
        }
        private void CarregaGridEndereco(string nome = "")
        {
            List<ClienteEndereco> lista = null;
            if (nome != string.Empty)
                lista = ClienteEndereco.Listar(nome);
            else
                lista = ClienteEndereco.Listar();
            int c = 0;
            dgvEndCli.Rows.Clear();
            foreach (ClienteEndereco cli in lista)
            {
                dgvEndCli.Rows.Add();
                dgvEndCli.Rows[c].Cells[0].Value = cli.Id;
                dgvEndCli.Rows[c].Cells[1].Value = cli.Logradouro;
                dgvEndCli.Rows[c].Cells[2].Value = cli.Numero;
                dgvEndCli.Rows[c].Cells[3].Value = cli.Cep;
                dgvEndCli.Rows[c].Cells[4].Value = cli.Cidade;
                dgvEndCli.Rows[c].Cells[5].Value = cli.Uf;
                dgvEndCli.Rows[c].Cells[6].Value = cli.Cliente.Nome;
                c++;
            }
        }

        private void CarregaGridTelefone(string nome = "")
        {
            List<ClienteTelefone> lista = null;
            if (nome != string.Empty)
                lista = ClienteTelefone.Listar(nome);
            else
                lista = ClienteTelefone.Listar();
            int c = 0;
            dgvTelcli.Rows.Clear();
            foreach (ClienteTelefone cli in lista)
            {
                dgvTelcli.Rows.Add();
                dgvTelcli.Rows[c].Cells[0].Value = cli.Id;
                dgvTelcli.Rows[c].Cells[1].Value = cli.Tipo;
                dgvTelcli.Rows[c].Cells[2].Value = cli.Telefone;
                dgvTelcli.Rows[c].Cells[3].Value = cli.Cliente.Nome;
                c++;
            }
        }
    }
}
