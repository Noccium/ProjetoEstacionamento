using PojetoEstacionamento.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PojetoEstacionamento.CalculoValorPago
{
    class CalculoValorPagoCarro : ICalculoValorPago<Carro>
    {
        public void CalculaValorPago(Carro veiculo)
        {
            veiculo.ValorPago = 3 + 
                1.5 * Convert.ToInt32(
                    Math.Sqrt( Math.Pow( (veiculo.DataEntrada - veiculo.DataSaida).TotalHours - 1, 2) ) );
        }
    }
}
