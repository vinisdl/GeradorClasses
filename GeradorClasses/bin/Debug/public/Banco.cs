using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : bancos.
	/// </summary>
	public class Banco
	{
		public Banco()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string Codigo { get; set;} 
		public int IdBanco { get; set;} 
		public string Nome { get; set;} 
		public bool Ativo { get; set;} 
		public string Apelido { get; set;} 
	}
}