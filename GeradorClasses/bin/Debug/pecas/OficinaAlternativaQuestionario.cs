using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : oficinas_alternativas_questionario.
	/// </summary>
	public class OficinaAlternativaQuestionario
	{
		public OficinaAlternativaQuestionario()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string Descricao { get; set;} 
		public int IdOficinaAlternativaQuestionario { get; set;} 
		public int CodOficinaPerguntaQuestionario { get; set;} 
		public bool ExibeMarca { get; set;} 
		public bool Especificar { get; set;} 
	}
}