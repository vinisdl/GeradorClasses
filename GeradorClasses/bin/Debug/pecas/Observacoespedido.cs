using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : observacoespedidos.
	/// </summary>
	public class Observacoespedido
	{
		public Observacoespedido()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public DateTime CriacaoData { get; set;} 
		public int CodPedido { get; set;} 
		public int CodFornecedor { get; set;} 
		public bool Automatica { get; set;} 
		public bool Oficina { get; set;} 
		public int CriacaoCodUsuario { get; set;} 
		public string CriacaoIp { get; set;} 
		public string Conteudo { get; set;} 
		public bool Integrar { get; set;} 
		public int TipoObservacao { get; set;} 
		public int IdObservacaopedido { get; set;} 
	}
}