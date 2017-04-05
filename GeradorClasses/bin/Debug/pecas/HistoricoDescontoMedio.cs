using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : historico_desconto_medio.
	/// </summary>
	public class HistoricoDescontoMedio
	{
		public HistoricoDescontoMedio()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public float? DescontoMedio { get; set;} 
		public DateTime DataGeracao { get; set;} 
		public int TipoFornecedor { get; set;} 
		public float? DescontoMinimo { get; set;} 
		public float? DescontoMaximo { get; set;} 
		public int CodMarca { get; set;} 
		public int CodEstado { get; set;} 
		public int IdHistorico { get; set;} 
	}
}