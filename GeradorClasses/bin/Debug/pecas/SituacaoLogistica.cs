using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : situacao_logisticas.
	/// </summary>
	public class SituacaoLogistica
	{
		public SituacaoLogistica()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int Pedido { get; set;} 
		public int IdStatuLogistica { get; set;} 
		public int CodCliente { get; set;} 
		public DateTime DataGeracao { get; set;} 
		public int TipoStatu { get; set;} 
		public string Cliente { get; set;} 
		public string Estado { get; set;} 
	}
}