using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : fornecedores_marcas.
	/// </summary>
	public class FornecedoMarca
	{
		public FornecedoMarca()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int IdFornecedorMarca { get; set;} 
		public int CodMarca { get; set;} 
		public int CodFornecedor { get; set;} 
	}
}