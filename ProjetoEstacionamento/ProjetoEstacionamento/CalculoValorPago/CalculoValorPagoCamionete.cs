using ProjetoEstacionamento.MaquinaCalculoValorPago;
using ProjetoEstacionamento.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstacionamento.CalculoValorPago
{
    class CalculoValorPagoCamionete : CalculoValorPagoAvulso
    {
        private static double ValorBaseHora = 5;
        private static double ValorPorHora = 3;
        public CalculoValorPagoCamionete()
        {
        }
        public double CalculaValorPago(Camionete veiculo)
        {
            Calcula(veiculo, ValorBaseHora, ValorPorHora);
            return veiculo.ValorPago;
        }

    }
}
