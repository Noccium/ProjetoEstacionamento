using ProjetoEstacionamento.MaquinaCalculoValorPago;
using System;
using System.Collections.Generic;

namespace ProjetoEstacionamento.Veiculos
{
    public abstract class Veiculo
    {
        public string Placa { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public List<(DateTime, DateTime)> ListaDataUso { get; set; }
        public double ValorPago { get; set; }
        public List<int> ListaValorPago { get; set; }
        public int QuantidadeUtilizado { get; set; }
        public Veiculo(string placa)
        {
            Placa = placa;
            ListaDataUso = new List<(DateTime, DateTime)>();
            DataEntrada = DateTime.Now;
        }
        public abstract EnumTipoCalculoValorPago TipoCalculoValorPago();
    }
}
