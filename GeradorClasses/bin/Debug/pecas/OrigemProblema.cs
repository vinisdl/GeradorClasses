using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : origens_problema.
	/// </summary>
	public class OrigemProblema
	{
		public OrigemProblema()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string Descricao { get; set;} 
		public int IdOrigemProblema { get; set;} 
		public int CodMotivoAtraso { get; set;} 
	}
}