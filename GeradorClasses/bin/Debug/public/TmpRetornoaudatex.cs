using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : tmp_retornoaudatex.
	/// </summary>
	public class TmpRetornoaudatex
	{
		public TmpRetornoaudatex()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int Id { get; set;} 
		public string Pedido { get; set;} 
		public string Placa { get; set;} 
		public string Orc { get; set;} 
		public string Statu { get; set;} 
		public object Numval { get; set;} 
		public string Sinistro { get; set;} 
	}
}