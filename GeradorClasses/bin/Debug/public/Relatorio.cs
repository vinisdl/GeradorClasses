using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : relatorios.
	/// </summary>
	public class Relatorio
	{
		public Relatorio()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string Nome { get; set;} 
		public string NomeArquivo { get; set;} 
		public int IdRelatorio { get; set;} 
		public string NomeAmbRelatorio { get; set;} 
	}
}