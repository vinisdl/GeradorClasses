using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : fornecedores.
	/// </summary>
	public class Fornecedo
	{
		public Fornecedo()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string RazaoSocial { get; set;} 
		public bool Importador { get; set;} 
		public int AlteracaoCodUsuario { get; set;} 
		public string Contato { get; set;} 
		public int CodEndereco { get; set;} 
		public string Email { get; set;} 
		public int TipoDesconto { get; set;} 
		public string CnfResponsavel { get; set;} 
		public bool CadastroLiberado { get; set;} 
		public int IdFornecedor { get; set;} 
		public int PeriodicidadeRanking { get; set;} 
		public bool FornecedorDestaque { get; set;} 
		public string Telefone1Numero { get; set;} 
		public string Telefone2Numero { get; set;} 
		public DateTime AlteracaoData { get; set;} 
		public string Fax { get; set;} 
		public string Telefone2Ddd { get; set;} 
		public bool RecebePedido { get; set;} 
		public bool FornecedorNovo { get; set;} 
		public string Fone2 { get; set;} 
		public string EmailEnvioCnf { get; set;} 
		public string Fone1 { get; set;} 
		public string CnfTelefoneDdd { get; set;} 
		public string BancoAgencia { get; set;} 
		public DateTime AceitaCondicaoData { get; set;} 
		public string CnfTelefoneNumero { get; set;} 
		public string NomeFantasia { get; set;} 
		public bool Ativo { get; set;} 
		public bool SomenteNfe { get; set;} 
		public string InscricaoMunicipal { get; set;} 
		public string ModalidadeFrete { get; set;} 
		public bool Interestadual { get; set;} 
		public string Telefone1Ramal { get; set;} 
		public string Codigo { get; set;} 
		public int AceitaCondicaoCodUsuario { get; set;} 
		public string InscricaoEstadual { get; set;} 
		public string Telefone2Ramal { get; set;} 
		public int CodEstatisticaFornecedor { get; set;} 
		public string BancoNumero { get; set;} 
		public string Telefone1Ddd { get; set;} 
		public string BancoConta { get; set;} 
		public string Cnpj { get; set;} 
		public string CnfTelefoneRamal { get; set;} 
		public int StatuFornecedor { get; set;} 
		public bool Reserva { get; set;} 
		public bool RecebeEmailCotacao { get; set;} 
		public float? DescontoEspecifico { get; set;} 
	}
}