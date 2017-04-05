using DapperExtensions.Mapper; 
namespace Prismatec{
	public class PedidoMapper : ClassMapper<Pedido>
	{
		public PedidoMapper()
		{
			//
			Schema("pecas");
			Table("pedidos");
		Map(prop => prop.CancelamentoData).Column("cancelamento_data");  
		Map(prop => prop.FinalizadoOficina).Column("finalizado_oficina");  
		Map(prop => prop.TotalAutorizado).Column("total_autorizado");  
		Map(prop => prop.CustoLiberadoOficina).Column("custo_liberado_oficina");  
		Map(prop => prop.DataFornecedorConfirmouEntrega).Column("data_fornecedor_confirmou_entrega");  
		Map(prop => prop.CodSinistro).Column("cod_sinistro");  
		Map(prop => prop.QuantidadeAlteracaoPrazo).Column("quantidade_alteracao_prazo").Key(KeyType.Identity);  
		Map(prop => prop.TrocaOficina).Column("troca_oficina");  
		Map(prop => prop.FornecedorConfirmouEntrega).Column("fornecedor_confirmou_entrega");  
		Map(prop => prop.AutorizacaoTipo).Column("autorizacao_tipo");  
		Map(prop => prop.CustoPintura).Column("custo_pintura");  
		Map(prop => prop.CriacaoCodUsuario).Column("criacao_cod_usuario");  
		Map(prop => prop.OficinaParticularEmissaoPagamento).Column("oficina_particular_emissao_pagamento");  
		Map(prop => prop.Audatex14Identificador).Column("audatex14_identificador");  
		Map(prop => prop.ClienteCiente).Column("cliente_ciente");  
		Map(prop => prop.LogisticaDataReabertura).Column("logistica_data_reabertura");  
		Map(prop => prop.CustoEletrica).Column("custo_eletrica");  
		Map(prop => prop.EmAtraso).Column("em_atraso");  
		Map(prop => prop.CriacaoData).Column("criacao_data");  
		Map(prop => prop.IdPedido).Column("id_pedido");  
		Map(prop => prop.CustoMecanica).Column("custo_mecanica");  
		Map(prop => prop.PagamentoRealizado).Column("pagamento_realizado");  
		Map(prop => prop.DistribuidorSelecionado).Column("distribuidor_selecionado");  
		Map(prop => prop.DataAlteracao).Column("data_alteracao");  
		Map(prop => prop.DataEnvioTrocaOficina).Column("data_envio_troca_oficina");  
		Map(prop => prop.CustoTerceiro).Column("custo_terceiros");  
		Map(prop => prop.Audatex14Disponivel).Column("audatex14_disponivel");  
		Map(prop => prop.CodSituacaoVeiculo).Column("cod_situacao_veiculo");  
		Map(prop => prop.PossuiBo).Column("possui_bo");  
		Map(prop => prop.CustoFunilaria).Column("custo_funilaria");  
		Map(prop => prop.DataEnvioSimulacao).Column("data_envio_simulacao");  
		Map(prop => prop.SequencialAllianz).Column("sequencial_allianz");  
		Map(prop => prop.Reativacao).Column("reativacao");  
		Map(prop => prop.EnviarCotacaoOficinaParticula).Column("enviar_cotacoes_oficinas_particulares");  
		Map(prop => prop.OficinaCiente).Column("oficina_ciente");  
		Map(prop => prop.StatuPedidoMobile).Column("status_pedido_mobile");  
		Map(prop => prop.CodVeiculo).Column("cod_veiculo");  
		Map(prop => prop.AutorizacaoLiberada).Column("autorizacao_liberada");  
		Map(prop => prop.Audatex14DataConfirmacaoenvio).Column("audatex14_data_confirmacaoenvio");  
		Map(prop => prop.LogisticaNovoContato).Column("logistica_novo_contato");  
		Map(prop => prop.LogisticaDataEncerramento).Column("logistica_data_encerramento");  
		Map(prop => prop.CustoTapecaria).Column("custo_tapecaria");  
		Map(prop => prop.DataAtuacaoOficina).Column("data_atuacao_oficina");  
		Map(prop => prop.DataSolicitacaoPedidoIntegracao).Column("data_solicitacao_pedido_integracao");  
		Map(prop => prop.DataRecebimento).Column("data_recebimento");  
		Map(prop => prop.CodOficina).Column("cod_oficina");  
		Map(prop => prop.OficinaConfirmaEntrega).Column("oficina_confirma_entrega");  
		Map(prop => prop.DataCotacaoAutorizadaOficinaParticular).Column("data_cotacao_autorizada_oficina_particular");  
		Map(prop => prop.DataEnvioCotacaoOficinaParticula).Column("data_envio_cotacoes_oficinas_particulares");  
		Map(prop => prop.StatuAutorizacao).Column("status_autorizacao");  
		Map(prop => prop.AcionouCacaPeca).Column("acionou_caca_pecas");  
		Map(prop => prop.LogisticaPessoaContato).Column("logistica_pessoa_contato");  
		Map(prop => prop.TokenCotacaoOficinaParticula).Column("token_cotacoes_oficinas_particulares");  
		Map(prop => prop.DisponivelCnf).Column("disponivel_cnf");  
		Map(prop => prop.CodVistoria).Column("cod_vistoria");  
		Map(prop => prop.DataPagamentoRealizado).Column("data_pagamento_realizado");  
		Map(prop => prop.CancelamentoCodUsuario).Column("cancelamento_cod_usuario");  
		Map(prop => prop.CustoPecaLiquido).Column("custo_pecas_liquido");  
		Map(prop => prop.FornecedoSelecionado).Column("fornecedores_selecionados");  
		Map(prop => prop.CodMotivoCancelamento).Column("cod_motivo_cancelamento");  
		Map(prop => prop.CustoPecaBruto).Column("custo_pecas_bruto");  
		Map(prop => prop.DataQuestionamentoEntrega).Column("data_questionamento_entrega");  
		Map(prop => prop.DataInicioCotacao).Column("data_inicio_cotacao");  
		Map(prop => prop.SimulacaoAutomatica).Column("simulacao_automatica");  
		Map(prop => prop.JustificativaAutorizacao).Column("justificativa_autorizacao");  
		Map(prop => prop.AutorizacaoAutomatica).Column("autorizacao_automatica");  
		Map(prop => prop.DataEnvioEntrega).Column("data_envio_entrega");  
		Map(prop => prop.Cancelado).Column("cancelado");  
		Map(prop => prop.LogisticaEncerramentoCodUsuario).Column("logistica_encerramento_cod_usuario");  
		Map(prop => prop.CustoPecaDesconto).Column("custo_pecas_desconto");  
		Map(prop => prop.StatuNegociacaoOficina).Column("status_negociacao_oficina");  
		Map(prop => prop.DataOficinaConfirmaEntrega).Column("data_oficina_confirma_entrega");  
		Map(prop => prop.CodImportacao).Column("cod_importacao");  
		Map(prop => prop.Numero).Column("numero");  
		Map(prop => prop.Alterado).Column("alterado");  
		Map(prop => prop.ClienteCientePrazo).Column("cliente_ciente_prazo");  
			//
		}
	}
}