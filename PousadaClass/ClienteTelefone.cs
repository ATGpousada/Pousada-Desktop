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

        /// <summary>
        /// Inserindo Telefone do cliente no banco de dados
        /// </summary>
        /// <param name="_id"></param>
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

        /// <summary>
        /// Alterando o número e tipo de telefone do cliente (Precisa dos dados do numero antigo que irá ser substituido)
        /// </summary>
        public void Alterar(string tipo, string tel, int id, string nAntigo, string tAntigo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update telefones_func set tipo = '" + tipo + "', tel = '" + tel + "' where funcionario_id = " + id + " and tipo = '" + tAntigo + "' and tel = '" + nAntigo + "'";
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        // ------------------ Listar pelo Nome -----------------------------------

        /// <summary>
        ///  Listando todos os telefones de todos os clientes ou pelo nome do cliente
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Listando todos os telefones de todos os clientes por um determinado ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Buscando Informações de um determinado cliente pela chave estrangeira da tabela de cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Buscando Informações de um determinado cliente pela chave estrangeira da tabela de cliente por ordem Descresente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Inserindo um Telefone para um cliente existente
        /// </summary>
        /// <param name="_id"></param>
        /// <param name="tel"></param>
        /// <param name="tipo"></param>
        public void InserirTelExistente(int _id, string tel, string tipo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert telefones_cli (tipo, tel, cliente_ID) values ('" + tipo + "', '" + tel + "', " + _id + ")";
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
    }
}
