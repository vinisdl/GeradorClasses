using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : logs_solicitacao_pagamento.
	/// </summary>
	public class LogSolicitacaoPagamento
	{
		public LogSolicitacaoPagamento()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int Tipo { get; set;} 
		public string Texto { get; set;} 
		public DateTime Data { get; set;} 
		public int TipoContato { get; set;} 
		public int IdLogSolicitacaoPagamento { get; set;} 
		public int CodSolicitacaoPagamento { get; set;} 
		public int CodUsuario { get; set;} 
	}
}