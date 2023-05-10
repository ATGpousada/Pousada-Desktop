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
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Senha = senha;
            Email = email;
        }


        public Cliente(string nome, string cpf, string rg, string senha, string email, string recupera, DateTime arquivar)
        {
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

        public Cliente(string nome, string cpf, string rg, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
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

        /// <summary>
        /// Inserindo Cliente no banco de dados, adicionando uma lista de telefones e um endereço (Só irá inserir se o cliente ligar para a pousada)
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert clientes (nome,cpf, rg, senha, email) " +
              "values (@nome, @cpf, @rg, MD5(@senha), @email)";
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

        /// <summary>
        /// Alterando dados de um cliente especifico puxando pelo ID
        /// </summary>
        /// <param name="id"></param>
        public void Alterar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update clientes set nome = @nome, cpf = @cpf, rg = @rg, email = @email, recuperar_senha = @rs, arquivar_em = @ae " +
                "where id = " + id;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Cpf;
            cmd.Parameters.Add("@rg", MySqlDbType.VarChar).Value = Rg; 
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

        /// <summary>
        /// Buscando determinado cliente pelo Id desejado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Listando clientes por um nome especifico ou todos os clientes cadastrados
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static List<Cliente> Listar(string nome = "")
        {
            List<Cliente> lista = new List<Cliente>();
            var cmd = Banco.Abrir();
            if (nome.Length > 0)
                cmd.CommandText = "select id, nome, cpf, rg,senha, email from clientes where nome like '%" + nome + "%'";
            else
                cmd.CommandText = "select id, nome,  cpf, rg,senha, email from clientes";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5)));
            }
            return lista;
        }

        /// <summary>
        /// Buscando determinado cliente pelo Email desejado
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
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

        //
        /// <summary>
        /// Alterando apenas o email de clientes
        /// </summary>
        /// <param name="id"></param>
        public void AlterarEmail(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update clientes set nome = @nome,cpf = @cpf, rg = @rg, email = @email, " +
                " where id = " + id;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Cpf;
            cmd.Parameters.Add("@rg", MySqlDbType.VarChar).Value = Rg;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            cmd.ExecuteNonQuery();
        
            foreach (ClienteEndereco endereco in Enderecos)
            {
                endereco.Alterar(id);
            }
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Alterando apenas o RG de um determinado clientes
        /// </summary>
        /// <param name="id"></param>
        public void AlterarRG(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update clientes set nome = @nome,cpf = @cpf, rg = @rg, email = @email, " +
                " where id = " + id;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Cpf;
            cmd.Parameters.Add("@rg", MySqlDbType.VarChar).Value = Rg;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            cmd.ExecuteNonQuery();

            foreach (ClienteEndereco endereco in Enderecos)
            {
                endereco.Alterar(id);
            }
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Alterando o CPF de um unico funcionario pelo Id
        /// </summary>
        /// <param name="id"></param>
        public void AlterarCPF(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update clientes set nome = @nome,cpf = @cpf, rg = @rg, email = @email, " +
                " where id = " + id;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@data", MySqlDbType.DateTime).Value = Cpf;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Rg;
            cmd.Parameters.Add("@salario", MySqlDbType.VarChar).Value = Email;
            cmd.ExecuteNonQuery();

            foreach (ClienteEndereco endereco in Enderecos)
            {
                endereco.Alterar(id);
            }
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Buscando campos existentes no banco de dados, retornando verdadeiro ou falso
        /// </summary>
        /// <param name="email"></param>
        /// <param name="rg"></param>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public static bool BuscarCampos(string email, string rg, string cpf)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, cpf, rg, email from clientes where email = '" + email + "' or rg = '" + rg + "' or cpf = '" + cpf + "';";
            var dr = cmd.ExecuteReader();
            bool existe = dr.HasRows;
            Banco.Fechar(cmd);
            return existe;
        }

        /// <summary>
        /// Buscando pelo Email se o Email já está cadastrado ou não
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool BuscarEmail(string email)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, email from clientes where email = '" + email + "';";
            var dr = cmd.ExecuteReader();
            bool existe = dr.HasRows;
            Banco.Fechar(cmd);
            return existe;
        }

        /// <summary>
        /// Buscando pelo RG se o RG já está cadastrado ou não
        /// </summary>
        /// <param name="rg"></param>
        /// <returns></returns>
        public static bool BuscarRG(string rg)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, rg from clientes where rg = '" + rg + "';";
            var dr = cmd.ExecuteReader();
            bool existe = dr.HasRows;
            Banco.Fechar(cmd);
            return existe;
        }

        /// <summary>
        /// Buscando pelo CPF se o CPF já está cadastrado ou não
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public static bool BuscarCPF(string cpf)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, cpf from clientes where cpf = '" + cpf + "';";
            var dr = cmd.ExecuteReader();
            bool existe = dr.HasRows;
            Banco.Fechar(cmd);
            return existe;
        }

    }
}

