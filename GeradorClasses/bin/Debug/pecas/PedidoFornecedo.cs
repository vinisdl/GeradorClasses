using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : pedidos_fornecedores.
	/// </summary>
	public class PedidoFornecedo
	{
		public PedidoFornecedo()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public int IdPedidoFornecedor { get; set;} 
		public DateTime DataQuestionamentoAutomatico { get; set;} 
		public DateTime DataFimCotacao { get; set;} 
		public bool DentroPrazo { get; set;} 
		public string NomePessoaOficina { get; set;} 
		public DateTime DataEntregaLogistica { get; set;} 
		public string OrdemServico { get; set;} 
		public int CodPedido { get; set;} 
		public DateTime DataPedidofiscal { get; set;} 
		public bool EntregueNoPrazo { get; set;} 
		public DateTime DataEntregaJustificativa { get; set;} 
		public DateTime DataEnvioNotificacaoPrazo1 { get; set;} 
		public double Distancia { get; set;} 
		public int CodUsuarioPedidofiscal { get; set;} 
		public int CodMotivoAtraso { get; set;} 
		public DateTime DataSolDevolucao { get; set;} 
		public DateTime DataEnvioFinalizacao { get; set;} 
		public bool Entregue { get; set;} 
		public string NumeroPedidoOrion { get; set;} 
		public bool EnviarNotificacaoPrazo1 { get; set;} 
		public DateTime DataAlteracaoPrazo { get; set;} 
		public DateTime DataInicioCotacao { get; set;} 
		public bool PossuiDepara { get; set;} 
		public bool Ativo { get; set;} 
		public int CodOrigemProblema { get; set;} 
		public bool DescontoEspecifico { get; set;} 
		public string JustificativaAtraso { get; set;} 
		public DateTime DataImpressao { get; set;} 
		public int CodFornecedor { get; set;} 
		public DateTime DataAutorizacao { get; set;} 
		public bool RemoverRelatorioItensautorizado { get; set;} 
		public int CodTipoPeca { get; set;} 
		public int CodConciliacao { get; set;} 
	}
}