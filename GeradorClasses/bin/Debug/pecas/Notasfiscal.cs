using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : notasfiscais.
	/// </summary>
	public class Notasfiscal
	{
		public Notasfiscal()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public bool EnviadaNotafiscalIntegracao { get; set;} 
		public DateTime DataEnvioNotafiscalManual { get; set;} 
		public int CancelamentoCodUsuario { get; set;} 
		public int DanfeGeradaCodArquivo { get; set;} 
		public int CodNotafiscalModelo { get; set;} 
		public int TipoNota { get; set;} 
		public DateTime DataEmissao { get; set;} 
		public bool Eletronica { get; set;} 
		public DateTime DataConfirmacaoPgt { get; set;} 
		public bool Cancelada { get; set;} 
		public int DanfeCodArquivo { get; set;} 
		public int PdfCodArquivo { get; set;} 
		public DateTime DataEnvioCancelamentoNotafiscalIntegracao { get; set;} 
		public decimal ValorTotal { get; set;} 
		public string MotivoCancelamento { get; set;} 
		public DateTime CancelamentoData { get; set;} 
		public int NfeCodArquivo { get; set;} 
		public int CodNotafiscalSerie { get; set;} 
		public DateTime DataSaida { get; set;} 
		public string Numero { get; set;} 
		public string NomeRecebimento { get; set;} 
		public DateTime DataEntrega { get; set;} 
		public DateTime DataEnvioNotafiscalIntegracao { get; set;} 
		public int CodPedidoFornecedor { get; set;} 
		public DateTime DataInclusao { get; set;} 
		public string Chave { get; set;} 
		public int IdNotafiscal { get; set;} 
		public DateTime DataUltimaVerificacaoPgt { get; set;} 
	}
}