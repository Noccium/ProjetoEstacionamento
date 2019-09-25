using ProjetoEstacionamento.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstacionamento.CalculoValorPago
{
    class CalculoValorPagoCarro : ICalculoValorPago<Carro>
    {
        public double ValorBaseHora { get; set; }
        public double ValorPorHora { get; set; }
        public CalculoValorPagoCarro()
        {
            ValorBaseHora = 3;
            ValorPorHora = 1.5;
        }
        public void CalculaValorPago(Carro veiculo)
        {
            veiculo.ValorPago = ValorBaseHora +
                ValorPorHora * Convert.ToInt32(
                    Math.Sqrt(Math.Pow((veiculo.DataEntrada - veiculo.DataSaida).TotalHours - 1, 2)));
        }
    }
}
