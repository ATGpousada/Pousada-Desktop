﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
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
        public List<FuncionarioEndereco> Enderecos { get; set; }
        public List<FuncionarioTelefone> Telefones { get; set; }


        public Funcionario() { }
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

        public Funcionario(int id, string nome, DateTime data_nasc, string cpf, string rg, double salario, string email, string senha, string periodo, DateTime admissao, Cargo cargo)
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
            Cargo = cargo;
        }

        public Funcionario(string nome, DateTime data_nasc, string cpf, string rg, double salario, string email, string senha, string periodo, Cargo cargo, List<FuncionarioEndereco> endereco, List<FuncionarioTelefone> telefone)
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
            Enderecos = endereco;
            Telefones = telefone;
        }

        public Funcionario (string nome, DateTime data_nasc, string rg, double salario, string periodo, Cargo cargo, List<FuncionarioEndereco> endereco)
        {
            Nome = nome;
            Data_nasc = data_nasc;
            Rg = rg;
            Salario = salario;
            Periodo1 = periodo;
            Cargo = cargo;
            Enderecos = endereco;
        }

        public Funcionario(string nome, DateTime data_nasc, string cpf, string rg, double salario, string email, string periodo, Cargo cargo, List<FuncionarioEndereco> endereco, List<FuncionarioTelefone> telefone)
        {
            Nome = nome;
            Data_nasc = data_nasc;
            Cpf = cpf;
            Rg = rg;
            Salario = salario;
            Email = email;
            Periodo1 = periodo;
            Cargo = cargo;
            Enderecos = endereco;
            Telefones = telefone;
        }

        public Funcionario(string nome, DateTime data_nasc, string cpf, string rg, double salario, string email, string periodo, Cargo cargo, List<FuncionarioEndereco> endereco)
        {
            Nome = nome;
            Data_nasc = data_nasc;
            Cpf = cpf;
            Rg = rg;
            Salario = salario;
            Email = email;
            Periodo1 = periodo;
            Cargo = cargo;
            Enderecos = endereco;
        }

        public Funcionario(string nome, DateTime data_nasc, double salario, string email, string periodo, Cargo cargo, List<FuncionarioEndereco> endereco)
        {
            Nome = nome;
            Data_nasc = data_nasc;
            Salario = salario;
            Email = email;
            Periodo1 = periodo;
            Cargo = cargo;
            Enderecos = endereco;
        }

        public Funcionario(string email, string cpf, string rg)
        {
            Email = email;
            Cpf = cpf;
            Rg = rg;
        }

        public Funcionario(int _id)
        {
            Telefones = FuncionarioTelefone.ListarPorFuncionario(_id);
            Enderecos = FuncionarioEndereco.ListarPorFuncionario(_id);
        }

        // Construtor

        /// <summary>
        /// Inserindo Funcionario no banco de dados e adicionando uma lista de telefones e um endereço
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert funcionarios (nome, data_nasc, cpf, rg, salario, email, senha, periodo, admissao, cargos_ID) " +
                "values (@nome, @data_nasc, @cpf, @rg, @salario, @email, MD5(@senha), @periodo, default, @cargo)";
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
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            foreach (var telefone in Telefones)
            {
                telefone.Inserir(Id);
            }
            foreach (var endereco in Enderecos)
            {
                endereco.Inserir(Id);
            }
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Alterando dados de um funcionarios especifico puxando pelo ID
        /// </summary>
        /// <param name="id"></param>
        public void Alterar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update funcionarios set nome = @nome, data_nasc = @data, cpf = @cpf, rg = @rg, salario = @salario, email = @email, " +
                "periodo = @periodo, cargos_id = @cargo where id = " + id;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@data", MySqlDbType.DateTime).Value = Data_nasc;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Cpf;
            cmd.Parameters.Add("@rg", MySqlDbType.VarChar).Value = Rg;
            cmd.Parameters.Add("@salario", MySqlDbType.VarChar).Value = Salario;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            cmd.Parameters.Add("@periodo", MySqlDbType.VarChar).Value = Periodo1;
            cmd.Parameters.Add("@cargo", MySqlDbType.Int32).Value = Cargo.Id;
            cmd.ExecuteNonQuery();

            foreach (FuncionarioEndereco endereco in Enderecos)
            {
                endereco.Alterar(id);
            }
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Demitir um determinado funcionario pelo ID desejado
        /// </summary>
        /// <param name="id"></param>
        public void Demitir(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update funcionarios set demissao = now() where id = " + id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Verificando se esse Funcionario pesquisado foi demitido ou não
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool VerificarDemissao(int id)
        {
            bool demitido = false;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from funcionarios where id = '"+ id +"' and demissao is not null";
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                demitido = true;
            }
            reader.Close();
            Banco.Fechar(cmd);
            return demitido;
        }

        /// <summary>
        /// Alterando apenas o email de funcionario
        /// </summary>
        /// <param name="id"></param>
        public void AlterarEmail(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update funcionarios set nome = @nome, data_nasc = @data, salario = @salario, email = @email, " +
                "periodo = @periodo, cargos_id = @cargo where id = " + id;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@data", MySqlDbType.DateTime).Value = Data_nasc;
            cmd.Parameters.Add("@salario", MySqlDbType.VarChar).Value = Salario;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            cmd.Parameters.Add("@periodo", MySqlDbType.VarChar).Value = Periodo1;
            cmd.Parameters.Add("@cargo", MySqlDbType.Int32).Value = Cargo.Id;
            cmd.ExecuteNonQuery();

            foreach (FuncionarioEndereco endereco in Enderecos)
            {
                endereco.Alterar(id);
            }
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Alterando apenas o RG de um determinado funcionario
        /// </summary>
        /// <param name="id"></param>
        public void AlterarRG(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update funcionarios set nome = @nome, data_nasc = @data, rg = @rg, salario = @salario, " +
                "periodo = @periodo, cargos_id = @cargo where id = " + id;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@data", MySqlDbType.DateTime).Value = Data_nasc;
            cmd.Parameters.Add("@rg", MySqlDbType.VarChar).Value = Rg;
            cmd.Parameters.Add("@salario", MySqlDbType.VarChar).Value = Salario;
            cmd.Parameters.Add("@periodo", MySqlDbType.VarChar).Value = Periodo1;
            cmd.Parameters.Add("@cargo", MySqlDbType.Int32).Value = Cargo.Id;
            cmd.ExecuteNonQuery();

            foreach (FuncionarioEndereco endereco in Enderecos)
            {
                endereco.Alterar(id);
            }
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Alterando o CPF de um unico funcionario pelo Id
        /// </summary>
        /// <param name="id"></param>
        public void AlterarCPF(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update funcionarios set nome = @nome, data_nasc = @data, cpf = @cpf, salario = @salario, " +
                "periodo = @periodo, cargos_id = @cargo where id = " + id;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@data", MySqlDbType.DateTime).Value = Data_nasc;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Rg;
            cmd.Parameters.Add("@salario", MySqlDbType.VarChar).Value = Salario;
            cmd.Parameters.Add("@periodo", MySqlDbType.VarChar).Value = Periodo1;
            cmd.Parameters.Add("@cargo", MySqlDbType.Int32).Value = Cargo.Id;
            cmd.ExecuteNonQuery();

            foreach (FuncionarioEndereco endereco in Enderecos)
            {
                endereco.Alterar(id);
            }
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Listando todos os funcionarios que estão ativos na empresa e pode buscar por determinado Nome
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static List<Funcionario> Listar(string nome = "")
        {
            List<Funcionario> lista = new List<Funcionario>();
            var cmd = Banco.Abrir();
            if (nome.Length > 0)
                cmd.CommandText = "select id, nome, data_nasc, cpf, rg, salario, email, senha, periodo, admissao, cargos_id from funcionarios where nome like '%" + nome + "%' and demissao is null";
            else
                cmd.CommandText = "select id, nome, data_nasc, cpf, rg, salario, email, senha, periodo, admissao, cargos_id from funcionarios where demissao is null";
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
                    dr.GetString(8),
                    dr.GetDateTime(9),
                    Cargo.ObterPorId(dr.GetInt32(10))
                    ));
            }
            return lista;
        }

        /// <summary>
        /// Buscando determinado Funcionario ou listando todos os funcionarios demitidos na empresa
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static List<Funcionario> ListarDemitido(string nome = "")
        {
            List<Funcionario> lista = new List<Funcionario>();
            Funcionario func = null;
            var cmd = Banco.Abrir();
            if (nome.Length > 0)
                cmd.CommandText = "select * from funcionarios where nome like '%" + nome + "%' and demissao is not null";
            else
                cmd.CommandText = "select * from funcionarios where demissao is not null";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                func = new Funcionario();
                func.Id = dr.GetInt32(0);
                func.Nome = dr.GetString(1);
                func.Data_nasc = dr.GetDateTime(2);
                func.Cpf = dr.GetString(3);
                func.Rg = dr.GetString(4);
                func.Salario = dr.GetDouble(5);
                func.Email = dr.GetString(6);
                func.Senha = dr.GetString(7);
                func.Periodo1 = dr.GetString(8);
                func.Admissao = dr.GetDateTime(9);
                func.Demissao = dr.GetDateTime(10);
                Cargo.ObterPorId(dr.GetInt32(11));
                lista.Add(func);
            }
            return lista;
        }
        
        /// <summary>
        /// Buscando determinado funcionario pelo Id desejado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Funcionario ObterPorId(int id)
        {
            var cmd = Banco.Abrir();
            Funcionario funcionario = null;
            cmd.CommandText = "select id, nome, data_nasc, cpf, rg, salario, email, senha, periodo, admissao, cargos_id from funcionarios where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                funcionario = new Funcionario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDateTime(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDouble(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8),
                    dr.GetDateTime(9),
                    Cargo.ObterPorId(dr.GetInt32(10))
                    );
            }
            Banco.Fechar(cmd);
            return funcionario;
        }

        /// <summary>
        /// Buscando determinado funcionario pelo Email inserido
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static Funcionario ObterPorEmail(string email)
        {
            var cmd = Banco.Abrir();
            Funcionario funcionario = null;
            cmd.CommandText = "select id, nome, data_nasc, cpf, rg, salario, email, senha, periodo, admissao, cargos_id from funcionarios where email = '" + email + "'";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                funcionario = new Funcionario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDateTime(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDouble(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8),
                    dr.GetDateTime(9),
                    Cargo.ObterPorId(dr.GetInt32(10))
                    );
            }
            Banco.Fechar(cmd);
            return funcionario;
        }

        /// <summary>
        /// Buscando Campos que são Unico no banco de dados para descobrir se poderá ser alterado ou não, serve para descobrir se determinado email ja foi cadastrado ou não
        /// </summary>
        /// <param name="email"></param>
        /// <param name="rg"></param>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public static bool BuscarCampos(string email, string rg, string cpf)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, cpf, rg, email from funcionarios where email = '" + email + "' or rg = '" + rg + "' or cpf = '" + cpf + "';";
            var dr = cmd.ExecuteReader();
            bool existe = dr.HasRows;
            Banco.Fechar(cmd);
            return existe;
        }

        /// <summary>
        /// Buscando pelo Email se o Email já está cadastrado ou não
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool BuscarEmail(string email)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, email from funcionarios where email = '" + email  + "';";
            var dr = cmd.ExecuteReader();
            bool existe = dr.HasRows;
            Banco.Fechar(cmd);
            return existe;
        }

        /// <summary>
        /// Buscando pelo RG se o RG já está cadastrado ou não
        /// </summary>
        /// <param name="rg"></param>
        /// <returns></returns>
        public static bool BuscarRG(string rg)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, rg from funcionarios where email = '" + rg + "';";
            var dr = cmd.ExecuteReader();
            bool existe = dr.HasRows;
            Banco.Fechar(cmd);
            return existe;
        }

        /// <summary>
        /// Buscando pelo CPF se o CPF já está cadastrado ou não
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public static bool BuscarCPF(string cpf)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, cpf from funcionarios where cpf = '" + cpf + "';";
            var dr = cmd.ExecuteReader();
            bool existe = dr.HasRows;
            Banco.Fechar(cmd);
            return existe;
        }

    }
}
