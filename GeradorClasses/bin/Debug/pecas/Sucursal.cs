using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : sucursais.
	/// </summary>
	public class Sucursal
	{
		public Sucursal()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string Telefone1Ramal { get; set;} 
		public string Email { get; set;} 
		public string Contato { get; set;} 
		public int CodEndereco { get; set;} 
		public string RazaoSocial { get; set;} 
		public int IdSucursal { get; set;} 
		public string Telefone2Numero { get; set;} 
		public DateTime AlteracaoData { get; set;} 
		public string Codigo { get; set;} 
		public string InscricaoEstadual { get; set;} 
		public string Telefone1Numero { get; set;} 
		public string Fax { get; set;} 
		public int CodCliente { get; set;} 
		public string NomeFantasia { get; set;} 
		public int AlteracaoCodUsuario { get; set;} 
		public bool Ativo { get; set;} 
		public string InscricaoMunicipal { get; set;} 
		public string Telefone2Ddd { get; set;} 
		public string Telefone1Ddd { get; set;} 
		public string Telefone2Ramal { get; set;} 
		public int CodCobranca { get; set;} 
		public string Cnpj { get; set;} 
	}
}