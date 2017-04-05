using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : fornecedores_seguradoras.
	/// </summary>
	public class FornecedoSeguradora
	{
		public FornecedoSeguradora()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodCliente { get; set;} 
		public int IdFornecedorSeguradora { get; set;} 
		public string CodigoSeguradora { get; set;} 
		public int CodFornecedor { get; set;} 
	}
}