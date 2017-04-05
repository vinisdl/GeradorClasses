using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : logs_solicitacao_ressarcimento.
	/// </summary>
	public class LogSolicitacaoRessarcimento
	{
		public LogSolicitacaoRessarcimento()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int Tipo { get; set;} 
		public string Texto { get; set;} 
		public int CodSolicitacaoRessarcimento { get; set;} 
		public int IdLogSolicitacaoRessarcimento { get; set;} 
		public DateTime Data { get; set;} 
		public int TipoContato { get; set;} 
		public int CodUsuario { get; set;} 
	}
}