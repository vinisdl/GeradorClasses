using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : clientes.
	/// </summary>
	public class Cliente
	{
		public Cliente()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public string RazaoSocial { get; set;} 
		public decimal MargemNf { get; set;} 
		public bool PreencheOrdemServicoFornecedor { get; set;} 
		public decimal Pintura { get; set;} 
		public string InscricaoEstadual { get; set;} 
		public string TokenAcesso { get; set;} 
		public string Contato { get; set;} 
		public int PrazoReenvioCnf { get; set;} 
		public string Email { get; set;} 
		public int CodArquivoLogotipo { get; set;} 
		public int CodEndereco { get; set;} 
		public int IdCliente { get; set;} 
		public bool MostraFornecedorIntegracao { get; set;} 
		public decimal Funilaria { get; set;} 
		public bool ExtratoPagamentoObrigatorio { get; set;} 
		public int AlteracaoCodUsuario { get; set;} 
		public bool ValorMaoObraAcumulada { get; set;} 
		public int PrazoInicioConciliacao { get; set;} 
		public bool PossuiListaAnalista { get; set;} 
		public int TipoPessoaFaturar { get; set;} 
		public bool ValidacaoAutomaticaPdf { get; set;} 
		public string Telefone1Numero { get; set;} 
		public string Telefone2Numero { get; set;} 
		public DateTime AlteracaoData { get; set;} 
		public string Fax { get; set;} 
		public bool FaturarTerceiro { get; set;} 
		public string EmailNotificacao { get; set;} 
		public string Telefone2Ddd { get; set;} 
		public bool DesejaEmailConciliacao { get; set;} 
		public bool AutorizacaoSucursal { get; set;} 
		public int CodEnderecoEnvioNotaFiscal { get; set;} 
		public bool PossuiIntegracaoObservacao { get; set;} 
		public string Codigo { get; set;} 
		public bool CadastroLiberado { get; set;} 
		public int TipoCliente { get; set;} 
		public string CategoriaMarca { get; set;} 
		public bool PossuiListaPerito { get; set;} 
		public bool AtendeSegmentoNaoHomologado { get; set;} 
		public decimal Tapecaria { get; set;} 
		public string NomeFantasia { get; set;} 
		public bool Ativo { get; set;} 
		public bool PossuiIntegracaoAudatex14 { get; set;} 
		public int PrazoPagamentoFornecedo { get; set;} 
		public bool RecebeRelPedidoRecebido { get; set;} 
		public string InscricaoMunicipal { get; set;} 
		public bool AtendeSegmentoHomologado { get; set;} 
		public bool AtendeOficinaParticula { get; set;} 
		public string Telefone1Ramal { get; set;} 
		public DateTime DataAlteracaoRegrasautorizacao { get; set;} 
		public bool PossuiPedidofiscal { get; set;} 
		public string Telefone2Ramal { get; set;} 
		public int CodUsuarioAlteracaoRegrasautorizacao { get; set;} 
		public bool ObrigaDataRecebimentoPedido { get; set;} 
		public bool ObrigaEnvioOrdemCompra { get; set;} 
		public decimal MargemPedido { get; set;} 
		public string Telefone1Ddd { get; set;} 
		public string LinkAgendaInterna { get; set;} 
		public string Cnpj { get; set;} 
		public bool SinistroComVistoria { get; set;} 
		public int PrazoInicioLogisticaDevolucao { get; set;} 
		public int CodCobranca { get; set;} 
		public decimal Mecanica { get; set;} 
		public string EmailDevolucao { get; set;} 
		public decimal Eletrica { get; set;} 
	}
}