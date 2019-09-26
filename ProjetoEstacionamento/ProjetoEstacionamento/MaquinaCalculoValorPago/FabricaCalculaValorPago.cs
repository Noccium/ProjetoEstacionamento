using ProjetoEstacionamento.Uteis;
using ProjetoEstacionamento.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoEstacionamento.MaquinaCalculoValorPago
{
    class FabricaCalculaValorPago
    {
        public static void CalculaValorPago<TTipoCalculoValorPago>(Veiculo veiculo)
            where TTipoCalculoValorPago : Attribute, ITipoCalculoValorPago
        {
            //encontra todos os tipos de veiculos
            var tiposCalculo = veiculo.Types<TTipoCalculoValorPago>();
            var tipo = tiposCalculo.First(x => x.Attribute<TTipoCalculoValorPago>() != null &&
                x.Attribute<TTipoCalculoValorPago>().EnumTipoCalculoValorPago == veiculo.TipoCalculoValorPago());

            var calculo = Activator.CreateInstance(tipo, new Object[] { });
            tipo.GetMethod("CalculaValorPago").Invoke(calculo, new object[] { veiculo });
        }
    }
}
