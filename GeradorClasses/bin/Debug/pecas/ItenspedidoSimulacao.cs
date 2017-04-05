using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : itenspedido_simulacoes.
	/// </summary>
	public class ItenspedidoSimulacao
	{
		public ItenspedidoSimulacao()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int MotivoNaofornecimento { get; set;} 
		public int CodPedidoSimulacao { get; set;} 
		public int CodItempedido { get; set;} 
		public int CodItempedidoFornecedor { get; set;} 
		public int IdItempedidoSimulacao { get; set;} 
	}
}