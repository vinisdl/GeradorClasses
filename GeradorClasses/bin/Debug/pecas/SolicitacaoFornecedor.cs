using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : solicitacoes_fornecedor.
	/// </summary>
	public class SolicitacaoFornecedor
	{
		public SolicitacaoFornecedor()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodPedido { get; set;} 
		public int IdSolicitacaoFornecedor { get; set;} 
		public int CodFornecedor { get; set;} 
		public string Resposta { get; set;} 
		public string Mensagem { get; set;} 
		public int CodUsuario { get; set;} 
		public DateTime DataResposta { get; set;} 
		public DateTime DataCriacao { get; set;} 
	}
}