using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : fornecedores_sumario_pedidos.
	/// </summary>
	public class FornecedoSumarioPedido
	{
		public FornecedoSumarioPedido()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodFornecedor { get; set;} 
		public int Danfependente { get; set;} 
		public int Aguardandoentrega { get; set;} 
		public int Devolvido { get; set;} 
		public int Aguardandoorcamento { get; set;} 
		public int Aguardandoimpressao { get; set;} 
		public int Aguardandoautorizacao { get; set;} 
	}
}