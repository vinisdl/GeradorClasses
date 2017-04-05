using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : feriados.
	/// </summary>
	public class Feriado
	{
		public Feriado()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int Dia { get; set;} 
		public int IdFeriado { get; set;} 
		public string Nome { get; set;} 
		public int Ano { get; set;} 
		public int Me { get; set;} 
	}
}