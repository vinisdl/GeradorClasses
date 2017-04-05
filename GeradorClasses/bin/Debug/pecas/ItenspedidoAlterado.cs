using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : itenspedido_alterado.
	/// </summary>
	public class ItenspedidoAlterado
	{
		public ItenspedidoAlterado()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int QuantidadeOriginal { get; set;} 
		public int CodItempedidoFornecedor { get; set;} 
		public decimal ValorBrutoUnitarioAtual { get; set;} 
		public decimal ValorLiquidoUnitarioOriginal { get; set;} 
		public decimal ValorLiquidoUnitarioAtual { get; set;} 
		public int IdItempedidoAlterado { get; set;} 
		public int CodPedidoAlterado { get; set;} 
		public int QuantidadeAtual { get; set;} 
		public decimal ValorBrutoUnitarioOriginal { get; set;} 
		public DateTime DataCriacao { get; set;} 
	}
}