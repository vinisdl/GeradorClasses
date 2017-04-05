using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : logisticas.
	/// </summary>
	public class Logistica
	{
		public Logistica()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodRetorno { get; set;} 
		public int CodPedido { get; set;} 
		public string PessoaContatada { get; set;} 
		public int IdLogistica { get; set;} 
		public int CodUsuario { get; set;} 
		public DateTime DataAbertura { get; set;} 
		public int MotivoReabertura { get; set;} 
		public int CodFormacontato { get; set;} 
		public DateTime DataFechamento { get; set;} 
		public DateTime DataNovoContato { get; set;} 
	}
}