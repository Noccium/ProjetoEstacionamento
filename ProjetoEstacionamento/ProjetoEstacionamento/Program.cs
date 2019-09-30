using ProjetoEstacionamento.Veiculos;
using ProjetoEstacionamento.CalculoValorPago;
using ProjetoEstacionamento.BancoDeDados;
using ProjetoEstacionamento.MaquinaCalculoValorPago;
using System;

namespace ProjetoEstacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesBancoDeDados.CriarTabela(typeof(Carro));
            OperacoesBancoDeDados.CriarTabela(typeof(Camionete));
            OperacoesBancoDeDados.CriarTabela(typeof(Motocicleta));

            CalculoValorPagoCarro calculoCarro = new CalculoValorPagoCarro();
            CalculoValorPagoCamionete calculoCamionete = new CalculoValorPagoCamionete();
            CalculoValorPagoMotocicleta calculoMotocicleta = new CalculoValorPagoMotocicleta();

            Carro carro = new Carro("ABC1234");
            Carro carro2 = new Carro("KKK1234");
            Camionete camionete = new Camionete("DEF5678");
            Motocicleta motocicleta = new Motocicleta("GHI9123");
            Motocicleta motocicleta2 = new Motocicleta("ACD9123");

            calculoCarro.CalculaValorPago(carro);
            calculoCarro.CalculaValorPago(carro2);
            calculoCamionete.CalculaValorPago(camionete);
            calculoMotocicleta.CalculaValorPago(motocicleta);
            calculoMotocicleta.CalculaValorPago(motocicleta2);

            OperacoesBancoDeDados.InserirVeiculo(typeof(Motocicleta), motocicleta);
            OperacoesBancoDeDados.InserirVeiculo(typeof(Motocicleta), motocicleta);
            OperacoesBancoDeDados.InserirVeiculo(typeof(Motocicleta), motocicleta2);
            OperacoesBancoDeDados.InserirVeiculo(typeof(Carro), carro2);
            OperacoesBancoDeDados.InserirVeiculo(typeof(Carro), carro);
            OperacoesBancoDeDados.InserirVeiculo(typeof(Camionete), camionete);

            //Console.WriteLine(OperacoesBancoDeDados.ObterTabelaPorTipoVeiculo(typeof(Motocicleta)));
            //Console.WriteLine(OperacoesBancoDeDados.ObterTabelaPorTipoVeiculo(typeof(Camionete)));
            //Console.WriteLine(OperacoesBancoDeDados.ObterTabelaPorTipoVeiculo(typeof(Carro)));

            Console.WriteLine(OperacoesBancoDeDados.ObterDatasDeUso(typeof(Motocicleta)));
            Console.WriteLine(OperacoesBancoDeDados.ObterDatasDeUso(typeof(Camionete)));
            Console.WriteLine(OperacoesBancoDeDados.ObterDatasDeUso(typeof(Carro)));
        }
    }
}
