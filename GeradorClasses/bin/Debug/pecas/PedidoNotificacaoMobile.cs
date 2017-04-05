using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : pedidos_notificacoes_mobile.
	/// </summary>
	public class PedidoNotificacaoMobile
	{
		public PedidoNotificacaoMobile()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodPedido { get; set;} 
		public int IdPedidoNotificacao { get; set;} 
		public int Origem { get; set;} 
		public DateTime DataVisualizado { get; set;} 
		public int CodObservacao { get; set;} 
		public bool ClienteVisualiza { get; set;} 
		public bool Visualizado { get; set;} 
	}
}