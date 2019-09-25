using ProjetoEstacionamento.CalculoValorPago;
using ProjetoEstacionamento.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstacionamento.CalculoValorPago
{
    public class CalculoValorPagoMotocicleta : ICalculoValorPago<Motocicleta>
    {
        public double ValorBaseHora { get; set; }
        public double ValorPorHora { get; set; }
        public CalculoValorPagoMotocicleta()
        {
            ValorBaseHora = 1.5;
            ValorPorHora = 1;
        }
        public void CalculaValorPago(Motocicleta veiculo)
        {
            veiculo.ValorPago = ValorBaseHora +
                ValorPorHora * Convert.ToInt32(
                    Math.Sqrt(Math.Pow((veiculo.DataEntrada - veiculo.DataSaida).TotalHours - 1, 2)));
        }
    }
}
