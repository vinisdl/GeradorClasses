using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : notasfiscais_solicitacao_pagamento.
	/// </summary>
	public class NotasfiscalSolicitacaoPagamento
	{
		public NotasfiscalSolicitacaoPagamento()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public DateTime DataConfirmacaoPagamento { get; set;} 
		public int ComprovantePagamentoCodArquivo { get; set;} 
		public bool Cancelada { get; set;} 
		public int IdNotafiscalSolicitacaoPagamento { get; set;} 
		public bool ConfirmacaoPagamento { get; set;} 
		public string Observacao { get; set;} 
		public DateTime DataPagamento { get; set;} 
		public int CodNotafiscal { get; set;} 
		public DateTime DataEnvioDocumento { get; set;} 
		public string JustificativaCancelamento { get; set;} 
		public int ComprovanteEnvioCodArquivo { get; set;} 
		public DateTime DataCobrancaInicial { get; set;} 
		public int CodSolicitacaoPagamento { get; set;} 
	}
}