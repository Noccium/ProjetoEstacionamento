using ProjetoEstacionamento.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoEstacionamento.BancoDeDados
{
    public static class OperacoesBancoDeDados
    {
        private static Dictionary<Type, Dictionary<string, Veiculo>> TabelaVeiculos 
                                        = new Dictionary<Type, Dictionary<string, Veiculo>>();
        public static void CriarTabela(Type type)
        {
            TabelaVeiculos.Add(type, new Dictionary<string, Veiculo>());
        }
        public static void InserirVeiculo(Type type, Veiculo veiculo)
        {
            if (!TabelaVeiculos[type].ContainsKey(veiculo.Placa))
            {
                TabelaVeiculos[type].Add(veiculo.Placa, veiculo);
            }
            else
            {
                TabelaVeiculos[type][veiculo.Placa].ListaDataUso.Add((veiculo.DataEntrada, veiculo.DataSaida));
            }
                 
        }
        public static string ObterTabelaPorTipoVeiculo(Type type)
        {
            StringBuilder tabelaVeiculo = new StringBuilder();
            tabelaVeiculo.AppendLine(string.Format("- Lista de {0} -\n", type));

            foreach (var veiculo in TabelaVeiculos[type])
            {
                tabelaVeiculo.AppendLine(String.Format(
                    "Tipo : {0}\nPlaca: {1}\nValorPago: {2}\nDataEntrada: {3}\nDataSaida: {4}\nQuantidadeUtilizado: {5}\n",
                    veiculo.Value, veiculo.Key, veiculo.Value.ValorPago, veiculo.Value.DataEntrada, veiculo.Value.DataSaida, veiculo.Value.QuantidadeUtilizado)
                );
            }    
            return tabelaVeiculo.ToString();
        }

        public static string ObterDatasDeUso(Type type)
        {
            StringBuilder tabelaVeiculo = new StringBuilder();
            tabelaVeiculo.AppendLine(String.Format("- Datas de Uso {0}s -\n", TabelaVeiculos[type].First().Value));
            
            foreach (var veiculo in TabelaVeiculos[type].OrderBy(x => x.Key))
            {
                tabelaVeiculo.AppendLine(String.Format("Placa: {0}", veiculo.Key));
                foreach (var datauso in veiculo.Value.ListaDataUso) {
                    tabelaVeiculo.AppendLine(String.Format("{0}",
                        veiculo.Value.ListaDataUso[0])
                    );
                }
            }
            return tabelaVeiculo.ToString();
        }
    }
}
