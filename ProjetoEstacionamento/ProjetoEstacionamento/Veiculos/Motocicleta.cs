using ProjetoEstacionamento.MaquinaCalculoValorPago;
using ProjetoEstacionamento.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstacionamento.Veiculos
{
    public class Motocicleta : Veiculo
    {
        public Motocicleta(string placa) : base(placa)
        {
        }
        public override EnumTipoCalculoValorPago TipoCalculoValorPago()
        {
            return EnumTipoCalculoValorPago.Motocicleta;
        }
        public override string ToString()
        {
            return "Motocicleta";
        }
    }
}
