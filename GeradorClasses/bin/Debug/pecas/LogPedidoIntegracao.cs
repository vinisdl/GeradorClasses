using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : log_pedidos_integracao.
	/// </summary>
	public class LogPedidoIntegracao
	{
		public LogPedidoIntegracao()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string Mensagem { get; set;} 
		public DateTime DataEnvio { get; set;} 
		public int Tipo { get; set;} 
		public int CodPedido { get; set;} 
		public int IdLogPedido { get; set;} 
	}
}