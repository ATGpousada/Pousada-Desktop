using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PousadaClass;
using PousadaDesk;

namespace Pousada_desktop
{
    public partial class FrmLogin : Form
    {
        private int userId;

        public FrmLogin()
        {
            InitializeComponent();
        }

        public static Funcionario GuardarID(string nome, string senha)
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "select funcionarios.id, funcionarios.nome, email, senha, cargos.nome from funcionarios inner join cargos on funcionarios.cargos_id = cargos.id where cargos.nome = 'admin' and email = @email and senha = MD5(@senha) and demissao is null;";
            cmd.Parameters.AddWithValue("@email", nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                var funcionario = new Funcionario();
                funcionario.Id = reader.GetInt32(0);
                funcionario.Nome = reader.GetString(1);
                funcionario.Email = reader.GetString(2);
                funcionario.Senha = reader.GetString(3);

                reader.Close();
                Banco.Fechar(cmd);

                return funcionario;
            }

            reader.Close();
            Banco.Fechar(cmd);

            return null;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtSenha.Text;

            Funcionario funcionario = GuardarID(nome, senha);

            if (funcionario != null)
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal(funcionario.Id);
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email ou Senha incorreta, Tente novamente.");
            }
        }

        private void btnOlhoSenha_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !txtSenha.UseSystemPasswordChar;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
