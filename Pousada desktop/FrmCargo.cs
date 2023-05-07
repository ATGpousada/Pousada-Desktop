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
        // Variavel para confirmar se o checkbox está ativado ou não
        private string CheckBox;
        public FrmCargo()
        {
            InitializeComponent();
        }

        private void FrmInserirCargo_Load(object sender, EventArgs e)
        {
            CarregaCargo();
            CarregaGrid();
            dgvCargos.CellFormatting += dgvCargos_CellFormatting;
            CheckBox = "N";
        }

        /// <summary>
        /// Carrega o cargo para listar em um ComboBox
        /// </summary>
        private void CarregaCargo()
        {
            cmbCargo.DataSource = Cargo.Listar();
            cmbCargo.ValueMember = "Id";
            cmbCargo.DisplayMember = "NOME";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Conferindo se os TextBox estão preenchidos
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
            // Conferindo se os TextBox estão preenchidos
            if (txtNomeCargo.Text.Length > 0 && txtDescricao.Text.Length > 0)
            {
                // Caso o Usuario arquivar o cargo, a string ganhará um valor diferente
                if (btnArquivar.Text == "Sim")
                {
                    CheckBox = "S";
                }

                // Pegando todos os TextBox e atualizando
                Cargo alterar = new Cargo(Convert.ToInt32(txtId.Text), txtNomeCargo.Text, txtDescricao.Text, CheckBox);
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
            // Aparecendo label, botão e textbox para inserção
            gpbInserir.Visible = true;
            btnInserir.Visible = true;
            btnAlterar.Visible = false;
            txtId.Visible = false;
            label_ID.Visible = false;
            btnObterID.Visible = false;
            btnArquivar.Visible = false;
            
            txtId.Clear(); txtNomeCargo.Clear(); txtDescricao.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Aparecendo label, botão e textbox para alteração
            gpbInserir.Visible = true;
            btnAlterar.Visible = true;
            txtId.Visible = true;
            label_ID.Visible = true;
            btnObterID.Visible = true;
            btnArquivar.Visible = true;
            btnInserir.Visible = false;

            txtId.Clear(); txtNomeCargo.Clear(); txtDescricao.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Botão para inserir ID para consulta de Cargo especifico
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
                        // Adicionando cargos que foram consultados no TextBox
                        txtNomeCargo.Text = cargo.Nome;
                        txtDescricao.Text = cargo.Descricao;
                        btnArquivar.Checked = cargo.BuscaArquivado(txtNomeCargo.Text);

                        // Condição para saber se o cargo está arquivado ou não
                        if (btnArquivar.Checked)
                        {
                            btnArquivar.Checked = false;
                        }
                        else
                        {
                            btnArquivar.Checked = true;
                        }
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

        /// <summary>
        /// Carrega no DataGridView todos o cargos cadastrados no banco de dados
        /// </summary>
        /// <param name="nome"></param>
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
            // Colocando uma mascara no DataGridView em arquivar para ficar melhor visualmente
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

        private void btnArquivar_CheckedChanged(object sender, EventArgs e)
        {
            if (btnArquivar.Checked)
                Cargo.ArquivarCargo(int.Parse(txtId.Text));
            else
                Cargo.RestaurarCargo(int.Parse(txtId.Text));
            CarregaGrid();
        }
    }
}
