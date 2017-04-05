using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : estatisticas_fornecedores_pedidos_fornecedores.
	/// </summary>
	public class EstatisticaFornecedoPedidoFornecedo
	{
		public EstatisticaFornecedoPedidoFornecedo()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodPedidoFornecedor { get; set;} 
		public int CodEstatisticaFornecedor { get; set;} 
		public int IdEstatisticaFornecedorPedidoFornecedor { get; set;} 
		public int TipoEstatistica { get; set;} 
	}
}