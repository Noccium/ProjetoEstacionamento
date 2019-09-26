using ProjetoEstacionamento.MaquinaCalculoValorPago;
using ProjetoEstacionamento.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstacionamento.CalculoValorPago
{
    [TipoCalculoValorPago(EnumTipoCalculoValorPago.Carro)]
    class CalculoValorPagoCarro : CalculoValorPagoAvulso, ICalculoValorPago<Carro>
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
            Calcula(veiculo, ValorBaseHora, ValorPorHora);
        }
    }
}
