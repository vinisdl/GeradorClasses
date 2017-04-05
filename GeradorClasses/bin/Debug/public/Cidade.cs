using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : cidades.
	/// </summary>
	public class Cidade
	{
		public Cidade()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string Nome { get; set;} 
		public Int64 CodIbge { get; set;} 
		public int IdCidade { get; set;} 
		public int CodEstado { get; set;} 
	}
}