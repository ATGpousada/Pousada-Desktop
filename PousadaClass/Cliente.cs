using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  // versão --> 8.0.33

namespace PousadaClass
{
   public class Cliente
    {

        // ----------- Atributos -----------------
        private int id;
        private string nome;
        private string cpf;
        private string rg;
        private string senha;
        private string email;
        private string recupera;
        private DateTime arquivar;

        // ----------- Propriedades ------------------
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Email { get => email; set => email = value; }
        public string Recupera { get => recupera; set => recupera = value; }
        public DateTime Arquivar { get => arquivar; set => arquivar = value; }


        // --------- Metodos Construtores -----------------
        public Cliente (){ }

        public Cliente(int id, string nome, string cpf, string rg, string senha, string email, string recupera, DateTime arquivar)
        {

         // ----------  Metodo Construtor com ID ---------------------

            Id = id;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Senha = senha;
            Email = email;
            Recupera = recupera;
            Arquivar = arquivar;
        }

        public Cliente(string nome, string cpf, string rg, string senha, string email, string recupera, DateTime arquivar)
        {

            // ----------  Metodo Construtor sem ID ---------------------

            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Senha = senha;
            Email = email;
            Recupera = recupera;
            Arquivar = arquivar;
        }




    }
}
