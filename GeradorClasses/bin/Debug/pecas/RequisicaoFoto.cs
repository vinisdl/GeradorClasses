using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : requisicoes_fotos.
	/// </summary>
	public class RequisicaoFoto
	{
		public RequisicaoFoto()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodPedido { get; set;} 
		public int IdRequisicaoFoto { get; set;} 
		public int CodSeguradora { get; set;} 
		public string CodigoSinistro { get; set;} 
		public string LinkFoto { get; set;} 
		public int CodVeiculo { get; set;} 
		public DateTime DataImportacao { get; set;} 
		public TimeSpan DataCriacao { get; set;} 
	}
}