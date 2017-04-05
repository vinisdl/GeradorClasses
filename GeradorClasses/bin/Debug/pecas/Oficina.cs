using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : oficinas.
	/// </summary>
	public class Oficina
	{
		public Oficina()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string RazaoSocial { get; set;} 
		public string Telefone3Numero { get; set;} 
		public int AlteracaoCodUsuario { get; set;} 
		public DateTime DataSolicitacaoNegociacao { get; set;} 
		public string Contato { get; set;} 
		public bool Credenciada { get; set;} 
		public int CodEndereco { get; set;} 
		public string Email { get; set;} 
		public bool AtendeTelefone { get; set;} 
		public string ChaveAcesso { get; set;} 
		public string Telefone1Numero { get; set;} 
		public string Telefone2Numero { get; set;} 
		public DateTime AlteracaoData { get; set;} 
		public string Fax { get; set;} 
		public string Telefone2Ddd { get; set;} 
		public int IdOficina { get; set;} 
		public string Telefone3Ramal { get; set;} 
		public string Fone2 { get; set;} 
		public string Fone1 { get; set;} 
		public DateTime DataConclusaoNegociacao { get; set;} 
		public string IdSkype { get; set;} 
		public DateTime DataChaveAcesso { get; set;} 
		public string NomeFantasia { get; set;} 
		public bool Ativo { get; set;} 
		public string InscricaoMunicipal { get; set;} 
		public string Telefone1Ramal { get; set;} 
		public string Codigo { get; set;} 
		public string InscricaoEstadual { get; set;} 
		public string Telefone2Ramal { get; set;} 
		public string Telefone1Ddd { get; set;} 
		public string Cnpj { get; set;} 
		public string Telefone3Ddd { get; set;} 
		public string Nextel { get; set;} 
		public string Observacao { get; set;} 
	}
}