using PojetoEstacionamento.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PojetoEstacionamento.CalculoValorPago
{
    public interface ICalculoValorPago<TVeiculo> where TVeiculo : Veiculo
    {
        void CalculaValorPago(TVeiculo veiculo);
    }
}
