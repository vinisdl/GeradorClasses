using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : locacoeslogistica.
	/// </summary>
	public class Locacoeslogistica
	{
		public Locacoeslogistica()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public DateTime DataLocacao { get; set;} 
		public int CodUsuario { get; set;} 
		public int IdLocacaologistica { get; set;} 
		public int CodOficina { get; set;} 
	}
}