using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : respostas_cata_pecas.
	/// </summary>
	public class RespostaCataPeca
	{
		public RespostaCataPeca()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public bool PossuiItem { get; set;} 
		public decimal Desconto { get; set;} 
		public int IdRespostaCatapeca { get; set;} 
		public int CodItempedido { get; set;} 
		public decimal ValorBruto { get; set;} 
		public string PathnumberAlternativo { get; set;} 
		public DateTime DataInformada { get; set;} 
		public int CodFornecedor { get; set;} 
		public bool ForneceItem { get; set;} 
		public int Prazo { get; set;} 
	}
}