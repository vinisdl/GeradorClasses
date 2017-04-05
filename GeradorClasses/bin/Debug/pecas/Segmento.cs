using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : segmentos.
	/// </summary>
	public class Segmento
	{
		public Segmento()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public bool Ativo { get; set;} 
		public bool Homologado { get; set;} 
		public string Nome { get; set;} 
		public int IdSegmento { get; set;} 
	}
}