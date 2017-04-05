using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : solicitacoes_depara.
	/// </summary>
	public class SolicitacaoDepara
	{
		public SolicitacaoDepara()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int StatuJustificativaDepara { get; set;} 
		public int CodPedido { get; set;} 
		public bool EnviarEmailCia { get; set;} 
		public int CodUsuarioFinalizacao { get; set;} 
		public int IdSolicitacaoDepara { get; set;} 
		public int CodArquivo { get; set;} 
		public bool Cancelado { get; set;} 
		public string MotivoCancelamento { get; set;} 
		public DateTime DataSolicitacao { get; set;} 
		public bool EmailEnviado { get; set;} 
		public int ComplementoCodPedido { get; set;} 
		public DateTime DataFinalizacao { get; set;} 
		public bool Finalizado { get; set;} 
		public string Motivo { get; set;} 
	}
}