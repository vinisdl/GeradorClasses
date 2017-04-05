using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : auxiliares_compra.
	/// </summary>
	public class AuxiliaCompra
	{
		public AuxiliaCompra()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int Ordem { get; set;} 
		public int IdAuxiliarCompra { get; set;} 
		public int CodEstado { get; set;} 
		public bool Ativo { get; set;} 
		public int CodUsuario { get; set;} 
		public int NumeroPedidoFase2 { get; set;} 
		public int Fase { get; set;} 
		public bool Vulneravel { get; set;} 
		public int CodCliente { get; set;} 
		public int NumeroPedido { get; set;} 
	}
}