using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : itenspedido_depara.
	/// </summary>
	public class ItenspedidoDepara
	{
		public ItenspedidoDepara()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodItempedido { get; set;} 
		public int CodMotivoDevolucao { get; set;} 
		public int CodSolicitacaoDepara { get; set;} 
		public string SubDescricao { get; set;} 
		public decimal ValorBrutoOriginal { get; set;} 
		public int CodArquivoImagemCatalogo { get; set;} 
		public int IdItempedidoDepara { get; set;} 
		public string SubPathnumber { get; set;} 
		public decimal SubValorBruto { get; set;} 
		public bool Procede { get; set;} 
		public int Motivo { get; set;} 
	}
}