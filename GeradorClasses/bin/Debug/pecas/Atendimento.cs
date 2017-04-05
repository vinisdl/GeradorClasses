using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : atendimentos.
	/// </summary>
	public class Atendimento
	{
		public Atendimento()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int IdAtendimento { get; set;} 
		public int CodPedido { get; set;} 
		public int CodUsuarioResponsavel { get; set;} 
		public DateTime DataEncerramento { get; set;} 
		public int CodUsuarioCriacao { get; set;} 
		public int Statu { get; set;} 
		public DateTime DataReabertura { get; set;} 
		public int CodTipoAtendimento { get; set;} 
		public string Descricao { get; set;} 
		public DateTime DataCriacao { get; set;} 
	}
}