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

namespace Pousada_desktop
{
    public partial class FrmPedido_Reserva : Form
    {
        public FrmPedido_Reserva()
        {
            InitializeComponent();
        }

        private void FrmPedido_Reserva_Load(object sender, EventArgs e)
        {

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
                cmbStatus.Text = reserva.Status.Status1.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
