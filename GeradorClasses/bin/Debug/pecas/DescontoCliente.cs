using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : descontos_clientes.
	/// </summary>
	public class DescontoCliente
	{
		public DescontoCliente()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodCliente { get; set;} 
		public int CodMarca { get; set;} 
		public float? Desconto { get; set;} 
		public int IdDescontoCliente { get; set;} 
		public int CodEstado { get; set;} 
	}
}