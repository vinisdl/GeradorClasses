using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : requisicoes_envio_carta_pdf.
	/// </summary>
	public class RequisicaoEnvioCartaPdf
	{
		public RequisicaoEnvioCartaPdf()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string CodigoSinistro { get; set;} 
		public int CodPedido { get; set;} 
		public int IdRequisicaoEnvioCartaPdf { get; set;} 
		public int CodArquivo { get; set;} 
		public int CodCliente { get; set;} 
		public int CriacaoCodUsuario { get; set;} 
		public string Conteudo { get; set;} 
		public TimeSpan DataImportacao { get; set;} 
		public TimeSpan DataCriacao { get; set;} 
	}
}