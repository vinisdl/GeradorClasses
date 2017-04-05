using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : motivos_solicitacao_devolucao.
	/// </summary>
	public class MotivoSolicitacaoDevolucao
	{
		public MotivoSolicitacaoDevolucao()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public bool Ativo { get; set;} 
		public int TipoMotivo { get; set;} 
		public string Nome { get; set;} 
		public int Tipo { get; set;} 
		public int IdMotivoSolicitacaoDevolucao { get; set;} 
	}
}