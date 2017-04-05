using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : descontos_grupospecas_marcas.
	/// </summary>
	public class DescontoGrupospecaMarca
	{
		public DescontoGrupospecaMarca()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int IdDescontoGrupopecaMarca { get; set;} 
		public int CodDesconto { get; set;} 
		public float? ValorDesconto { get; set;} 
		public int CodGrupopecaMarca { get; set;} 
	}
}