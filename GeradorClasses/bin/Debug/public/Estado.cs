using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : estados.
	/// </summary>
	public class Estado
	{
		public Estado()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string Nome { get; set;} 
		public int IdEstado { get; set;} 
		public string Sigla { get; set;} 
	}
}