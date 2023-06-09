﻿using System;
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
        private int id;
        private double preco_total;
        private int parcelas;
        private DateTime data_entrada;
        private DateTime data_saida;
        private Pedido_Reserva pedido;
        private Funcionario funcionario;
        private Status status;

        public int Id { get => id; set => id = value; }
        public double Preco_total { get => preco_total; set => preco_total = value; }
        public int Parcelas { get => parcelas; set => parcelas = value; }
        public DateTime Data_entrada { get => data_entrada; set => data_entrada = value; }
        public DateTime Data_saida { get => data_saida; set => data_saida = value; }
        public Pedido_Reserva Pedido { get => pedido; set => pedido = value; }
        public Funcionario Funcionario { get => funcionario; set => funcionario = value; }
        public Status Status { get => status; set => status = value; }

        public Reserva() { }
        public Reserva(int id, double preco_total, int parcelas, DateTime data_entrada, DateTime data_saida, Pedido_Reserva pedido, Funcionario funcionario, Status status)
        {
            Id = id;
            Preco_total = preco_total;
            Parcelas = parcelas;
            Data_entrada = data_entrada;
            Data_saida = data_saida;
            Pedido = pedido;
            Funcionario = funcionario;
            Status = status;
        }

        /// <summary>
        /// Gerando uma reserva Pendente para um determinado pedido de reserva
        /// </summary>
        /// <param name="id_pedido"></param>
        /// <param name="id_funcionario"></param>
        /// <param name="id"></param>
        /// <param name="entrada"></param>
        /// <param name="saida"></param>
        public void GerarReserva(int id_pedido, int id_funcionario, int id, string entrada, string saida)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert reservas (preco_total, parcelas_total, data_entrada, data_saida, pedidos_reservas_id, funcionarios_id, status_id) " +
                "values (@preco, @parcelas, @entrada, @saida, " + id_pedido +", " + id_funcionario + ", 4)";
            cmd.Parameters.Add("@preco", MySqlDbType.Int32).Value = Preco_total;
            cmd.Parameters.Add("@parcelas", MySqlDbType.Double).Value = Parcelas;
            cmd.Parameters.Add("@entrada", MySqlDbType.DateTime).Value = DateTime.Parse(entrada);
            cmd.Parameters.Add("@saida", MySqlDbType.DateTime).Value = DateTime.Parse(saida);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update pedidos_reservas set status_ID = 4 where id = " + id;
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Cancelando um pedido de reserva
        /// </summary>
        /// <param name="id_pedido"></param>
        /// <param name="id_funcionario"></param>
        /// <param name="id"></param>
        /// <param name="entrada"></param>
        /// <param name="saida"></param>
        public void CancelarReserva(int id_pedido, int id_funcionario, int id, string entrada, string saida)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert reservas (preco_total, parcelas_total, data_entrada, data_saida, pedidos_reservas_id, funcionarios_id, status_id) " +
                "values (@preco, @parcelas, @entrada, @saida, " + id_pedido + ", " + id_funcionario + ", 6)";
            cmd.Parameters.Add("@preco", MySqlDbType.Int32).Value = Preco_total;
            cmd.Parameters.Add("@parcelas", MySqlDbType.Double).Value = Parcelas;
            cmd.Parameters.Add("@entrada", MySqlDbType.DateTime).Value = DateTime.Parse(entrada);
            cmd.Parameters.Add("@saida", MySqlDbType.DateTime).Value = DateTime.Parse(saida);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update pedidos_reservas set status_ID = 6 where id = " + id;
            cmd.ExecuteNonQuery();
        }
    }
}
