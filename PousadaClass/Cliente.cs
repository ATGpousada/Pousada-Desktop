using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  // versão --> 8.0.33

namespace PousadaClass
{
    public class Cliente
    {

        // ----------- Atributos -----------------
        private int id;
        private string nome;
        private string cpf;
        private string rg;
        private string senha;
        private string email;
        private string recupera;
        private DateTime arquivar;

        // ----------- Propriedades ------------------
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Email { get => email; set => email = value; }
        public string Recupera { get => recupera; set => recupera = value; }
        public DateTime Arquivar { get => arquivar; set => arquivar = value; }
        public List<ClienteTelefone> Telefones { get; set; }
        public List<ClienteEndereco> Enderecos { get; set; }

        // --------- Metodos Construtores -----------------
        public Cliente() { }

        public Cliente(int id, string nome, string cpf, string rg, string senha, string email, string recupera, DateTime arquivar)
        {

            // ----------  Metodo Construtor com ID ---------------------

            Id = id;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Senha = senha;
            Email = email;
            Recupera = recupera;
            Arquivar = arquivar;
        }

        public Cliente(string nome, string cpf, string rg, string senha, string email, string recupera, DateTime arquivar)
        {

            // ----------  Metodo Construtor sem ID ---------------------

            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Senha = senha;
            Email = email;
            Recupera = recupera;
            Arquivar = arquivar;
        }

        // --------------------------- INSERINDO --------------------------------
        /// <summary>
        ///  Inserindo o usuario no Banco  de dados 
        /// </summary>
        /// 

/*        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert clientes (nome,cpf, rg, senha, email)" +
              "values (@nome, @cpf, @rg,@senha,@email) ";
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Cpf;
            cmd.Parameters.Add("@rg", MySqlDbType.VarChar).Value = Rg;
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Senha;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            // recupera o id na Propriedade
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            foreach (var telefone in Telefones)
            {
                telefone.Inserir(Id);
            }
            foreach (var endereco in Enderecos)
            {
                endereco.Inserir(Id);
            }
            // fecha  a conexão
            Banco.Fechar(cmd);

        }
        // ------------------------------- OBTENDO POR ID ------------------------ 

        /// <summary>
        ///  Obtendo o id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Cliente ObterPorId(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            var dr = cmd.ExecuteReader();
            Cliente cliente = null;
            while (dr.Read())
            {
                cliente = new Cliente(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetString(4),
                dr.GetString(5)
                    );
            }
        }*/
    }
}

