using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : solicitacoes_pagamento.
	/// </summary>
	public class SolicitacaoPagamento
	{
		public SolicitacaoPagamento()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodPedido { get; set;} 
		public int CodUsuarioCriacao { get; set;} 
		public DateTime DataLocacao { get; set;} 
		public int CodAuxiliarPagamento { get; set;} 
		public DateTime DataAgendamentoEnvio { get; set;} 
		public DateTime DataCobrancaInicial { get; set;} 
		public int IdSolicitacaoPagamento { get; set;} 
		public int CodPedidoFornecedor { get; set;} 
		public DateTime DataCriacao { get; set;} 
	}
}