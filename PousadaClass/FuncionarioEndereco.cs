using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert enderecos_func (logradouro, numero, cep, bairro, cidade, uf, funcionario_ID)" +
                " values (@logradouro, @numero, @cep, @bairro, @cidade, @uf, @funcionario)";
            cmd.Parameters.Add("@logradouro", MySqlDbType.VarChar).Value = Logradouro;
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = Numero;
            cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = Cidade;
            cmd.Parameters.Add("@uf", MySqlDbType.VarChar).Value = Uf;
            cmd.Parameters.Add("@funcionario", MySqlDbType.Int32).Value = Funcionario.Id;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }

        public void Alterar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update enderecos_func set logradouro = @logradouro, numero = @numero, cep = @cep, bairro = @bairro, cidade = @cidade" +
                " uf = @uf where id = @id)";
            cmd.Parameters.Add("@logradouro", MySqlDbType.VarChar).Value = Logradouro;
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = Numero;
            cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = Cidade;
            cmd.Parameters.Add("@uf", MySqlDbType.VarChar).Value = Uf;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
    }
}
