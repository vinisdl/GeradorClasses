using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : tentativas_integracao.
	/// </summary>
	public class TentativaIntegracao
	{
		public TentativaIntegracao()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public DateTime DataEnvio { get; set;} 
		public string Retorno { get; set;} 
		public int Tentativa { get; set;} 
		public int IdTentativa { get; set;} 
		public int CodPedidoFornecedor { get; set;} 
	}
}