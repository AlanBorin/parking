using System;
using System.Collections.Generic;

namespace DesafioFundamentos.Models
{
	public class Estacionamento
	{
		private decimal precoInicial = 0;
		private decimal precoPorHora = 0;
		private List<string> veiculos = new List<string>();

		// Construtor da classe
		public Estacionamento(decimal precoInicial, decimal precoPorHora)
		{
			this.precoInicial = precoInicial;
			this.precoPorHora = precoPorHora;
		}

		// Método para adicionar um veículo ao estacionamento
		public void AdicionarVeiculo(string placa)
		{
			veiculos.Add(placa);
			Console.WriteLine($"Veículo com a placa {placa} adicionado ao estacionamento.");
		}

		// Método para remover um veículo do estacionamento
		public void RemoverVeiculo(string placa)
		{
			if (veiculos.Contains(placa))
			{
				veiculos.Remove(placa);
				Console.WriteLine($"Veículo com a placa {placa} removido do estacionamento.");
			}
			else
			{
				Console.WriteLine($"Veículo com a placa {placa} não encontrado no estacionamento.");
			}
		}

		// Método para listar os veículos estacionados
		public void ListarVeiculos()
		{
			if (veiculos.Count == 0)
			{
				Console.WriteLine("Nenhum veículo estacionado no momento.");
			}
			else
			{
				Console.WriteLine("Veículos estacionados:");
				foreach (var veiculo in veiculos)
				{
					Console.WriteLine(veiculo);
				}
			}
		}
	}
}
