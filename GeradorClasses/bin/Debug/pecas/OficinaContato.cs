using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : oficinas_contatos.
	/// </summary>
	public class OficinaContato
	{
		public OficinaContato()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string TelefoneRamal { get; set;} 
		public int CodOficina { get; set;} 
		public string CelularNumero { get; set;} 
		public int CodUsuario { get; set;} 
		public string Nome { get; set;} 
		public DateTime? AlteracaoData { get; set;} 
		public string CelularRamal { get; set;} 
		public string TelefoneDdd { get; set;} 
		public bool Ativo { get; set;} 
		public string CelularDdd { get; set;} 
		public int IdOficinaContato { get; set;} 
		public string Nextel { get; set;} 
		public int AlteracaoCodUsuario { get; set;} 
		public string TelefoneNumero { get; set;} 
		public string Idskype { get; set;} 
		public int TipoContato { get; set;} 
		public bool RecebeNotificacao { get; set;} 
		public string Email { get; set;} 
	}
}