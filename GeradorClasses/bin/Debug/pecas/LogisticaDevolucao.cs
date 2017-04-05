using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : logisticas_devolucao.
	/// </summary>
	public class LogisticaDevolucao
	{
		public LogisticaDevolucao()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodPedidoFornecedor { get; set;} 
		public DateTime DataNovoContato { get; set;} 
		public DateTime DataEncerramento { get; set;} 
		public int AuxiliarCodUsuario { get; set;} 
		public int IdLogisticaDevolucao { get; set;} 
		public DateTime DataLocacao { get; set;} 
		public int EncerramentoCodUsuario { get; set;} 
		public int CodSituacaoLogisticaDevolucao { get; set;} 
		public int SituacaoOficina { get; set;} 
		public int SituacaoFornecedor { get; set;} 
		public DateTime DataCriacao { get; set;} 
	}
}