using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : monitoramento_metricas.
	/// </summary>
	public class MonitoramentoMetrica
	{
		public MonitoramentoMetrica()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int IdMonitoramentoMetrica { get; set;} 
		public int CodMonitoramentoFornecedor { get; set;} 
		public int CodMetrica { get; set;} 
	}
}