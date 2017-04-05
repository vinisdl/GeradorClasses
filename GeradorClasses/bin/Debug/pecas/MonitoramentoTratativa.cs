using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : monitoramentos_tratativas.
	/// </summary>
	public class MonitoramentoTratativa
	{
		public MonitoramentoTratativa()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int IdMonitoramentoTratativa { get; set;} 
		public DateTime DataEnvioNotificacao { get; set;} 
		public string Texto { get; set;} 
		public int CodUsuario { get; set;} 
		public bool Notificacao { get; set;} 
		public int CodArquivo { get; set;} 
		public int CodMonitoramentoFornecedor { get; set;} 
		public DateTime DataCriacao { get; set;} 
	}
}