using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : situacoes_logisticas_devolucoes.
	/// </summary>
	public class SituacaoLogisticaDevolucao
	{
		public SituacaoLogisticaDevolucao()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string Descricao { get; set;} 
		public bool Ativo { get; set;} 
		public int IdSituacaoLogisticaDevolucao { get; set;} 
	}
}