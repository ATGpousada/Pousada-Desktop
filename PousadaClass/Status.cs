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

        public void Inserir()
        {

        }

    }
}
