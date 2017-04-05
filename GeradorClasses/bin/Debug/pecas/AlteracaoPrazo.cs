using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : alteracoes_prazos.
	/// </summary>
	public class AlteracaoPrazo
	{
		public AlteracaoPrazo()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodPedido { get; set;} 
		public int IdAlteracaoPrazo { get; set;} 
		public DateTime DataAlteracao { get; set;} 
		public int CodFornecedor { get; set;} 
	}
}