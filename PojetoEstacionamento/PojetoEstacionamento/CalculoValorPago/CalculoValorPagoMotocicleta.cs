using PojetoEstacionamento.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PojetoEstacionamento.CalculoValorPago
{
    public class CalculoValorPagoMotocicleta : ICalculoValorPago<Motocicleta>
    {
        public void CalculaValorPago(Motocicleta veiculo)
        {
            veiculo.ValorPago = 1.5 +
                Convert.ToInt32(
                    Math.Sqrt( Math.Pow( (veiculo.DataEntrada - veiculo.DataSaida).TotalHours - 1, 2) ) );
        }
    }
}
