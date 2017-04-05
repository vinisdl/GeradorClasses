using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : tokens.
	/// </summary>
	public class Tokem
	{
		public Tokem()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodPedido { get; set;} 
		public int CodSolicitacao { get; set;} 
		public string Token { get; set;} 
		public int CodNotaFiscal { get; set;} 
		public int IdToken { get; set;} 
		public DateTime DataCriacao { get; set;} 
	}
}