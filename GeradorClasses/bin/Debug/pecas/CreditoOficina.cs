using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : credito_oficina.
	/// </summary>
	public class CreditoOficina
	{
		public CreditoOficina()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public DateTime DataConfirmacaoCredito { get; set;} 
		public int CodPedido { get; set;} 
		public DateTime DataCancelamento { get; set;} 
		public bool Cancelado { get; set;} 
		public int CodUsuarioConfirmacao { get; set;} 
		public int IdCreditoOficina { get; set;} 
		public int MotivoCreditoCancelamento { get; set;} 
		public bool CreditoUtilizado { get; set;} 
		public DateTime DataCreditoUtilizado { get; set;} 
		public decimal Credito { get; set;} 
		public DateTime DataCriacao { get; set;} 
	}
}