using ProjetoEstacionamento.MaquinaCalculoValorPago;
using ProjetoEstacionamento.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstacionamento.CalculoValorPago
{
    public class CalculoValorPagoCarro : CalculoValorPagoAvulso
    {
        private static double ValorBaseHora = 3;
        private static double ValorPorHora = 1.5;
        public CalculoValorPagoCarro()
        {
        }
        public double CalculaValorPago(Carro veiculo)
        {
            Calcula(veiculo, ValorBaseHora, ValorPorHora);
            return veiculo.ValorPago;
        }
    }
}
