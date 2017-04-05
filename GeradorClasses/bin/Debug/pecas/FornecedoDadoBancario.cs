using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : fornecedores_dados_bancarios.
	/// </summary>
	public class FornecedoDadoBancario
	{
		public FornecedoDadoBancario()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodFornecedorContato { get; set;} 
		public int AlteracaoCodUsuario { get; set;} 
		public int CodFornecedor { get; set;} 
		public string BancoAgencia { get; set;} 
		public string BancoConta { get; set;} 
		public int IdFornecedorDadoBancario { get; set;} 
		public int CodBanco { get; set;} 
		public string BancoNumero { get; set;} 
		public DateTime AlteracaoData { get; set;} 
	}
}