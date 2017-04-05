using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : peritos.
	/// </summary>
	public class Perito
	{
		public Perito()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string Cnpj { get; set;} 
		public int CodCliente { get; set;} 
		public bool Ativo { get; set;} 
		public string Nome { get; set;} 
		public string Email { get; set;} 
		public int IdPerito { get; set;} 
		public int CodUsuario { get; set;} 
	}
}