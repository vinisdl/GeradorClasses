using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : reguladoras.
	/// </summary>
	public class Reguladora
	{
		public Reguladora()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public bool Ativo { get; set;} 
		public int IdReguladora { get; set;} 
		public string Nome { get; set;} 
		public string Cnpj { get; set;} 
	}
}