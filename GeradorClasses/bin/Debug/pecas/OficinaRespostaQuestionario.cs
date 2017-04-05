using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : oficinas_respostas_questionario.
	/// </summary>
	public class OficinaRespostaQuestionario
	{
		public OficinaRespostaQuestionario()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodOficina { get; set;} 
		public DateTime DataAlteracao { get; set;} 
		public string RespostaEspecifica { get; set;} 
		public int CodOficinaAlternativaQuestionario { get; set;} 
		public int CodUsuarioAlteracao { get; set;} 
		public int IdOficinaRespostaQuestionario { get; set;} 
	}
}