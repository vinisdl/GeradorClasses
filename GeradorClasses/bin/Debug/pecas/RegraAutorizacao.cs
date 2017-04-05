using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : regras_autorizacao.
	/// </summary>
	public class RegraAutorizacao
	{
		public RegraAutorizacao()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public DateTime DataAlteracaoRegrasautorizacao { get; set;} 
		public int MargemIdadeVeiculo { get; set;} 
		public bool AutorizacaoAutomatica { get; set;} 
		public int CodUsuarioAlteracaoRegrasautorizacao { get; set;} 
		public string OrdemEscolhaPeca { get; set;} 
		public int MargemParticipacaoDistribuidor { get; set;} 
		public decimal MargemPedido { get; set;} 
		public bool FornecimentoInterestadual { get; set;} 
		public int PrazoMaximo { get; set;} 
		public bool PermiteSubstituida { get; set;} 
		public int CodCliente { get; set;} 
		public int IdRegraAutorizacao { get; set;} 
		public int TempoAutorizacao { get; set;} 
	}
}