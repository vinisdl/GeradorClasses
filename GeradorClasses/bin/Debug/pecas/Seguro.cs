using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : seguros.
	/// </summary>
	public class Seguro
	{
		public Seguro()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int IdSeguro { get; set;} 
		public decimal Valor { get; set;} 
		public string Apolice { get; set;} 
		public string NomeCorretor { get; set;} 
		public decimal Franquia { get; set;} 
	}
}