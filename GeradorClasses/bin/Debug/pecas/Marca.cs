using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : marcas.
	/// </summary>
	public class Marca
	{
		public Marca()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string TelefonesacDdd { get; set;} 
		public int AlteracaoCodUsuario { get; set;} 
		public string TelefonesacNumero { get; set;} 
		public string TelefonesacRamal { get; set;} 
		public int Categoria { get; set;} 
		public string Endereco { get; set;} 
		public string Nome { get; set;} 
		public int IdMarca { get; set;} 
		public string Cep { get; set;} 
		public DateTime AlteracaoData { get; set;} 
	}
}