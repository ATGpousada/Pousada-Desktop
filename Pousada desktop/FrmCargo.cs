using System;
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
    public partial class FrmCargo : Form
    {
        public FrmCargo()
        {
            InitializeComponent();
        }

        private void FrmInserirCargo_Load(object sender, EventArgs e)
        {
            CarregaCargo();
        }

        private void CarregaCargo()
        {
            cmbCargo.DataSource = Cargo.Listar();
            cmbCargo.ValueMember = "Id";
            cmbCargo.DisplayMember = "NOME";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNomeCargo.Text.Length > 0 && txtDescricao.Text.Length > 0)
            {
                Cargo cargo = new Cargo(txtNomeCargo.Text, txtDescricao.Text);
                cargo.Inserir();

                CarregaCargo();

                MessageBox.Show("Cargo cadastrado com sucesso!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
                Cargo alterar = new Cargo(txtNomeCargo.Text, txtDescricao.Text);
                alterar.Atualizar(Convert.ToInt32(txtId.Text));
        }

        private void btnAparecerInserir_Click(object sender, EventArgs e)
        {
            gpbInserir.Visible = true;
            btnInserir.Visible = true;
            btnAlterar.Visible = false;
            txtId.Visible = false;
            label_ID.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gpbInserir.Visible = true;
            btnAlterar.Visible = true;
            txtId.Visible = true;
            label_ID.Visible = true;
            btnObterID.Visible = true;
            btnInserir.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cargo = (Cargo)null;
            cargo = Cargo.ObterPorId(Convert.ToInt32(txtId.Text));

            if (txtId.Text.Length > 0)
            {
                txtNomeCargo.Text = cargo.Nome;
                txtDescricao.Text = cargo.Descricao;
            }else // Caso não houver, Avisará que não há Cargo cadastrado
            {
                MessageBox.Show("Cargo não cadastrado!");
                return;
            }
        }
    }
}
