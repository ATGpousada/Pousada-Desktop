using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PousadaClass
{
    public class FuncionarioTelefone
    {
        // Atributos
        private int id;
        private string tipo;
        private string telefone;
        private Funcionario funcionario;

        // Propriedades
        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public Funcionario Funcionario { get => funcionario; set => funcionario = value; }
        public List<FuncionarioTelefone> Telefones {get; set;}

        // Construtores
        public FuncionarioTelefone() { }
        public FuncionarioTelefone(int id, string tipo, string telefone, Funcionario funcionario)
        {
            Id = id;
            Tipo = tipo;
            Telefone = telefone;
            Funcionario = funcionario;
        }
        public FuncionarioTelefone(int id, string tipo, string telefone)
        {
            Id = id;
            Tipo = tipo;
            Telefone = telefone;
        }

        public FuncionarioTelefone(string tipo, string telefone)
        {
            Tipo = tipo;
            Telefone = telefone;
        }

        public FuncionarioTelefone(List<FuncionarioTelefone> telefones)
        {
            Telefones = telefones;
        }

        /// <summary>
        /// Inserindo Telefone do funcionario no banco de dados
        /// </summary>
        /// <param name="_id"></param>
        public void Inserir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert telefones_func (tipo, tel, funcionario_ID) values (@tipo, @tel, " + _id +")";
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = Tipo;
            cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = Telefone;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Inserindo um Telefone para um funcionário existente
        /// </summary>
        /// <param name="_id"></param>
        /// <param name="tel"></param>
        /// <param name="tipo"></param>
        public void InserirTelExistente(int _id, string tel, string tipo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert telefones_func (tipo, tel, funcionario_ID) values ('" + tipo + "', '" + tel + "', " + _id + ")";
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Alterando o número e tipo de telefone do funcionário (Precisa dos dados do numero antigo que irá ser substituido)
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="tel"></param>
        /// <param name="id"></param>
        /// <param name="nAntigo"></param>
        /// <param name="tAntigo"></param>
        public void Alterar(string tipo, string tel, int id, string nAntigo, string tAntigo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update telefones_func set tipo = '" + tipo + "', tel = '" + tel + "' where funcionario_id = " + id + " and tipo = '" + tAntigo + "' and tel = '" + nAntigo + "'";
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Listando todos os telefones de todos os funcionarios ativos
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static List<FuncionarioTelefone> Listar(string nome = "")
        {
            List<FuncionarioTelefone> lista = new List<FuncionarioTelefone>();
            var cmd = Banco.Abrir();
            if (nome.Length > 0)
                cmd.CommandText = "SELECT telefones_func.*, funcionarios.nome FROM funcionarios " +
                    "INNER JOIN telefones_func ON funcionarios.id = telefones_func.funcionario_id " +
                    "where funcionarios.NOME like '%" + nome + "%' and demissao is null";
            else
                cmd.CommandText = "SELECT telefones_func.*, funcionarios.nome FROM funcionarios " +
                    "INNER JOIN telefones_func ON funcionarios.id = telefones_func.funcionario_id " +
                    "where demissao is null";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new FuncionarioTelefone(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),   
                        Funcionario.ObterPorId(dr.GetInt32(3))
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }

        /// <summary>
        /// Listando todos os telefones de todos os funcionarios demitidos
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static List<FuncionarioTelefone> ListarDemitidos(string nome = "")
        {
            List<FuncionarioTelefone> listaDemitido = new List<FuncionarioTelefone>();
            var cmd = Banco.Abrir();
            if (nome.Length > 0)
                cmd.CommandText = "SELECT telefones_func.*, funcionarios.nome FROM funcionarios " +
                    "INNER JOIN telefones_func ON funcionarios.id = telefones_func.funcionario_id " +
                    "where funcionarios.NOME like '%" + nome + "%' and demissao is not null";
            else
                cmd.CommandText = "SELECT telefones_func.*, funcionarios.nome FROM funcionarios " +
                    "INNER JOIN telefones_func ON funcionarios.id = telefones_func.funcionario_id " +
                    "where demissao is not null";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaDemitido.Add(new FuncionarioTelefone(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        Funcionario.ObterPorId(dr.GetInt32(3))
                    ));
            }
            Banco.Fechar(cmd);
            return listaDemitido;
        }

        /// <summary>
        /// Listando todos os telefones de todos os funcionarios por um determinado ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<FuncionarioTelefone> ListarPorFuncionario(int id)
        {
            List<FuncionarioTelefone> lista = new List<FuncionarioTelefone>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, tipo, tel from telefones_func where funcionario_id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new FuncionarioTelefone(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2)
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }

        /// <summary>
        /// Buscando Informações de um determinado funcionario pela chave estrangeira da tabela de funcionario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static FuncionarioTelefone ObterPorIdForeign(int id)
        {
            var cmd = Banco.Abrir();
            FuncionarioTelefone endereco = null;
            cmd.CommandText = "select id, tipo, tel from telefones_func where funcionario_id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco = new FuncionarioTelefone(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2)
                        );
            }
            Banco.Fechar(cmd);
            return endereco;
        }

        /// <summary>
        /// Buscando Informações de um determinado funcionario pela chave estrangeira da tabela de funcionario por ordem Descresente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static FuncionarioTelefone ObterPorIdForeign2(int id)
        {
            var cmd = Banco.Abrir();
            FuncionarioTelefone endereco = null;
            cmd.CommandText = "select id, tipo, tel from telefones_func where funcionario_id = " + id + " Order By id DESC";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco = new FuncionarioTelefone(
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
