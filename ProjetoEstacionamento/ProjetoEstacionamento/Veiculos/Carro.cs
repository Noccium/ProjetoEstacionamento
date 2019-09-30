using System;
using System.Collections.Generic;
using System.Text;
using ProjetoEstacionamento.MaquinaCalculoValorPago;

namespace ProjetoEstacionamento.Veiculos
{
    public class Carro : Veiculo
    {
        public Carro(string placa) : base(placa)
        {   
        }
        public override EnumTipoCalculoValorPago TipoCalculoValorPago()
        {
            return EnumTipoCalculoValorPago.Carro;
        }
        public override string ToString()
        {
            return "Carro";
        }
    }
}
