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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
            CarregaGrid();
            dgvCargos.CellFormatting += dgvCargos_CellFormatting;
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
                CarregaGrid();

                MessageBox.Show("Cargo cadastrado com sucesso!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNomeCargo.Text.Length > 0 && txtDescricao.Text.Length > 0)
            {
                Cargo alterar = new Cargo(txtNomeCargo.Text, txtDescricao.Text);
                alterar.Atualizar(Convert.ToInt32(txtId.Text));
                CarregaGrid();
                CarregaCargo();
                MessageBox.Show("Cargo Alterado com Sucesso!");
            }
            else
                MessageBox.Show("Campos estão vazios, Preencha todos e Clique no Alterar");            

        }

        private void btnAparecerInserir_Click(object sender, EventArgs e)
        {
            gpbInserir.Visible = true;
            btnInserir.Visible = true;
            btnAlterar.Visible = false;
            txtId.Visible = false;
            label_ID.Visible = false;
            btnObterID.Visible = false;
            
            txtId.Clear(); txtNomeCargo.Clear(); txtDescricao.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gpbInserir.Visible = true;
            btnAlterar.Visible = true;
            txtId.Visible = true;
            label_ID.Visible = true;
            btnObterID.Visible = true;
            btnInserir.Visible = false;

            txtId.Clear(); txtNomeCargo.Clear(); txtDescricao.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (btnObterID.Text == "...")
            {
                txtId.Enabled = true;
                txtId.Focus();
                btnObterID.Text = "✅";
            }
            else if (txtId.Text.Length > 0)
            {
                txtId.Enabled = false;
                btnObterID.Text = "...";

                var cargo = (Cargo)null;

                if (txtId.Text.Length > 0)
                {
                    cargo = Cargo.ObterPorId(Convert.ToInt32(txtId.Text));

                    if (cargo == null)
                    {
                        txtId.Clear(); txtNomeCargo.Clear(); txtDescricao.Clear();
                        MessageBox.Show("Não há Cargo com este ID!");
                    }
                    else
                    {
                        txtNomeCargo.Text = cargo.Nome;
                        txtDescricao.Text = cargo.Descricao;
                    }
                }
                else // Caso não houver, Avisará que não há Cargo cadastrado
                {
                    txtId.Clear(); txtNomeCargo.Clear(); txtDescricao.Clear();
                    MessageBox.Show("Coloque um ID para realizar a pesquisa!");
                    return;
                }
            }
        }

        private void CarregaGrid(string nome = "")
        {
            List<Cargo> lista = null;
            if (nome != string.Empty)
                lista = Cargo.ListarPorCargo(nome);
            else
                lista = Cargo.ListarPorCargo(nome);
            int contador = 0;
            dgvCargos.Rows.Clear();
            foreach (Cargo cargo in lista)
            {
                dgvCargos.Rows.Add();
                dgvCargos.Rows[contador].Cells[0].Value = cargo.Id;
                dgvCargos.Rows[contador].Cells[1].Value = cargo.Nome;
                dgvCargos.Rows[contador].Cells[2].Value = cargo.Descricao;
                dgvCargos.Rows[contador].Cells[3].Value = cargo.Arquivar;
                contador++;
            }
        }

        private void dgvCargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvCargos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCargos.Columns[e.ColumnIndex].Name == "clnArquivar")
            {
                object value = e.Value;
                if (value != null && value.ToString() == "N")
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }

                if (value != null && value.ToString() == "S")
                {
                    e.Value = "Arquivado";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
