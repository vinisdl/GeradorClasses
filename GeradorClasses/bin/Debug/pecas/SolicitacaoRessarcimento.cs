using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : solicitacoes_ressarcimento.
	/// </summary>
	public class SolicitacaoRessarcimento
	{
		public SolicitacaoRessarcimento()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodPedido { get; set;} 
		public int IdSolicitacaoRessarcimento { get; set;} 
		public int CodUsuarioCriacao { get; set;} 
		public DateTime DataLocacao { get; set;} 
		public DateTime DataCobrancaInicial { get; set;} 
		public DateTime DataAgendamentoEnvio { get; set;} 
		public int CodAuxiliarRessarcimento { get; set;} 
		public int CodPedidoFornecedor { get; set;} 
		public DateTime DataCriacao { get; set;} 
	}
}