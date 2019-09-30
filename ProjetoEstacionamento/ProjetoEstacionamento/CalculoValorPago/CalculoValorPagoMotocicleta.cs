using ProjetoEstacionamento.MaquinaCalculoValorPago;
using ProjetoEstacionamento.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstacionamento.CalculoValorPago
{
    [TipoCalculoValorPago(EnumTipoCalculoValorPago.Motocicleta)]
    public class CalculoValorPagoMotocicleta : CalculoValorPagoAvulso
    {
        public static double ValorBaseHora = 1.5;
        public static double ValorPorHora = 1;
        public CalculoValorPagoMotocicleta()
        {
        }
        public double CalculaValorPago(Motocicleta veiculo)
        {
            Calcula(veiculo, ValorBaseHora, ValorPorHora);
            return veiculo.ValorPago;
        }
    }
}
