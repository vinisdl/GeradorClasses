using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : pedidos_segmentos.
	/// </summary>
	public class PedidoSegmento
	{
		public PedidoSegmento()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int IdPedidoSegmento { get; set;} 
		public int CodPedido { get; set;} 
		public int CodSegmento { get; set;} 
	}
}