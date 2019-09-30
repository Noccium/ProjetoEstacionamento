using ProjetoEstacionamento.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstacionamento.CalculoValorPago
{
    public abstract class CalculoValorPagoAvulso
    {
        public void Calcula(Veiculo veiculo, double valorBaseHora, double valorPorHora)
        {
            //veiculo.DataSaida = DateTime.Now;
            veiculo.DataSaida = DateTime.Now.AddHours(2);
            
            if (veiculo.QuantidadeUtilizado == 3)
            {
                veiculo.QuantidadeUtilizado = 0;
                veiculo.ValorPago = 0;
            } else if ( (veiculo.DataSaida - veiculo.DataEntrada).TotalMinutes < 15 )
            {
                veiculo.ValorPago = valorBaseHora;
            } else
            {
                veiculo.QuantidadeUtilizado++;
                veiculo.ValorPago = (valorBaseHora +
                valorPorHora * Convert.ToInt32((veiculo.DataSaida - veiculo.DataEntrada).TotalHours - 1));
            }
            veiculo.ListaDataUso.Add((veiculo.DataEntrada, veiculo.DataSaida));
        }
    }
}
