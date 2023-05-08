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
        private string status;

        public int Id { get => id; set => id = value; }
        public string Status1 { get => status; set => status = value; }

        public Status(){}
        public Status(int id, string status1)
        {
            Id = id;
            Status1 = status1;
        }

        public Status(string status1)
        {
            Status1 = status1;
        }

        public static List<Status> Listar()
        {
            List<Status> statuss = new List<Status>();
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandText = "select * from status";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                statuss.Add(new Status(
                        dr.GetInt32(0),
                        dr.GetString(1)
                        ));
            }
            Banco.Fechar(cmd);
            return statuss;
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
