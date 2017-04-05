using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : pedidos_simulacoes.
	/// </summary>
	public class PedidoSimulacao
	{
		public PedidoSimulacao()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodPedido { get; set;} 
		public int IdPedidoSimulacao { get; set;} 
		public bool SimulacaoAceita { get; set;} 
		public bool IntegracaoEnviada { get; set;} 
		public bool Enviada { get; set;} 
		public DateTime DataSimulacao { get; set;} 
		public int CodUsuario { get; set;} 
		public int Numero { get; set;} 
		public bool CotacaoAutorizadaOficinaParticular { get; set;} 
		public DateTime DataSimulacaoAceita { get; set;} 
		public DateTime DataCriacao { get; set;} 
	}
}