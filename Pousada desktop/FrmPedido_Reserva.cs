using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using PousadaClass;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Status = PousadaClass.Status;


namespace Pousada_desktop
{
    public partial class FrmPedido_Reserva : Form
    {
        private int userId;

        public FrmPedido_Reserva(int userId) : this()
        {
            this.userId = userId;
        }
        public FrmPedido_Reserva()
        {
            InitializeComponent();
        }

        private void FrmPedido_Reserva_Load(object sender, EventArgs e)
        {
            CarregaStatus();
            CarregaGrid();
        }

        private void CarregaGrid(string nome = "")
        {
            List<Pedido_Reserva> lista = null;
            if (nome != string.Empty)
                lista = Pedido_Reserva.Listar(nome);
            else
                lista = Pedido_Reserva.Listar(nome);
            int contador = 0;
            dgvPedidos.Rows.Clear();
            foreach (Pedido_Reserva pedido in lista)
            {
                dgvPedidos.Rows.Add();
                dgvPedidos.Rows[contador].Cells[0].Value = pedido.Id;
                dgvPedidos.Rows[contador].Cells[1].Value = pedido.Data_reserva;
                dgvPedidos.Rows[contador].Cells[2].Value = pedido.Data_entrada;
                dgvPedidos.Rows[contador].Cells[3].Value = pedido.Data_saida;
                dgvPedidos.Rows[contador].Cells[4].Value = pedido.Nome;
                dgvPedidos.Rows[contador].Cells[5].Value = pedido.Cpf;
                dgvPedidos.Rows[contador].Cells[6].Value = pedido.Email;
                dgvPedidos.Rows[contador].Cells[7].Value = pedido.Acompanhantes;
                dgvPedidos.Rows[contador].Cells[8].Value = pedido.Quartos.Quarto1;
                dgvPedidos.Rows[contador].Cells[9].Value = pedido.Status.Nome;
                contador++;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            gbDados.Enabled = true;

            var reserva = (Pedido_Reserva)null;
            if (txtId.Text.Length > 0)
            {
                reserva = Pedido_Reserva.ObterPorId(Convert.ToInt32(txtId.Text));
            }

            if (reserva == null)
                MessageBox.Show("Não há um ID cadastrado com este numero");
            else
            {
                // Retorna dados do pedido
                txtDataReserva.Text = reserva.Data_reserva.ToString();
                txtDataEntrada.Text = reserva.Data_entrada.ToString();
                txtDataSaida.Text = reserva.Data_saida.ToString();
                txtNome.Text = reserva.Nome;
                txtCpf.Text = reserva.Cpf;
                txtEmail.Text = reserva.Email;
                txtPessoas.Text = reserva.Acompanhantes.ToString();
                txtQuarto.Text = reserva.Quartos.Quarto1.ToString();
                cmbStatus.Text = reserva.Status.Nome;

                if (cmbStatus.Text == "EM ANDAMENTO")
                {
                    btnAlterar.Enabled = true;
                }

                if (cmbStatus.Text == "CONFIRMADO" || cmbStatus.Text == "CANCELADO")
                {
                    btnAlterar.Enabled = false;
                    cmbStatus.Enabled = false;
                }
            }
        }

        private void CarregaStatus()
        {
            cmbStatus.DataSource = Status.Listar();
            cmbStatus.ValueMember = "Id";
            cmbStatus.DisplayMember = "Nome";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtDataEntrada.Text.Length > 0)
            {
                // verifica qual opção está selecionada

                if (cmbStatus.Text == "PENDENTE")
                {
                    Reserva reservar = new Reserva();
                    reservar.GerarReserva(Convert.ToInt32(txtId.Text), userId, Convert.ToInt32(txtId.Text), txtDataEntrada.Text, txtDataSaida.Text);

                    Pedido_Reserva email = new Pedido_Reserva();
                    email.EnviarEmail(txtEmail.Text, txtDataReserva.Text, txtNome.Text);

                    MessageBox.Show("Pedido Pendente, Email enviado!");
                    btnAlterar.Enabled = false;
                    CarregaGrid();
                }
                else if (cmbStatus.Text == "CANCELADO")
                {
                    Reserva reservar = new Reserva();
                    reservar.CancelarReserva(Convert.ToInt32(txtId.Text), userId, Convert.ToInt32(txtId.Text), txtDataEntrada.Text, txtDataSaida.Text);

                    Pedido_Reserva email = new Pedido_Reserva();
                    email.EnviarEmailCancelado(txtEmail.Text, txtDataReserva.Text, txtNome.Text);

                    MessageBox.Show("Pedido Cancelado, Email enviado!");
                    btnAlterar.Enabled = false;
                    CarregaGrid();
                }
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}