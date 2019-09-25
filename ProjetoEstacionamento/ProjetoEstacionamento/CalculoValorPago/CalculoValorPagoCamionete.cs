using ProjetoEstacionamento.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstacionamento.CalculoValorPago
{
    class CalculoValorPagoCamionete : ICalculoValorPago<Camionete>
    {
        public double ValorBaseHora { get; set; }
        public double ValorPorHora { get; set; }
        public CalculoValorPagoCamionete()
        {
            ValorBaseHora = 5;
            ValorPorHora = 3;
        }
        public void CalculaValorPago(Camionete veiculo)
        {
            veiculo.ValorPago = ValorBaseHora +
                ValorPorHora * Convert.ToInt32(
                    Math.Sqrt(Math.Pow((veiculo.DataEntrada - veiculo.DataSaida).TotalHours - 1, 2)));
        }
    }
}
