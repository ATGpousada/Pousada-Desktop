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
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
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

                if (cmbStatus.Text == "PENDENTE")
                {
                    btnAlterar.Enabled = false;
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
                string opcao = (string)cmbStatus.SelectedItem;
                if (opcao == "PENDENTE")
                {
                    Reserva reservar = new Reserva();
                    reservar.GerarReserva(Convert.ToInt32(txtId.Text), userId);
                }
                else if (opcao == "EM ANDAMENTO")
                {

                }
                else if (opcao == "CANCELADO")
                {

                }
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
