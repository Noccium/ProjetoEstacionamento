using ProjetoEstacionamento.MaquinaCalculoValorPago;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstacionamento.Veiculos
{
    class Camionete : Veiculo
    {
        public Camionete(string placa) : base(placa)
        {
        }
        public override EnumTipoCalculoValorPago TipoCalculoValorPago()
        {
            return EnumTipoCalculoValorPago.Camionete;
        }
        public override string ToString()
        {
            return "Camionete";
        }
    }
}
