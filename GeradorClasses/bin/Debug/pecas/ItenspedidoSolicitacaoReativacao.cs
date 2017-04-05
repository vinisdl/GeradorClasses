using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : itenspedido_solicitacao_reativacao.
	/// </summary>
	public class ItenspedidoSolicitacaoReativacao
	{
		public ItenspedidoSolicitacaoReativacao()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public DateTime DataAtuacao { get; set;} 
		public int CodArquivo { get; set;} 
		public int IdItemSolicitacaoReativacao { get; set;} 
		public string ContatoOficina { get; set;} 
		public bool Aprovada { get; set;} 
		public int Motivo { get; set;} 
		public DateTime DataSolicitacao { get; set;} 
		public bool Cancelado { get; set;} 
		public int CodItempedidoFornecedor { get; set;} 
	}
}