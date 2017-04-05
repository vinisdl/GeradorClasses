using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : grupospecas_marcas.
	/// </summary>
	public class GrupospecaMarca
	{
		public GrupospecaMarca()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string Nome { get; set;} 
		public int IdGrupopecaMarca { get; set;} 
		public bool Interestadual { get; set;} 
		public int CodMarca { get; set;} 
	}
}