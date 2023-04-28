using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PousadaClass
{
    internal static class Banco
    {
        private static string strConn;
        public static MySqlCommand Abrir()
        {
            strConn = @"server=127.0.0.1;database=pousada;port=3306;user id=root; password=";
            MySqlCommand cmd = new MySqlCommand();
            try // TENTAR ABRIR // Fluxos alternativos (Especificação de Caso de Uso)
            {
                MySqlConnection cn = new MySqlConnection(strConn);
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                cmd.Connection = cn;
            }
            catch (Exception)
            {

                throw;
            }

            return cmd;
        }
        public static void Fechar(MySqlCommand cmd)
        {
            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }
    }
}
