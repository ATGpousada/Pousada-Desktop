using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        private string arquivar;

        // Propriedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Arquivar { get => arquivar; set => arquivar = value; }

        // Construtor
        public Cargo() { }
        public Cargo(int id, string nome, string descricao, string arquivar)
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
        /// O método tem a intenção de inserir um novo cargo no banco de dados
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert cargos (nome, descricao, arquivar_em) values (@nome, @descricao, default)";
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = Descricao;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// O método tem a intenção de listar todos os cargos que não estão arquivados
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static List<Cargo> Listar()
        {
            List<Cargo> lista = new List<Cargo>();
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandText = "select * from cargos where arquivar_em = 'N'";
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
        /// O método tem a intenção de listar todos os cargos e também pode ser uma pesquisa filtrada pelo nome
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static List<Cargo> ListarPorCargo(string nome)
        {
            List<Cargo> lista = new List<Cargo>();
            MySqlCommand cmd = Banco.Abrir();

            if (nome.Length > 0)
                cmd.CommandText = "select * from cargos where nome = " + nome;
            else
                cmd.CommandText = "select * from cargos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cargo(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3)
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }

        /// <summary>
        /// O método tem a intenção de retornar do banco de dados o ID do nivel pedido
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Cargo ObterPorId(int id)
       {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, nome, descricao from cargos where id = " + id;
            var dr = cmd.ExecuteReader();
            Cargo cargo = null;
            while (dr.Read())
            {
                cargo = new Cargo(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    );
            }
            return cargo;
        }

        /// <summary>
        /// O método tem a intenção de atualizar o Cargo do Funcionario no Banco de dados
        /// </summary>
        public void Atualizar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update cargos set nome = @nome, descricao = @desc, arquivar_em = @arquivar where id = " + id;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = Descricao;
            cmd.Parameters.Add("@arquivar", MySqlDbType.VarChar).Value = Arquivar;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// O método tem a intenção de buscar do banco de dados pelo o nome do cargo se o cargo está arquivado ou não; Retorna em booleano
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public bool BuscaArquivado(string nome)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from cargos where arquivar_em = 'N' and nome = '" + nome + "'";
            var reader = cmd.ExecuteReader();

            bool resultado = reader.Read();

            reader.Close();
            Banco.Fechar(cmd);

            return resultado;
        }

        /// <summary>
        /// O método tem a intenção de arquivar o cargo
        /// </summary>
        /// <param name="id"></param>
        public static void ArquivarCargo(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update cargos set arquivar_em = 'S' where id = " + id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// O método tem a intenção de restaurar o cargo
        /// </summary>
        /// <param name="id"></param>
        public static void RestaurarCargo(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update cargos set arquivar_em = 'N' where id = " + id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
    }
}
