﻿using ProjetoEstacionamento.MaquinaCalculoValorPago;
using System;

namespace ProjetoEstacionamento.Veiculos
{
    public abstract class Veiculo
    {
        public string Placa { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public double ValorPago { get; set; }
     
        public Veiculo(string placa)
        {
            Placa = placa;
            DataEntrada = DateTime.Now;
        }
        public abstract EnumTipoCalculoValorPago TipoCalculoValorPago();
    }
}
