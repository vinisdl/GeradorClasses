using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : descontos_clientes_grupos.
	/// </summary>
	public class DescontoClienteGrupo
	{
		public DescontoClienteGrupo()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public float? Desconto { get; set;} 
		public int IdDescontoClienteGrupo { get; set;} 
		public int CodGrupopecaMarca { get; set;} 
		public int CodDescontoCliente { get; set;} 
	}
}