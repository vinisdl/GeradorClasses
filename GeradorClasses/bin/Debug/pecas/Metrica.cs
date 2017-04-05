using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : metricas.
	/// </summary>
	public class Metrica
	{
		public Metrica()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public decimal PercentualPedidoAtrazado { get; set;} 
		public DateTime DataCriacao { get; set;} 
		public int Tipo { get; set;} 
		public int IdMetrica { get; set;} 
		public decimal PercentualPedidoDevolucaoAberto { get; set;} 
		public decimal PercentualPedidoAlterado { get; set;} 
		public string Nome { get; set;} 
		public DateTime DataAlteracao { get; set;} 
		public int QuantidadePedidoAutorizado { get; set;} 
		public int QuantidadePedidoRecebido { get; set;} 
		public int CodUsuarioAlteracao { get; set;} 
		public decimal PercentualSemCotacao { get; set;} 
		public int CodUsuarioCriacao { get; set;} 
		public int QuantidadeDevolucaoEmAberto { get; set;} 
	}
}