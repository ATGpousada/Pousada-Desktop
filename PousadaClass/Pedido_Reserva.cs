using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PousadaClass
{
    public class Pedido_Reserva
    {
        // Atributos
        private int id;
        private DateTime data_reserva;
        private DateTime data_entrada;
        private DateTime data_saida;
        private string nome;
        private string cpf;
        private string email;
        private int acompanhantes;
        private Quarto quartos;
        private Status status;

        // Propriedades
        public int Id { get => id; set => id = value; }
        public DateTime Data_reserva { get => data_reserva; set => data_reserva = value; }
        public DateTime Data_entrada { get => data_entrada; set => data_entrada = value; }
        public DateTime Data_saida { get => data_saida; set => data_saida = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public int Acompanhantes { get => acompanhantes; set => acompanhantes = value; }
        public Quarto Quartos { get => quartos; set => quartos = value; }
        public Status Status { get => status; set => status = value; }

        public Pedido_Reserva() { }
        public Pedido_Reserva(int id, DateTime data_reserva, DateTime data_entrada, DateTime data_saida, string nome, string cpf, string email, int acompanhantes, Quarto quartos, Status status)
        {
            Id = id;
            Data_reserva = data_reserva;
            Data_entrada = data_entrada;
            Data_saida = data_saida;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Acompanhantes = acompanhantes;
            Quartos = quartos;
            Status = status;
        }

        public static Pedido_Reserva ObterPorId(int id)
        {
            var cmd = Banco.Abrir();
            Pedido_Reserva pedido = null;
            cmd.CommandText = "select * from pedidos_reservas where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedido = new Pedido_Reserva(
                    dr.GetInt32(0),
                    dr.GetDateTime(1),
                    dr.GetDateTime(2),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetInt32(7),
                    Quarto.ObterPorId(dr.GetInt32(8)),
                    Status.ObterPorId(dr.GetInt32(9))
                    );
            }
            Banco.Fechar(cmd);
            return pedido;
        }


    }
}
