using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : itenspedido_fornecedores.
	/// </summary>
	public class ItenspedidoFornecedo
	{
		public ItenspedidoFornecedo()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int CodNotafiscalDevol { get; set;} 
		public string NomeMarca { get; set;} 
		public float? Desconto { get; set;} 
		public DateTime EnviadaConfirmacaoDevolucao { get; set;} 
		public int Prazo { get; set;} 
		public int JustifPrazo { get; set;} 
		public DateTime DataPrazoEntrega { get; set;} 
		public DateTime LogisticaDataEntrega { get; set;} 
		public DateTime DataImpressaoDevolucao { get; set;} 
		public string DevolMotivo { get; set;} 
		public bool DevolSolicitada { get; set;} 
		public decimal PrecoBruto { get; set;} 
		public bool DevolImpressa { get; set;} 
		public int LogisticaRecolhimento { get; set;} 
		public int CodNotafiscalVenda { get; set;} 
		public string DevolMotivoDesc { get; set;} 
		public bool Fornece { get; set;} 
		public int PrazoInicialCotacao { get; set;} 
		public DateTime DevolDataAutorizacao { get; set;} 
		public DateTime DevolDataCancelamento { get; set;} 
		public string JustificativaNaofornece { get; set;} 
		public string SituacaoFornecimento { get; set;} 
		public int CodPedidofornecedor { get; set;} 
		public bool Entregue { get; set;} 
		public int LogisticaPrevisao { get; set;} 
		public string Descricao { get; set;} 
		public int CodLogisticaDevolucao { get; set;} 
		public int CodMarcaPeca { get; set;} 
		public string Pathnumber { get; set;} 
		public int CodMotivoAlteracaoPrazo { get; set;} 
		public decimal ValorTotalLiquido { get; set;} 
		public int CodItempedido { get; set;} 
		public bool Substituida { get; set;} 
		public decimal PrecoLiquidoUnitario { get; set;} 
		public int CodGrupopecaMarca { get; set;} 
		public int LogisticaEntrega { get; set;} 
		public bool DevolCancelada { get; set;} 
		public int IdItempedidoFornecedor { get; set;} 
		public DateTime DevolSolicitacaoData { get; set;} 
		public float? DescontoBase { get; set;} 
		public string MotivoSubstituicao { get; set;} 
		public int MotivoNaofornecimento { get; set;} 
		public bool DevolAutorizada { get; set;} 
		public int DevolCodUsuarioCancelamento { get; set;} 
		public int CodGrupopeca { get; set;} 
		public int DevolCodUsuarioAutorizacao { get; set;} 
		public DateTime DataPrazoInicialCotacao { get; set;} 
		public int Quantidade { get; set;} 
	}
}