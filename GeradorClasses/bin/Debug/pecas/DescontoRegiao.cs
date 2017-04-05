using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : descontos_regioes.
	/// </summary>
	public class DescontoRegiao
	{
		public DescontoRegiao()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int IdDescontoRegiao { get; set;} 
		public int CodFornecedorRegiaoCliente { get; set;} 
		public float? ValorDesconto { get; set;} 
		public int CodFornecedorMarca { get; set;} 
	}
}