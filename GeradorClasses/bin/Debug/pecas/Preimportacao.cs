using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : preimportacoes.
	/// </summary>
	public class Preimportacao
	{
		public Preimportacao()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodCliente { get; set;} 
		public int IdPreimportacao { get; set;} 
		public DateTime CriacaoData { get; set;} 
		public string Observacao { get; set;} 
		public int CriacaoCodUsuario { get; set;} 
	}
}