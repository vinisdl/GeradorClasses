using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : pedidos_compras_oficinas.
	/// </summary>
	public class PedidoCompraOficina
	{
		public PedidoCompraOficina()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodPedido { get; set;} 
		public int IdPedidoCompraOficina { get; set;} 
		public DateTime DataVencimento { get; set;} 
		public int FormaPagamento { get; set;} 
		public string Bandeira { get; set;} 
		public decimal Valor { get; set;} 
		public DateTime DataPagamento { get; set;} 
		public int Parcela { get; set;} 
	}
}