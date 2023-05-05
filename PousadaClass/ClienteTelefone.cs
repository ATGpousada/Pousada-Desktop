using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  // versão --> 8.0.33

namespace PousadaClass
{
    public class ClienteTelefone
    {
        // -------------- Atributos -------------------------
        private int id;
        private string tipo;
        private string telefone;
        private Cliente cliente;

        // ------------- Propriedades -----------------------
        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public Cliente Cliente{ get => cliente; set => cliente = value; }
        public List<ClienteTelefone> Telefones { get; set; }
        //  ---------- Metodos Construtores ----------------------

        public ClienteTelefone() { }

        public ClienteTelefone(int id, string tipo, string telefone, Cliente cliente)
        {
            Id = id;
            Tipo = tipo;
            Telefone = telefone;
            Cliente = cliente;
        }
        public ClienteTelefone(int id, string tipo, string telefone)
        {
            Id = id;
            Tipo = tipo;
            Telefone = telefone;
        }

        public ClienteTelefone(string tipo, string telefone)
        {
            Tipo = tipo;
            Telefone = telefone;
        }

        public ClienteTelefone(List<ClienteTelefone> telefone)
        {
            Telefones = telefone;
        }


        // -------------------- Inserindo ------------------------------

        public void Inserir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert telefones_cli (tipo, tel, cliente_ID) values (@tipo, @tel, " + _id + ")";
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = Tipo;
            cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = Telefone;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }


        // -------------------- Alterar ---------------------------------


        public void Alterar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update telefones_cli set tipo = @tipo, tel = @tel where id = @id";
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = Tipo;
            cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = Telefone;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = Id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        // ------------------ Listar pelo Nome -----------------------------------


        public static List<ClienteTelefone> Listar(string nome = "")
        {
            List<ClienteTelefone> lista = new List<ClienteTelefone>();
            var cmd = Banco.Abrir();
            if (nome.Length > 0)
                cmd.CommandText = "SELECT telefones_cli.*, clientes.nome FROM clientes " +
                    "INNER JOIN telefones_cli ON clientes.id = telefones_clientes.clientes_id " +
                    "where clientes.NOME like '%" + nome + "%'";
            else
                cmd.CommandText = "select * from telefones_cli";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new ClienteTelefone(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        Cliente.ObterPorId(dr.GetInt32(3))
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }


        // ---------------------  Listar por ID -------------------------------------

        public static List<ClienteTelefone> ListarPorClintes(int id)
        {
            List<ClienteTelefone> lista = new List<ClienteTelefone>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, tipo, tel from telefones_func where funcionario_id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new ClienteTelefone(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2)
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }

        public static ClienteTelefone ObterPorIdForeign(int id)
        {
            var cmd = Banco.Abrir();
            ClienteTelefone endereco = null;
            cmd.CommandText = "select id, tipo, tel from telefones_cli where cliente_id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco = new ClienteTelefone(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2)
                        );
            }
            Banco.Fechar(cmd);
            return endereco;
        }


        // Obtendo Chave estrangeira
        public static ClienteTelefone ObterPorIdForeign2(int id)
        {
            var cmd = Banco.Abrir();
            ClienteTelefone endereco = null;
            cmd.CommandText = "select id, tipo, tel from telefones_cli where cliente_id = " + id + " Order By id DESC";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco = new ClienteTelefone(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2)
                        );
            }
            Banco.Fechar(cmd);
            return endereco;
        }

    }
}
