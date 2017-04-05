using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : proprietarios.
	/// </summary>
	public class Proprietario
	{
		public Proprietario()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string FaxRamal { get; set;} 
		public string FaxDdd { get; set;} 
		public string Email { get; set;} 
		public string CpfCnpj { get; set;} 
		public string TelefoneNumero { get; set;} 
		public string Nome { get; set;} 
		public string Rg { get; set;} 
		public string TelefoneDdd { get; set;} 
		public string FaxNumero { get; set;} 
		public int IdProprietario { get; set;} 
		public int CodEndereco { get; set;} 
		public string TelefoneRamal { get; set;} 
	}
}