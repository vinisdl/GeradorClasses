using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : clientes_dados_bancarios.
	/// </summary>
	public class ClienteDadoBancario
	{
		public ClienteDadoBancario()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodClienteContato { get; set;} 
		public int AlteracaoCodUsuario { get; set;} 
		public string RazaoSocial { get; set;} 
		public int CodBanco { get; set;} 
		public string BancoAgencia { get; set;} 
		public string BancoConta { get; set;} 
		public int CodCliente { get; set;} 
		public bool Ativo { get; set;} 
		public int IdClienteDadoBancario { get; set;} 
		public string BancoNumero { get; set;} 
		public TimeSpan AlteracaoData { get; set;} 
		public string Cnpj { get; set;} 
	}
}