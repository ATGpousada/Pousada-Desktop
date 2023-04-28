using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using static Mysqlx.Notice.Warning.Types;

namespace PousadaClass
{
    internal class Cargo
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
        public Cargo(int id, string nome, string descricao, DateTime arquivar)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Arquivar = arquivar;
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
        public static List<Cargo> Listar(string nome = "")
        {
            List<Cargo> lista = new List<Cargo>();
            MySqlCommand cmd = Banco.Abrir();
            if (nome.Length > 0)
                cmd.CommandText = "select * from cargos where nome like '%" + nome + "%'";
            else
                cmd.CommandText = "select * from cargos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cargo(
                        dr.GetString(0),
                        dr.GetString(1)
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }
    }
}
