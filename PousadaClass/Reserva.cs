using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;  // versão --> 8.0.33



namespace PousadaClass
{
    public class Reserva
    {
        private Timestamp data_reserva;
        private DateTime data_entrada;
        private DateTime data_saida;
        private int acompanhantes;
    }
}
