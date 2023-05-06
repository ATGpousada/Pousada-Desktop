using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
        public DateTime Arquivar_EM { get => arquivar; set => arquivar = value; }
        public List<ClienteTelefone> Telefones { get; set; }
        public List<ClienteEndereco> Enderecos { get; set; }

        // --------- Metodos Construtores -----------------
        public Cliente() { }

        public Cliente(int id, string nome, string cpf, string rg, string senha, string email, string recupera, DateTime arquivar)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Senha = senha;
            Email = email;
            Recupera = recupera;
            Arquivar_EM = arquivar;
        }

        public Cliente(int id, string nome, string cpf, string rg, string senha, string email)
        {

            // ----------  Metodo Construtor com ID ---------------------

            Id = id;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Senha = senha;
            Email = email;
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
            Arquivar_EM = arquivar;
        }
        public Cliente(string nome, string cpf, string rg, string senha, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Senha = senha;
            Email = email;
        }

        public Cliente(string nome, string cpf, string rg, string email,List<ClienteEndereco> endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Email = email;
            Enderecos = endereco;
        }


        public Cliente(string nome, string cpf, string rg, string senha, string email, List<ClienteEndereco> endereco, List<ClienteTelefone>telefones)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Senha = senha;
            Email = email;
            Enderecos = endereco;
            Telefones = telefones;
        }




        public Cliente(int _id)
        {
            Telefones = ClienteTelefone.ListarPorClintes(_id);
            Enderecos = ClienteEndereco.ListarPorCliente(_id);
        }

        // ---------------------------------- INSERIR --------------------------------------
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert clientes (nome,cpf, rg, senha, email) " +
              "values (@nome, @cpf, @rg, @senha, @email)";
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


        public void Alterar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update clientes set nome = @nome, cpf = @cpf, rg = @rg,senha = @senha, email = @email, recuperar_senha = @rs, arquivar_em = @ae " +
                "where id = " + id;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Cpf;
            cmd.Parameters.Add("@rg", MySqlDbType.VarChar).Value = Rg;
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Senha;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            cmd.Parameters.Add("@rs", MySqlDbType.VarChar).Value = Recupera;
            cmd.Parameters.Add("@ae", MySqlDbType.VarChar).Value = Arquivar_EM ;
            cmd.ExecuteNonQuery();
            foreach (ClienteEndereco endereco in Enderecos)
            {
                endereco.Alterar(id);
            }
            Banco.Fechar(cmd);
        }


        // ----------------------------------- ATUALIZAR -------------------------------------
        /// <summary>
        /// Atualizando usuarios
        /// </summary>
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update cliente set nome = @nome where id = @id";
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        // ---------------------------------- OBTER POR ID ---------------------------------------


        public static Cliente ObterPorId(int id)
        {
            var cmd = Banco.Abrir();
            Cliente cliente = null;
            cmd.CommandText = "select * from clientes where id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente = new Cliente(
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetString(4),
                dr.GetString(5)
                    );
            }
            return cliente;
        }
        // --------------------------------- Listar Clientes ---------------------------------
      
        public static List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetString(4),
                dr.GetString(5)));
            }
            Banco.Fechar(cmd);
            return lista;
        }


        public static Cliente ObterPorEmail(string email)
        {
            var cmd = Banco.Abrir();
            Cliente cliente = null;
            cmd.CommandText = "select id, nome, cpf, rg, senha, email from clientes where email = '" + email + "'";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente = new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5));
            }
            Banco.Fechar(cmd);
            return cliente;
        }

        // ---------------------------------- ARQUIVAR ---------------------------------------

        public void Arquivar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update clientes set arquivar = default where id = @id";
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);

        }
    }
}

