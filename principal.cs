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

		// M�todo para adicionar um ve�culo ao estacionamento
		public void AdicionarVeiculo(string placa)
		{
			veiculos.Add(placa);
			Console.WriteLine($"Ve�culo com a placa {placa} adicionado ao estacionamento.");
		}

		// M�todo para remover um ve�culo do estacionamento
		public void RemoverVeiculo(string placa)
		{
			if (veiculos.Contains(placa))
			{
				veiculos.Remove(placa);
				Console.WriteLine($"Ve�culo com a placa {placa} removido do estacionamento.");
			}
			else
			{
				Console.WriteLine($"Ve�culo com a placa {placa} n�o encontrado no estacionamento.");
			}
		}

		// M�todo para listar os ve�culos estacionados
		public void ListarVeiculos()
		{
			if (veiculos.Count == 0)
			{
				Console.WriteLine("Nenhum ve�culo estacionado no momento.");
			}
			else
			{
				Console.WriteLine("Ve�culos estacionados:");
				foreach (var veiculo in veiculos)
				{
					Console.WriteLine(veiculo);
				}
			}
		}
	}
}
