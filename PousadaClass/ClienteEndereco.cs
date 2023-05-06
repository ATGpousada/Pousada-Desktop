using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  // versão --> 8.0.33

namespace PousadaClass
{
 public class ClienteEndereco
    {
        //-------------------- Atributos ----------------------------
        private int id;
        private string cep;
        private string cidade;
        private string uf;
        private string numero;
        private string logradouro;
        private Cliente cliente;

        // ----------------- Propriedades ---------------------------
        public int Id { get => id; set => id = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public List<ClienteEndereco> Enderecos { get; set; }
        // -------------- Metodos Construtores ---------------------
        public ClienteEndereco() { }

        public ClienteEndereco(int id, string cep, string cidade, string uf, string numero,string logradouro, Cliente cliente)
        {
            // ---------------- Metodo com ID e Chave estrangeira ----------------------

            Id = id;
            Cep = cep;
            Cidade = cidade;
            Uf = uf;
            Numero = numero;
            Logradouro = logradouro;
            Cliente = cliente;
        }

        public ClienteEndereco(string cep, string cidade, string uf, string logradouro, string numero, Cliente cliente)
        {
            // ---------------- Metodo sem ID ----------------------
            Cep = cep;
            Cidade = cidade;
            Uf = uf;
            Logradouro = logradouro;
            Numero = numero;
            Cliente = cliente;
        }

        public ClienteEndereco(int id, string cep, string cidade, string uf, string logradouro, string numero)
        {
            Id = id;
            Cep = cep;
            Cidade = cidade;
            Uf = uf;
            Logradouro = logradouro;
            Numero = numero;
          
        }

        // -------------------- -----------------------------------------

        public ClienteEndereco(string cep, string cidade, string uf, string numero, string logradouro)
        {
            Cep = cep;
            Cidade = cidade;
            Uf = uf;
            Numero = numero;
            Logradouro = logradouro;
        }

     


        // ------------------ Inserir --------------------------------------

        public void Inserir(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert enderecos_cli (cep,cidade, uf,logradouro,numero,cliente_ID)" +
                " values (@cep, @cidade, @uf, @logradouro, @numero, " + id + ")";
            cmd.Parameters.Add("@cep", MySqlDbType.VarChar).Value = Cep;
            cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = Cidade;
            cmd.Parameters.Add("@uf", MySqlDbType.VarChar).Value = Uf;
            cmd.Parameters.Add("@logradouro", MySqlDbType.VarChar).Value = Logradouro;
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = Numero;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        // --------------------------  Alterar ----------------------------------

        public void Alterar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update enderecos_cli set cep = @cep,cidade = @cidade" +
                " uf = @uf,logradouro = @logradouro, numero =  @numero  where cliente_id = " + id;

            cmd.Parameters.Add("@cep", MySqlDbType.VarChar).Value = Cep;
            cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = Cidade;
            cmd.Parameters.Add("@uf",MySqlDbType.VarChar).Value= Uf;
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = Numero;
            cmd.Parameters.Add("@logradouro", MySqlDbType.VarChar).Value = Logradouro;

            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        // ------------------------  Listar por nome ----------------------------------

        public static List<ClienteEndereco> Listar(string nome = "")
        {
            List<ClienteEndereco> lista = new List<ClienteEndereco>();
            var cmd = Banco.Abrir();
            if (nome.Length > 0)
                cmd.CommandText = "select enderecos_cli.*, clientes.nome FROM clientes" +
                    " INNER JOIN enderecos_cli ON clientes.id = enderecos_cli.cliente_id" +
                    " where clientes.NOME like '%" + nome + "%'";
            else
                cmd.CommandText = "select * from enderecos_cli";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new ClienteEndereco(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        Cliente.ObterPorId(dr.GetInt32(6))
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }

        //  ---------------------------- Listar por ID ------------------------------------

        public static List<ClienteEndereco> ListarPorCliente(int id)
        {
            List<ClienteEndereco> lista = new List<ClienteEndereco>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id,cep, cidade, uf, logradouro,numero from enderecos_cli where cliente_id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new ClienteEndereco(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                         dr.GetString(4),
                        dr.GetString(5)
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }

        // ------------------------  Obtendo Chave estrangeira ---------------------------------

        public static ClienteEndereco ObterPorIdForeign(int id)
        {
            var cmd = Banco.Abrir();
            ClienteEndereco endereco = null;
            cmd.CommandText = "select id, cep, cidade, uf,logradouro,numero from enderecos_cli where cliente_id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco = new ClienteEndereco(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5)
                        );
            }
            Banco.Fechar(cmd);
            return endereco;
        }
    }
}
