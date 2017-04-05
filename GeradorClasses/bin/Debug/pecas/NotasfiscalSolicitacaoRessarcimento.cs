using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : notasfiscais_solicitacao_ressarcimento.
	/// </summary>
	public class NotasfiscalSolicitacaoRessarcimento
	{
		public NotasfiscalSolicitacaoRessarcimento()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int ComprovantePagamentoCodArquivo { get; set;} 
		public bool Cancelada { get; set;} 
		public DateTime DataConfirmacaoRessarcimento { get; set;} 
		public int CodNotafiscal { get; set;} 
		public string Observacao { get; set;} 
		public DateTime DataPagamento { get; set;} 
		public string JustificativaCancelamento { get; set;} 
		public int CodSolicitacaoRessarcimento { get; set;} 
		public DateTime DataRessarcimento { get; set;} 
		public int TipoNota { get; set;} 
		public int ComprovanteRessarcimentoCodArquivo { get; set;} 
		public DateTime DataCobrancaInicial { get; set;} 
		public int IdNotafiscalSolicitacaoRessarcimento { get; set;} 
	}
}