using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : observacoes_descontos.
	/// </summary>
	public class ObservacaoDesconto
	{
		public ObservacaoDesconto()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public DateTime CriacaoData { get; set;} 
		public int CriacaoCodUsuario { get; set;} 
		public int CodFornecedor { get; set;} 
		public int CodCliente { get; set;} 
		public string Motivo { get; set;} 
		public string CriacaoIp { get; set;} 
		public string Conteudo { get; set;} 
		public int IdObservacaoDesconto { get; set;} 
	}
}