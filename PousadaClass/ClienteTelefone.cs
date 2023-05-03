using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  // versão --> 8.0.33

namespace PousadaClass
{
    public class ClienteTelefone
    {
        // -------------- Atributos -------------------------
        private int id;
        private string tipo;
        private string numero;

      
        // ------------- Propriedades -----------------------
        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Numero { get => numero; set => numero = value; }

        //  ---------- Metodos Construtores ----------------------

       public ClienteTelefone() { }

        public ClienteTelefone(int id, string tipo, string numero)
        {
            Id = id;
            Tipo = tipo;
            Numero = numero;
        }
        public ClienteTelefone(string tipo, string numero)
        {
            Tipo = tipo;
            Numero = numero;
        }

    }
}
