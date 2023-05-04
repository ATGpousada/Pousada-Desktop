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
        public DateTime Arquivar_EM { get => arquivar; set => arquivar = value; }
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
            Arquivar_EM = arquivar;
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

        // ---------------------------------- EXCLUIR ---------------------------------------

<<<<<<< HEAD
        public static Cliente ObterPorId(int id)
=======
        /// <summary>
        /// Excluindo usuarios
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public bool Excluir(int _id)
>>>>>>> 8a8e50be876de8094442ae6380bfc4b1dd228ced
        {
            bool confirma = false;
            var cmd = Banco.Abrir();
<<<<<<< HEAD
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
=======
            cmd.CommandText = "delete from cliente where id = " + _id;
            if (cmd.ExecuteNonQuery() > 0)
            {
                confirma = true;
            }
            Banco.Fechar(cmd);
            return confirma;
>>>>>>> 8a8e50be876de8094442ae6380bfc4b1dd228ced
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

