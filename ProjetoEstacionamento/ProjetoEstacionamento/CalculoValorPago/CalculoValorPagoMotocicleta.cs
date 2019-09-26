using ProjetoEstacionamento.MaquinaCalculoValorPago;
using ProjetoEstacionamento.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstacionamento.CalculoValorPago
{
    [TipoCalculoValorPago(EnumTipoCalculoValorPago.Motocicleta)]
    public class CalculoValorPagoMotocicleta : CalculoValorPagoAvulso, ICalculoValorPago<Motocicleta>
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
            Calcula(veiculo, ValorBaseHora, ValorPorHora);
        }
    }
}
