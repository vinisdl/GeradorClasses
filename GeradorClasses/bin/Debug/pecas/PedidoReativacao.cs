using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : pedidos_reativacao.
	/// </summary>
	public class PedidoReativacao
	{
		public PedidoReativacao()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public DateTime DataCancelamento { get; set;} 
		public int CodPedido { get; set;} 
		public bool Cancelada { get; set;} 
		public DateTime DataReativacao { get; set;} 
		public string Motivo { get; set;} 
		public int CodUsuario { get; set;} 
		public int TipoReativacao { get; set;} 
		public int IdPedidoReativacao { get; set;} 
		public DateTime DataCriacao { get; set;} 
	}
}