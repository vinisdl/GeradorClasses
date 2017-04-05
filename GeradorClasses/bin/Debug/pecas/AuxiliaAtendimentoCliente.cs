using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : auxiliares_atendimento_clientes.
	/// </summary>
	public class AuxiliaAtendimentoCliente
	{
		public AuxiliaAtendimentoCliente()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int IdAuxiliarAtendimentoCliente { get; set;} 
		public int CodCliente { get; set;} 
		public int CodAuxiliarAtendimento { get; set;} 
	}
}