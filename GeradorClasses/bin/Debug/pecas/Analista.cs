using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : analistas.
	/// </summary>
	public class Analista
	{
		public Analista()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodCliente { get; set;} 
		public int IdAnalista { get; set;} 
		public string Nome { get; set;} 
		public bool Ativo { get; set;} 
	}
}