using System;
using System.Data;

namespace Prismatec
{
	/// <summary>
	/// Classe gerada para a tabela : pedidos.
	/// </summary>
	public class Pedido
	{
		public Pedido()
		{
			//
			// TODO: Logica do construtor
			//
		}
		public DateTime CancelamentoData { get; set;} 
		public bool FinalizadoOficina { get; set;} 
		public decimal TotalAutorizado { get; set;} 
		public decimal CustoLiberadoOficina { get; set;} 
		public DateTime DataFornecedorConfirmouEntrega { get; set;} 
		public int CodSinistro { get; set;} 
		public int QuantidadeAlteracaoPrazo { get; set;} 
		public bool TrocaOficina { get; set;} 
		public bool FornecedorConfirmouEntrega { get; set;} 
		public int AutorizacaoTipo { get; set;} 
		public decimal CustoPintura { get; set;} 
		public int CriacaoCodUsuario { get; set;} 
		public bool OficinaParticularEmissaoPagamento { get; set;} 
		public string Audatex14Identificador { get; set;} 
		public bool ClienteCiente { get; set;} 
		public DateTime LogisticaDataReabertura { get; set;} 
		public decimal CustoEletrica { get; set;} 
		public bool EmAtraso { get; set;} 
		public DateTime CriacaoData { get; set;} 
		public int IdPedido { get; set;} 
		public decimal CustoMecanica { get; set;} 
		public bool PagamentoRealizado { get; set;} 
		public bool DistribuidorSelecionado { get; set;} 
		public DateTime DataAlteracao { get; set;} 
		public DateTime DataEnvioTrocaOficina { get; set;} 
		public decimal CustoTerceiro { get; set;} 
		public bool Audatex14Disponivel { get; set;} 
		public int CodSituacaoVeiculo { get; set;} 
		public bool PossuiBo { get; set;} 
		public decimal CustoFunilaria { get; set;} 
		public DateTime DataEnvioSimulacao { get; set;} 
		public int SequencialAllianz { get; set;} 
		public bool Reativacao { get; set;} 
		public bool EnviarCotacaoOficinaParticula { get; set;} 
		public bool OficinaCiente { get; set;} 
		public int StatuPedidoMobile { get; set;} 
		public int CodVeiculo { get; set;} 
		public bool AutorizacaoLiberada { get; set;} 
		public DateTime Audatex14DataConfirmacaoenvio { get; set;} 
		public DateTime LogisticaNovoContato { get; set;} 
		public DateTime LogisticaDataEncerramento { get; set;} 
		public decimal CustoTapecaria { get; set;} 
		public DateTime DataAtuacaoOficina { get; set;} 
		public DateTime DataSolicitacaoPedidoIntegracao { get; set;} 
		public DateTime DataRecebimento { get; set;} 
		public int CodOficina { get; set;} 
		public bool OficinaConfirmaEntrega { get; set;} 
		public DateTime DataCotacaoAutorizadaOficinaParticular { get; set;} 
		public DateTime DataEnvioCotacaoOficinaParticula { get; set;} 
		public int StatuAutorizacao { get; set;} 
		public bool AcionouCacaPeca { get; set;} 
		public string LogisticaPessoaContato { get; set;} 
		public string TokenCotacaoOficinaParticula { get; set;} 
		public bool DisponivelCnf { get; set;} 
		public int CodVistoria { get; set;} 
		public DateTime DataPagamentoRealizado { get; set;} 
		public int CancelamentoCodUsuario { get; set;} 
		public decimal CustoPecaLiquido { get; set;} 
		public bool FornecedoSelecionado { get; set;} 
		public int CodMotivoCancelamento { get; set;} 
		public decimal CustoPecaBruto { get; set;} 
		public DateTime DataQuestionamentoEntrega { get; set;} 
		public DateTime DataInicioCotacao { get; set;} 
		public bool SimulacaoAutomatica { get; set;} 
		public string JustificativaAutorizacao { get; set;} 
		public bool AutorizacaoAutomatica { get; set;} 
		public DateTime DataEnvioEntrega { get; set;} 
		public bool Cancelado { get; set;} 
		public int LogisticaEncerramentoCodUsuario { get; set;} 
		public float? CustoPecaDesconto { get; set;} 
		public int StatuNegociacaoOficina { get; set;} 
		public DateTime DataOficinaConfirmaEntrega { get; set;} 
		public int CodImportacao { get; set;} 
		public string Numero { get; set;} 
		public bool Alterado { get; set;} 
		public bool ClienteCientePrazo { get; set;} 
	}
}