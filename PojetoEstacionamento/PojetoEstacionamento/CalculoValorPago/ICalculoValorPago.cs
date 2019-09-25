using ProjetoEstacionamento.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstacionamento.CalculoValorPago
{
    public interface ICalculoValorPago<TVeiculo> where TVeiculo : Veiculo
    {
        double ValorBaseHora { get; set; }
        double ValorPorHora { get; set; }
        void CalculaValorPago(TVeiculo veiculo);
    }
}
