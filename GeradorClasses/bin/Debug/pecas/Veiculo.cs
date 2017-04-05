using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : veiculos.
	/// </summary>
	public class Veiculo
	{
		public Veiculo()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodCombustivel { get; set;} 
		public string Observacao { get; set;} 
		public int AnoModelo { get; set;} 
		public string Tipo { get; set;} 
		public string Placa { get; set;} 
		public string Modelo { get; set;} 
		public int Km { get; set;} 
		public int Porta { get; set;} 
		public int CodProprietario { get; set;} 
		public string Combustivel { get; set;} 
		public string PinturaCor { get; set;} 
		public int CodSeguro { get; set;} 
		public string StringImportacao { get; set;} 
		public string PinturaTipo { get; set;} 
		public string Motor { get; set;} 
		public int AnoFabricacao { get; set;} 
		public int IdVeiculo { get; set;} 
		public string Chassi { get; set;} 
		public int CodMarca { get; set;} 
		public int CodSinistro { get; set;} 
	}
}