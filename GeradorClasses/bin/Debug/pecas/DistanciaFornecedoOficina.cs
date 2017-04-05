using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : distancias_fornecedores_oficinas.
	/// </summary>
	public class DistanciaFornecedoOficina
	{
		public DistanciaFornecedoOficina()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public double Valor { get; set;} 
		public int IdDistancia { get; set;} 
		public int CodOficina { get; set;} 
		public int CodFornecedor { get; set;} 
	}
}