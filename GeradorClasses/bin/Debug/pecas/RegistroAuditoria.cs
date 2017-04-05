using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : registros_auditoria.
	/// </summary>
	public class RegistroAuditoria
	{
		public RegistroAuditoria()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodPedido { get; set;} 
		public string Acao { get; set;} 
		public bool Finalizado { get; set;} 
		public int IdRegistroAuditoria { get; set;} 
		public int Statu { get; set;} 
		public string ItemPendente { get; set;} 
	}
}