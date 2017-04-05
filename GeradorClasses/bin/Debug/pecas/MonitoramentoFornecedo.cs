using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : monitoramentos_fornecedores.
	/// </summary>
	public class MonitoramentoFornecedo
	{
		public MonitoramentoFornecedo()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public bool SituacaoCritica { get; set;} 
		public int CodFornecedor { get; set;} 
		public int IdMonitoramentoFornecedor { get; set;} 
		public int Statu { get; set;} 
		public int CodUsuario { get; set;} 
		public DateTime DataAtualizacao { get; set;} 
	}
}