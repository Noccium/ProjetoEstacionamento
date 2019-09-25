﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PojetoEstacionamento.MaquinaCalculoValorPago
{
    public class TipoCalculoValorPago : Attribute, ITipoCalculoValorPago
    {
        public EnumTipoCalculoValorPago EnumTipoCalculoValorPago { get; set; }
        public TipoCalculoValorPago(EnumTipoCalculoValorPago tipoCalculoValorPago)
        {
            EnumTipoCalculoValorPago = tipoCalculoValorPago;
        }
    }
}
