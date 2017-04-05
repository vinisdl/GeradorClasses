using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : pedidos_alterados.
	/// </summary>
	public class PedidoAlterado
	{
		public PedidoAlterado()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public DateTime DataAlteracao { get; set;} 
		public int Alteracao { get; set;} 
		public int CodUsuario { get; set;} 
		public int CodPedido { get; set;} 
		public int IdPedidoAlterado { get; set;} 
	}
}