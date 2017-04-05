using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : vistorias.
	/// </summary>
	public class Vistoria
	{
		public Vistoria()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodReguladora { get; set;} 
		public string Numero { get; set;} 
		public int CodSinistro { get; set;} 
		public int IdVistoria { get; set;} 
	}
}