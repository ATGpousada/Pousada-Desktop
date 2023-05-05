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
        private Cliente cliente;

        // ----------------- Propriedades ---------------------------
        public int Id { get => id; set => id = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<ClienteEndereco> Enderecos { get; set; }
        // -------------- Metodos Construtores ---------------------
        public ClienteEndereco() { }

        public ClienteEndereco(int id, string cep, string cidade, string uf, Cliente cliente)
        {
            // ---------------- Metodo com ID e Chave estrangeira ----------------------

            Id = id;
            Cep = cep;
            Cidade = cidade;
            Uf = uf;
            Cliente = cliente;
        }

        public ClienteEndereco(string cep, string cidade, string uf, Cliente cliente)
        {
            // ---------------- Metodo sem ID ----------------------
            Cep = cep;
            Cidade = cidade;
            Uf = uf;
            Cliente = cliente;
        }

        public ClienteEndereco(int id, string cep, string cidade, string uf)
        {
            Id = id;
            Cep = cep;
            Cidade = cidade;
            Uf = uf;
        }

        // -------------------- -----------------------------------------

        public ClienteEndereco(string cep, string cidade, string uf)
        {
            Cep = cep;
            Cidade = cidade;
            Uf = uf;
        }

     


        // ------------------ Inserir --------------------------------------

        public void Inserir(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert enderecos_cli (cep,cidade, uf, cliente_ID)" +
                " values (@cep,@cidade, @uf, " + id + ")";
            cmd.Parameters.Add("@cep", MySqlDbType.VarChar).Value = Cep;
            cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = Cidade;
            cmd.Parameters.Add("@uf", MySqlDbType.VarChar).Value = Uf;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        // --------------------------  Alterar ----------------------------------

        public void Alterar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update enderecos_clientes set cep = @cep,cidade = @cidade" +
                " uf = @uf where id = @id)";
            cmd.Parameters.Add("@cep", MySqlDbType.VarChar).Value = Cep;
            cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = Cidade;
            cmd.Parameters.Add("@uf", MySqlDbType.VarChar).Value = Uf;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
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
                        Cliente.ObterPorId(dr.GetInt32(4))
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
            cmd.CommandText = "select id,cep, cidade, uf from enderecos_cli where cliente_id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new ClienteEndereco(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3)
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
            cmd.CommandText = "select id, cep, cidade, uf from enderecos_cli where cliente_id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco = new ClienteEndereco(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3));
            }
            Banco.Fechar(cmd);
            return endereco;
        }
    }
}
