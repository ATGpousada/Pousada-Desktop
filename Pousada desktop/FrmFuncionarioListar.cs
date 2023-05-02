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
    public partial class FrmFuncionarioListar : Form
    {
        public FrmFuncionarioListar()
        {
            InitializeComponent();
        }

        private void FrmFuncionarioListar_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            List<Funcionario> lista = Funcionario.Listar();
            int contador = 0;
            dgvFuncionarioPrincipal.Rows.Clear();
            foreach (Funcionario func in lista)
            {
                dgvFuncionarioPrincipal.Rows.Add();
                dgvFuncionarioPrincipal.Rows[contador].Cells[0].Value = func.Id;
                dgvFuncionarioPrincipal.Rows[contador].Cells[1].Value = func.Nome;

                dgvFuncionarioPrincipal.Rows[contador].Cells[3].Value = func.Cpf;
                dgvFuncionarioPrincipal.Rows[contador].Cells[4].Value = func.Rg;
                dgvFuncionarioPrincipal.Rows[contador].Cells[5].Value = func.Salario.ToString();
                dgvFuncionarioPrincipal.Rows[contador].Cells[6].Value = func.Email;
                dgvFuncionarioPrincipal.Rows[contador].Cells[7].Value = func.Periodo1;

                dgvFuncionarioPrincipal.Rows[contador].Cells[9].Value = func.Cargo.Nome.ToString();
                contador++;
            }
        }
    }
}
