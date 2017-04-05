using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : historico_estatisticas_fornecedores.
	/// </summary>
	public class HistoricoEstatisticaFornecedo
	{
		public HistoricoEstatisticaFornecedo()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int PedidoReagendadoReagendado { get; set;} 
		public int PedidoPrevisto { get; set;} 
		public int PedidoNaoCotado { get; set;} 
		public int PedidoReagendado { get; set;} 
		public int PedidoRecebido { get; set;} 
		public int PedidoEntreguePrazo { get; set;} 
		public int PedidoDevolucaoAberto { get; set;} 
		public DateTime DataReferencia { get; set;} 
		public int PedidoCotado { get; set;} 
		public int PedidoEntregueForaPrazo { get; set;} 
		public int CodFornecedor { get; set;} 
		public int IdHistoricoEstatisticaFornecedor { get; set;} 
		public int PedidoPrazoAlterado { get; set;} 
		public int PedidoAutorizado { get; set;} 
	}
}