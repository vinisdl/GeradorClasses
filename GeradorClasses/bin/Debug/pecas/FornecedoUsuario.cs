using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : fornecedores_usuarios.
	/// </summary>
	public class FornecedoUsuario
	{
		public FornecedoUsuario()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int IdFornecedorUsuario { get; set;} 
		public int CodUsuario { get; set;} 
		public int CodFornecedor { get; set;} 
	}
}