using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : itens_alteracoes_prazos.
	/// </summary>
	public class ItemAlteracaoPrazo
	{
		public ItemAlteracaoPrazo()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public DateTime DataNovaEntrega { get; set;} 
		public int CodMotivoAlteracaoPrazo { get; set;} 
		public int IdItemAlteracaoPrazo { get; set;} 
		public int CodItempedidoFornecedor { get; set;} 
		public int CodAlteracaoPrazo { get; set;} 
	}
}