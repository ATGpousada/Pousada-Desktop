using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace PousadaClass
{
    public class Cargo
    {
        // Atributos
        private int id;
        private string nome;
        private string descricao;
        private DateTime arquivar;

        // Propriedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Arquivar { get => arquivar; set => arquivar = value; }

        // Construtor
        public Cargo() { }
        public Cargo(int id, string nome, string descricao, DateTime arquivar)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Arquivar = arquivar;
        }

        public Cargo(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

        public Cargo(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        /// <summary>
        /// Inserir Cargo no Banco de dados
        /// </summary>
        public void Criar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert cargos (nome, descricao) values (@nome, @descricao)";
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = Descricao;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Listando o nome dos cargos pelo banco de dados (Lista todos ou algo especifico)
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static List<Cargo> Listar()
        {
            List<Cargo> lista = new List<Cargo>();
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandText = "select * from cargos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cargo(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2)
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }

        /// <summary>
        /// Retornando do banco de dados o ID do nivel pedido
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Cargo ObterPorId(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from cargos where id = " + id;
            var dr = cmd.ExecuteReader();
            Cargo cargo = null;
            while (dr.Read())
            {
                cargo = new Cargo(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDateTime(3)
                    );
            }
            return cargo;
        }

        /// <summary>
        /// Atualizando o Cargo do Funcionario no Banco de dados
        /// </summary>
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update cargos set nome = @nome, descricao = @desc where id = @id";
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = Descricao;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        public void ArquivarCargo()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update cargos set arquivar_em = default where id = @id";
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
    }
}
