using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : descontos.
	/// </summary>
	public class Desconto
	{
		public Desconto()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodCliente { get; set;} 
		public int IdDesconto { get; set;} 
		public float? ValorDesconto { get; set;} 
		public bool Interestadual { get; set;} 
		public int CodFornecedorMarca { get; set;} 
	}
}