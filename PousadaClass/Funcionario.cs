﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PousadaClass
{
    public class Funcionario
    {
        // Atributos
        private int id;
        private string nome;
        private DateTime data_nasc;
        private string cpf;
        private string rg;
        private double salario;
        private string email;
        private string senha;
        private string Periodo;
        private DateTime admissao;
        private DateTime demissao;
        private Cargo cargo;

        // Propriedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime Data_nasc { get => data_nasc; set => data_nasc = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Periodo1 { get => Periodo; set => Periodo = value; }
        public DateTime Admissao { get => admissao; set => admissao = value; }
        public DateTime Demissao { get => demissao; set => demissao = value; }
        public Cargo Cargo { get => cargo; set => cargo = value; }


        public Funcionario() { }
        public Funcionario(int id, string nome, DateTime data_nasc, string cpf, string rg, double salario, string email, string senha, string periodo, DateTime admissao, DateTime demissao, Cargo cargo)
        {
            Id = id;
            Nome = nome;
            Data_nasc = data_nasc;
            Cpf = cpf;
            Rg = rg;
            Salario = salario;
            Email = email;
            Senha = senha;
            Periodo1 = periodo;
            Admissao = admissao;
            Demissao = demissao;
            Cargo = cargo;
        }

        public Funcionario(int id, string nome, DateTime data_nasc, string cpf, string rg, double salario, string email, string periodo, DateTime admissao, DateTime demissao, Cargo cargo)
        {
            Id = id;
            Nome = nome;
            Data_nasc = data_nasc;
            Cpf = cpf;
            Rg = rg;
            Salario = salario;
            Email = email;
            Periodo1 = periodo;
            Admissao = admissao;
            Demissao = demissao;
            Cargo = cargo;
        }

        public Funcionario(int id, string nome, DateTime data_nasc, string cpf, string rg, double salario, string email, string periodo, Cargo cargo)
        {
            Id = id;
            Nome = nome;
            Data_nasc = data_nasc;
            Cpf = cpf;
            Rg = rg;
            Salario = salario;
            Email = email;
            Periodo1 = periodo;
            Cargo = cargo;
        }


        public Funcionario(string nome, DateTime data_nasc, string cpf, string rg, double salario, string email, string senha, string periodo, Cargo cargo)
        {
            Nome = nome;
            Data_nasc = data_nasc;
            Cpf = cpf;
            Rg = rg;
            Salario = salario;
            Email = email;
            Senha = senha;
            Periodo1 = periodo;
            Cargo = cargo;
        }

        // Construtor

        /// <summary>
        /// Inserindo funcionario no banco de dados
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert funcionarios (nome, data_nasc, cpf, rg, salario, email, senha, periodo, admissao, cargos_ID) " +
                "values (@nome, @data_nasc, @cpf, @rg, @salario, @email, @senha, @periodo, default, @cargo)";
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@data_nasc", MySqlDbType.DateTime).Value = Data_nasc;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Cpf;
            cmd.Parameters.Add("@rg", MySqlDbType.VarChar).Value = Rg;
            cmd.Parameters.Add("@salario", MySqlDbType.VarChar).Value = Salario;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Senha;
            cmd.Parameters.Add("@periodo", MySqlDbType.VarChar).Value = Periodo1;
            cmd.Parameters.Add("@cargo", MySqlDbType.VarChar).Value = Cargo.Id;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteNonQuery());
            Banco.Fechar(cmd);
        }

        public static List<Funcionario> Listar()
        {
            List<Funcionario> lista = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from funcionarios";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Funcionario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDateTime(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDouble(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetDateTime(8),
                    dr.GetDateTime(9),
                    Cargo.ObterPorId(dr.GetInt32(8))
                    ));
            }
            return lista;
        }
    }
}
