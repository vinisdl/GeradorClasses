using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : motivos_cancelamento.
	/// </summary>
	public class MotivoCancelamento
	{
		public MotivoCancelamento()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string Descricao { get; set;} 
		public bool Ativo { get; set;} 
		public int IdMotivoCancelamento { get; set;} 
		public int Tipo { get; set;} 
	}
}