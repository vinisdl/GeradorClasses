using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : auxiliares_ressarcimento.
	/// </summary>
	public class AuxiliaRessarcimento
	{
		public AuxiliaRessarcimento()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int IdAuxiliarRessarcimento { get; set;} 
		public int CodCliente { get; set;} 
		public bool Ativo { get; set;} 
		public int CodUsuario { get; set;} 
		public int Ordem { get; set;} 
	}
}