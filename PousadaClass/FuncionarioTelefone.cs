﻿using System;
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

        // Construtores
        public FuncionarioTelefone() { }
        public FuncionarioTelefone(int id, string tipo, string telefone, Funcionario funcionario)
        {
            Id = id;
            Tipo = tipo;
            Telefone = telefone;
            Funcionario = funcionario;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert telefones_func (tipo, tel, funcionario_ID) values (@tipo, @tel, @funcionario)";
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = Tipo;
            cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = Telefone;
            cmd.Parameters.Add("@funcionario", MySqlDbType.VarChar).Value = Funcionario;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }

        public void Alterar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update telefones_func set tipo = @tipo, tel = @tel where id = @id";
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = Tipo;
            cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = Telefone;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = Id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
    }
}