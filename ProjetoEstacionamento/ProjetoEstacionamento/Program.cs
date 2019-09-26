using ProjetoEstacionamento.Veiculos;
using ProjetoEstacionamento.CalculoValorPago;
using ProjetoEstacionamento.MaquinaCalculoValorPago;
using System;

namespace ProjetoEstacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoValorPagoCarro calculoCarro = new CalculoValorPagoCarro();
            CalculoValorPagoCamionete calculoCamionete = new CalculoValorPagoCamionete();
            CalculoValorPagoMotocicleta calculoMotocicleta = new CalculoValorPagoMotocicleta();

            Carro carro = new Carro("ABC1234");
            Camionete camionete = new Camionete("DEF5678");
            Motocicleta motocicleta = new Motocicleta("GHI9123");
           
            calculoCarro.CalculaValorPago(carro);
            calculoCamionete.CalculaValorPago(camionete);
            calculoMotocicleta.CalculaValorPago(motocicleta);

            Console.WriteLine(carro.ValorPago);
            Console.WriteLine(camionete.ValorPago);
            Console.WriteLine(motocicleta.ValorPago);
        }
    }
}
