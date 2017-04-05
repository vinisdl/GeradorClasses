using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : auxiliares_cnf.
	/// </summary>
	public class AuxiliaCnf
	{
		public AuxiliaCnf()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodCliente { get; set;} 
		public bool Ativo { get; set;} 
		public int CodUsuario { get; set;} 
		public int IdAuxiliarCnf { get; set;} 
		public int Ordem { get; set;} 
	}
}