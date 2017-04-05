using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : itenspedido_devolucao_solicitada.
	/// </summary>
	public class ItenspedidoDevolucaoSolicitada
	{
		public ItenspedidoDevolucaoSolicitada()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodItempedido { get; set;} 
		public bool Cancelada { get; set;} 
		public int CodDevolucaoSolicitada { get; set;} 
		public int IdItempedidoDevolucaoSolicitada { get; set;} 
		public bool Procede { get; set;} 
		public DateTime DataCriacao { get; set;} 
	}
}