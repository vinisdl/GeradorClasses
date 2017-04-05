using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : pedido_devolucao_solicitada.
	/// </summary>
	public class PedidoDevolucaoSolicitada
	{
		public PedidoDevolucaoSolicitada()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CriacaoCodUsuario { get; set;} 
		public int IdDevolucaoSolicitada { get; set;} 
		public DateTime DataCriacao { get; set;} 
		public int CodPedido { get; set;} 
		public DateTime DataEnvioDevolucao { get; set;} 
	}
}