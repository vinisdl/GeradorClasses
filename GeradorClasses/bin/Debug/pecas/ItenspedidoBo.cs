using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : itenspedido_bo.
	/// </summary>
	public class ItenspedidoBo
	{
		public ItenspedidoBo()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public DateTime DataCriacaoPdf { get; set;} 
		public int CodItempedido { get; set;} 
		public string Laudo { get; set;} 
		public DateTime DataPedidoFabrica { get; set;} 
		public int CodUsuario { get; set;} 
		public DateTime DataPrevista { get; set;} 
		public int CodMarca { get; set;} 
		public int IdItemBo { get; set;} 
		public DateTime DataCriacao { get; set;} 
	}
}