using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : sinistros.
	/// </summary>
	public class Sinistro
	{
		public Sinistro()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string Local { get; set;} 
		public DateTime DataAcidente { get; set;} 
		public string CodigoVistoria { get; set;} 
		public string NomeAnalista { get; set;} 
		public int CodAnalista { get; set;} 
		public int CodCidade { get; set;} 
		public DateTime PagamentoCancelado { get; set;} 
		public string Codigo { get; set;} 
		public int OficinaSequencial { get; set;} 
		public int CodCliente { get; set;} 
		public int CodSucursal { get; set;} 
		public int IdSinistro { get; set;} 
		public string NomePerito { get; set;} 
		public DateTime DataAbertura { get; set;} 
		public int CodPerito { get; set;} 
	}
}