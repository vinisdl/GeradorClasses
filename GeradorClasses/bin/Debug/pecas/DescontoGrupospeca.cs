using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : descontos_grupospecas.
	/// </summary>
	public class DescontoGrupospeca
	{
		public DescontoGrupospeca()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodDesconto { get; set;} 
		public int CodGrupopeca { get; set;} 
		public float? ValorDesconto { get; set;} 
		public int IdDescontoGrupopeca { get; set;} 
	}
}