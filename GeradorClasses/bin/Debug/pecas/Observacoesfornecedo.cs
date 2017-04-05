using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : observacoesfornecedores.
	/// </summary>
	public class Observacoesfornecedo
	{
		public Observacoesfornecedo()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public DateTime CriacaoData { get; set;} 
		public int CriacaoCodUsuario { get; set;} 
		public int IdObservacaofornecedor { get; set;} 
		public int CodFornecedor { get; set;} 
		public string CriacaoIp { get; set;} 
		public string Conteudo { get; set;} 
	}
}