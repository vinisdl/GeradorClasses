using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : estatisticas_fornecedores.
	/// </summary>
	public class EstatisticaFornecedo
	{
		public EstatisticaFornecedo()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int PedidoPrazoAlterado { get; set;} 
		public int PedidoReagendadoReagendado { get; set;} 
		public int PedidoReagendado { get; set;} 
		public int IdEstatisticaFornecedor { get; set;} 
		public bool DadoSemanaFinalizado { get; set;} 
		public int PedidoRecebido { get; set;} 
		public int PedidoEntreguePrazo { get; set;} 
		public int PedidoNaoCotato { get; set;} 
		public int PedidoPrevisto { get; set;} 
		public int PedidoDevolucaoAberto { get; set;} 
		public int QuantidadeAtualizacao { get; set;} 
		public int PedidoCotado { get; set;} 
		public DateTime DataUltimaAtualizacao { get; set;} 
		public int PedidoEntregueForaPrazo { get; set;} 
		public int CodFornecedor { get; set;} 
		public int Semana { get; set;} 
		public int PedidoAutorizado { get; set;} 
	}
}