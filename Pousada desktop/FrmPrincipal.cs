using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using PousadaClass;
using Pousada_desktop;

namespace PousadaDesk
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario func = new CadastrarFuncionario();
            func.Show();
        }

        private void alterarConsultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionarioAlterar alterar = new FrmFuncionarioAlterar();
            alterar.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionarioListar listar = new FrmFuncionarioListar();
            listar.Show();
        }

        private void cdastarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteCadastrar cliente = new FrmClienteCadastrar();
            cliente.Show();
        }

        private void alterarConsultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmClienteAlterar alterar = new FrmClienteAlterar();
            alterar.Show();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargo cargo = new FrmCargo();
            cargo.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmClienteListar cliente = new FrmClienteListar();
            cliente.Show();
        }

        private void consultarAlterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedido_Reserva pedido = new FrmPedido_Reserva();
            pedido.Show();
        }
    }
}
