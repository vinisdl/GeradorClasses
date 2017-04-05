using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : regioes_cidades.
	/// </summary>
	public class RegiaoCidade
	{
		public RegiaoCidade()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int IdRegiaoCidade { get; set;} 
		public int CodCidade { get; set;} 
		public int CodRegiao { get; set;} 
	}
}