using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : atendimentos_observacoes.
	/// </summary>
	public class AtendimentoObservacao
	{
		public AtendimentoObservacao()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string Mensagem { get; set;} 
		public int IdAtendimentoObservacao { get; set;} 
		public int CodUsuario { get; set;} 
		public DateTime DataCriacao { get; set;} 
		public int CodAtendimento { get; set;} 
	}
}