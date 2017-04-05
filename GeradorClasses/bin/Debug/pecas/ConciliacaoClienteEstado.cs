using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : conciliacao_cliente_estado.
	/// </summary>
	public class ConciliacaoClienteEstado
	{
		public ConciliacaoClienteEstado()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodCliente { get; set;} 
		public int IdConciliacaoClienteEstado { get; set;} 
		public int CodEstado { get; set;} 
	}
}