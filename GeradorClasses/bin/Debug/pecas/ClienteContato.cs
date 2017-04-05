using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : clientes_contatos.
	/// </summary>
	public class ClienteContato
	{
		public ClienteContato()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string TelefoneRamal { get; set;} 
		public string Nome { get; set;} 
		public DateTime AlteracaoData { get; set;} 
		public string TelefoneDdd { get; set;} 
		public bool Ativo { get; set;} 
		public bool RecebeRelatorio { get; set;} 
		public int CodCliente { get; set;} 
		public string Nextel { get; set;} 
		public int AlteracaoCodUsuario { get; set;} 
		public int IdClienteContato { get; set;} 
		public string TelefoneNumero { get; set;} 
		public int TipoContato { get; set;} 
		public bool RecebeNotificacao { get; set;} 
		public string Email { get; set;} 
	}
}