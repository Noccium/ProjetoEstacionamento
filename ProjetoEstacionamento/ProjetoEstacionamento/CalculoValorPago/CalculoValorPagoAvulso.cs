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
            veiculo.DataSaida = DateTime.Now.AddHours(1);
            int teste15Minutos = ( (veiculo.DataSaida - veiculo.DataEntrada).TotalMinutes >= 15) ? 1 : 0;
            //Se teste15Minutos >= 15 quantidadeUtilizada ++
                //Se quantidadeUtilizada maior que 3 quantidadeUtilizada = 0 e ValorPago = 0
            veiculo.ValorPago = (valorBaseHora +
                valorPorHora * Convert.ToInt32((veiculo.DataSaida - veiculo.DataEntrada).TotalHours - 1)) *
                teste15Minutos;
        }
    }
}
