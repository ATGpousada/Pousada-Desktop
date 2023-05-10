using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PousadaClass
{
    public class TipoQuarto
    {
        // Atributos
        private int id;
        private string tipo;

        //Propriedades
        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public TipoQuarto(int id, string tipo)
        {
            Id = id;
            Tipo = tipo;
        }

        /// <summary>
        /// Obtendo o tipo do quarto pelo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static TipoQuarto ObterPorId(int id)
        {
            var cmd = Banco.Abrir();
            TipoQuarto tipoquarto = null;
            cmd.CommandText = "select * from tipos where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipoquarto = new TipoQuarto(
                    dr.GetInt32(0),
                    dr.GetString(1)
                    );
            }
            Banco.Fechar(cmd);
            return tipoquarto;
        }
    }
}
