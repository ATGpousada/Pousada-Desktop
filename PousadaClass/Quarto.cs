using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PousadaClass
{
    public class Quarto
    {
        // Atributos
        private int id;
        private string quarto;
        private string descricao;
        private double preco_diaria;
        private int qtde_pessoas;
        private bool destaque;
        private DateTime arquivar;
        private Status status;
        private TipoQuarto tipo;

        // Propriedades
        public int Id { get => id; set => id = value; }
        public string Quarto1 { get => quarto; set => quarto = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Preco_diaria { get => preco_diaria; set => preco_diaria = value; }
        public int Qtde_pessoas { get => qtde_pessoas; set => qtde_pessoas = value; }
        public bool Destaque { get => destaque; set => destaque = value; }
        public DateTime Arquivar { get => arquivar; set => arquivar = value; }
        public Status Status { get => status; set => status = value; }
        public TipoQuarto Tipo { get => tipo; set => tipo = value; }

        public Quarto() { }
        public Quarto(int id, string quarto, string descricao, double preco_diaria, int qtde_pessoas, bool destaque, DateTime arquivar, Status status, TipoQuarto tipo)
        {
            Id = id;
            Quarto1 = quarto;
            Descricao = descricao;
            Preco_diaria = preco_diaria;
            Qtde_pessoas = qtde_pessoas;
            Destaque = destaque;
            Arquivar = arquivar;
            Status = status;
            Tipo = tipo;
        }

        public Quarto(int id, string quarto, string descricao, double preco_diaria, int qtde_pessoas, bool destaque, Status status, TipoQuarto tipo)
        {
            Id = id;
            Quarto1 = quarto;
            Descricao = descricao;
            Preco_diaria = preco_diaria;
            Qtde_pessoas = qtde_pessoas;
            Destaque = destaque;
            Status = status;
            Tipo = tipo;
        }


        /// <summary>
        /// Buscando pelo Id todas as informações sobre um determinado quarto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Quarto ObterPorId(int id)
        {
            var cmd = Banco.Abrir();
            Quarto quarto = null;
            cmd.CommandText = "select id, quarto, descricao, preco_diaria, qtde_pessoas, destaque, status_id, tipos_id from quartos where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                quarto = new Quarto(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetInt32(4),
                    dr.GetBoolean(5),
                    Status.ObterPorId(dr.GetInt32(6)),
                    TipoQuarto.ObterPorId(dr.GetInt32(7))
                    );
            }
            Banco.Fechar(cmd);
            return quarto;
        }
    }
}
