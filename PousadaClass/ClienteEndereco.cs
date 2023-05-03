using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  // versão --> 8.0.33

namespace PousadaClass
{
 public class ClienteEndereco
    {
        //-------------------- Atributos ----------------------------
        private int id;
        private string cep;
        private string cidade;
        private string uf;
        private Cliente cliente;

        // ----------------- Propriedades ---------------------------
        public int Id { get => id; set => id = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }

        // -------------- Metodos Construtores ---------------------
        public ClienteEndereco() { }

        public ClienteEndereco(int id, string cep, string cidade, string uf, Cliente cliente)
        {
            // ---------------- Metodo com ID ----------------------

            Id = id;
            Cep = cep;
            Cidade = cidade;
            Uf = uf;
            Cliente = cliente;
        }

        public ClienteEndereco(string cep, string cidade, string uf, Cliente cliente)
        {
            // ---------------- Metodo sem ID ----------------------
            Cep = cep;
            Cidade = cidade;
            Uf = uf;
            Cliente = cliente;
        }

        public ClienteEndereco(string cep, string cidade, string uf)
        {
            // ---------------- Metodo sem ID e chave Estrangeira ----------------------
            Cep = cep;
            Cidade = cidade;
            Uf = uf;
        }
    }
}
