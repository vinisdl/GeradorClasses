using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : cobrancas.
	/// </summary>
	public class Cobranca
	{
		public Cobranca()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int IdCobranca { get; set;} 
		public int CodCliente { get; set;} 
		public string TelefoneNumero { get; set;} 
		public string Codigo { get; set;} 
		public string TelefoneDdd { get; set;} 
		public string Contato { get; set;} 
		public string Email { get; set;} 
		public int CodEndereco { get; set;} 
		public string TelefoneRamal { get; set;} 
	}
}