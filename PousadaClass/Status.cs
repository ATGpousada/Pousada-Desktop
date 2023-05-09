using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PousadaClass
{
    public class Status
    {
        private int id;
        private string nome;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }

        public Status(){}
        public Status(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Status(string nome)
        {
            Nome = nome;
        }

        public static List<Status> Listar()
        {
            List<Status> status = new List<Status>();
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandText = "select * from status where id > 3";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                status.Add(new Status(
                        dr.GetInt32(0),
                        dr.GetString(1)
                        ));
            }
            Banco.Fechar(cmd);
            return status;
        }

        public static Status ObterPorId(int id)
        {
            var cmd = Banco.Abrir();
            Status status = null;
            cmd.CommandText = "select * from status where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                status = new Status(
                    dr.GetInt32(0),
                    dr.GetString(1)
                    );
            }
            Banco.Fechar(cmd);
            return status;
        }
    }
}
