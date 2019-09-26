using ProjetoEstacionamento.MaquinaCalculoValorPago;
using ProjetoEstacionamento.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstacionamento.CalculoValorPago
{
    [TipoCalculoValorPago(EnumTipoCalculoValorPago.Camionete)]
    class CalculoValorPagoCamionete : CalculoValorPagoAvulso, ICalculoValorPago<Camionete>
    {
        public double ValorBaseHora { get; set; }
        public double ValorPorHora { get; set; }
        public CalculoValorPagoCamionete()
        {
            ValorBaseHora = 5;
            ValorPorHora = 3;
        }
        public void CalculaValorPago(Camionete veiculo)
        {
            Calcula(veiculo, ValorBaseHora, ValorPorHora);
        }

    }
}
