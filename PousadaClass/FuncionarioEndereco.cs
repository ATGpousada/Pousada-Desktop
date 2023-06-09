﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;

namespace PousadaClass
{
    public class FuncionarioEndereco
    {
        // Atributos
        private int id;
        private string logradouro;
        private string numero;
        private string cep;
        private string bairro;
        private string cidade;
        private string uf;
        private Funcionario funcionario;

        // Propriedades
        public int Id { get => id; set => id = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public Funcionario Funcionario { get => funcionario; set => funcionario = value; }
        public List<FuncionarioEndereco> Enderecos { get; set; }

        // Construtores
        public FuncionarioEndereco() { }
        public FuncionarioEndereco(int id, string logradouro, string numero, string cep, string bairro, string cidade, string uf, Funcionario funcionario)
        {
            Id = id;
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Funcionario = funcionario;
        }

        public FuncionarioEndereco(int id, string logradouro, string numero, string cep, string bairro, string cidade, string uf)
        {
            Id = id;
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
        }

        public FuncionarioEndereco(string logradouro, string numero, string cep, string bairro, string cidade, string uf)
        {
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
        }

        public FuncionarioEndereco(List<FuncionarioEndereco> endereco)
        {
            Enderecos = endereco;
        }

        /// <summary>
        /// Inserindo no banco de dados um determinado endereço de acordo com o funcionario que está sendo cadastrado
        /// </summary>
        /// <param name="id"></param>
        public void Inserir(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert enderecos_func (logradouro, numero, cep, bairro, cidade, uf, funcionario_ID)" +
                " values (@logradouro, @numero, @cep, @bairro, @cidade, @uf, "+ id +")";
            cmd.Parameters.Add("@logradouro", MySqlDbType.VarChar).Value = Logradouro;
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = Numero;
            cmd.Parameters.Add("@cep", MySqlDbType.VarChar).Value = Cep;
            cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = Bairro;
            cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = Cidade;
            cmd.Parameters.Add("@uf", MySqlDbType.VarChar).Value = Uf;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Alterando endereço de um determinado funcionario pela chave estrangeira do Funcionario
        /// </summary>
        /// <param name="id"></param>
        public void Alterar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update enderecos_func set logradouro = @logradouro, numero = @numero, cep = @cep, bairro = @bairro, cidade = @cidade," +
                " uf = @uf where funcionario_id = " + id;
            cmd.Parameters.Add("@logradouro", MySqlDbType.VarChar).Value = Logradouro;
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = Numero;
            cmd.Parameters.Add("@cep", MySqlDbType.VarChar).Value = Cep;
            cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = Bairro;
            cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = Cidade;
            cmd.Parameters.Add("@uf", MySqlDbType.VarChar).Value = Uf;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Listando todos os endereços ou pelo logradouro desejado de um funcionario ativo
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static List<FuncionarioEndereco> Listar(string nome = "")
        {
            List<FuncionarioEndereco> lista = new List<FuncionarioEndereco>();
            var cmd = Banco.Abrir();
            if (nome.Length > 0)
                cmd.CommandText = "select enderecos_func.*, funcionarios.nome FROM funcionarios" +
                    " INNER JOIN enderecos_func ON funcionarios.id = enderecos_func.funcionario_id" +
                    " where funcionarios.NOME like '%" + nome + "%' and demissao is null";
            else
                cmd.CommandText = "select enderecos_func.*, funcionarios.nome FROM funcionarios" +
                    " INNER JOIN enderecos_func ON funcionarios.id = enderecos_func.funcionario_id" +
                    " where demissao is null";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new FuncionarioEndereco(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        Funcionario.ObterPorId(dr.GetInt32(7))
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }

        /// <summary>
        /// Listando todos os endereços ou pelo logradouro desejado de um funcionario demitido
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static List<FuncionarioEndereco> ListarDemitidos(string nome = "")
        {
            List<FuncionarioEndereco> lista = new List<FuncionarioEndereco>();
            var cmd = Banco.Abrir();
            if (nome.Length > 0)
                cmd.CommandText = "select enderecos_func.*, funcionarios.nome FROM funcionarios" +
                    " INNER JOIN enderecos_func ON funcionarios.id = enderecos_func.funcionario_id" +
                    " where funcionarios.NOME like '%" + nome + "%' and demissao is not null";
            else
                cmd.CommandText = "select enderecos_func.*, funcionarios.nome FROM funcionarios" +
                    " INNER JOIN enderecos_func ON funcionarios.id = enderecos_func.funcionario_id" +
                    " where demissao is not null";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new FuncionarioEndereco(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        Funcionario.ObterPorId(dr.GetInt32(7))
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }

        /// <summary>
        /// Listando o endereço de um funcionario pelo Id desejado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<FuncionarioEndereco> ListarPorFuncionario(int id)
        {
            List<FuncionarioEndereco> lista = new List<FuncionarioEndereco>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, logradouro, numero, cep, bairro, cidade, uf from enderecos_func where funcionario_id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new FuncionarioEndereco(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6)
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }

        /// <summary>
        /// Listando o endereço de um funcionario pela chave estrangeira da tabela de Funcionario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static FuncionarioEndereco ObterPorIdForeign(int id)
        {
            var cmd = Banco.Abrir();
            FuncionarioEndereco endereco = null;
            cmd.CommandText = "select id, logradouro, numero, cep, bairro, cidade, uf from enderecos_func where funcionario_id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco = new FuncionarioEndereco(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6)
                    );
            }
            Banco.Fechar(cmd);
            return endereco;
        }
    }
}
