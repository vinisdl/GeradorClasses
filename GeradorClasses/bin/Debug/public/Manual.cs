using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : manuais.
	/// </summary>
	public class Manual
	{
		public Manual()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int IdManual { get; set;} 
		public string Descricao { get; set;} 
		public string Nome { get; set;} 
		public int CodUsuario { get; set;} 
		public int CodArquivo { get; set;} 
	}
}