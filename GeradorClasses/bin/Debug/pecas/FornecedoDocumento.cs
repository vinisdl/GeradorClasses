using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : fornecedores_documentos.
	/// </summary>
	public class FornecedoDocumento
	{
		public FornecedoDocumento()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string NomeArquivo { get; set;} 
		public int IdFornecedorDocumento { get; set;} 
		public int TipoDocumento { get; set;} 
		public int CodFornecedor { get; set;} 
	}
}