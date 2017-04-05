using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : oficinas_perguntas_questionario.
	/// </summary>
	public class OficinaPerguntaQuestionario
	{
		public OficinaPerguntaQuestionario()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int OrdemPergunta { get; set;} 
		public string Enunciado { get; set;} 
		public bool MultiplaEscolha { get; set;} 
		public int IdOficinaPerguntaQuestionario { get; set;} 
	}
}