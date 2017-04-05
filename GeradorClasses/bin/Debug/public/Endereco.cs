using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : enderecos.
	/// </summary>
	public class Endereco
	{
		public Endereco()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string CoordenadaGeografica { get; set;} 
		public int IdEndereco { get; set;} 
		public string Bairro { get; set;} 
		public string Complemento { get; set;} 
		public string Logradouro { get; set;} 
		public string Numero { get; set;} 
		public int CodCidade { get; set;} 
		public string Cep { get; set;} 
	}
}