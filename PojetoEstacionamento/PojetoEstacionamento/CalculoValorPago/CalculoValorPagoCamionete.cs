using PojetoEstacionamento.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PojetoEstacionamento.CalculoValorPago
{
    class CalculoValorPagoCamionete : ICalculoValorPago<Camionete>
    {
        public void CalculaValorPago(Camionete veiculo)
        {
            veiculo.ValorPago = 5 +
                3 * Convert.ToInt32(
                    Math.Sqrt( Math.Pow( (veiculo.DataEntrada - veiculo.DataSaida).TotalHours - 1, 2) ) );
        }
    }
}
