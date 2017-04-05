using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : auxiliares_devolucao.
	/// </summary>
	public class AuxiliaDevolucao
	{
		public AuxiliaDevolucao()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int IdAuxiliarDevolucao { get; set;} 
		public int CodCliente { get; set;} 
		public bool Ativo { get; set;} 
		public int CodUsuario { get; set;} 
		public int Ordem { get; set;} 
	}
}