using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : atuacoes_bo.
	/// </summary>
	public class AtuacaoBo
	{
		public AtuacaoBo()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string Atuacao { get; set;} 
		public DateTime DataAtuacao { get; set;} 
		public int IdAtuacaoBo { get; set;} 
		public int CodItemBo { get; set;} 
		public int Statu { get; set;} 
	}
}