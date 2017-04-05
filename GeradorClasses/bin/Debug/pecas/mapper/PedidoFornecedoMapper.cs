using DapperExtensions.Mapper; 
namespace Prismatec{
	public class PedidoFornecedoMapper : ClassMapper<PedidoFornecedo>
	{
		public PedidoFornecedoMapper()
		{
			//
			Schema("pecas");
			Table("pedidos_fornecedores");
		Map(prop => prop.IdPedidoFornecedor).Column("id_pedido_fornecedor").Key(KeyType.Identity);  
		Map(prop => prop.DataQuestionamentoAutomatico).Column("data_questionamento_automatico");  
		Map(prop => prop.DataFimCotacao).Column("data_fim_cotacao");  
		Map(prop => prop.DentroPrazo).Column("dentro_prazo");  
		Map(prop => prop.NomePessoaOficina).Column("nome_pessoa_oficina");  
		Map(prop => prop.DataEntregaLogistica).Column("data_entrega_logistica");  
		Map(prop => prop.OrdemServico).Column("ordem_servico");  
		Map(prop => prop.CodPedido).Column("cod_pedido");  
		Map(prop => prop.DataPedidofiscal).Column("data_pedidofiscal");  
		Map(prop => prop.EntregueNoPrazo).Column("entregue_no_prazo");  
		Map(prop => prop.DataEntregaJustificativa).Column("data_entrega_justificativa");  
		Map(prop => prop.DataEnvioNotificacaoPrazo1).Column("data_envio_notificacao_prazo_1");  
		Map(prop => prop.Distancia).Column("distancia");  
		Map(prop => prop.CodUsuarioPedidofiscal).Column("cod_usuario_pedidofiscal");  
		Map(prop => prop.CodMotivoAtraso).Column("cod_motivo_atraso");  
		Map(prop => prop.DataSolDevolucao).Column("data_sol_devolucao");  
		Map(prop => prop.DataEnvioFinalizacao).Column("data_envio_finalizacao");  
		Map(prop => prop.Entregue).Column("entregue");  
		Map(prop => prop.NumeroPedidoOrion).Column("numero_pedido_orion");  
		Map(prop => prop.EnviarNotificacaoPrazo1).Column("enviar_notificacao_prazo_1");  
		Map(prop => prop.DataAlteracaoPrazo).Column("data_alteracao_prazo");  
		Map(prop => prop.DataInicioCotacao).Column("data_inicio_cotacao");  
		Map(prop => prop.PossuiDepara).Column("possui_depara");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.CodOrigemProblema).Column("cod_origem_problema");  
		Map(prop => prop.DescontoEspecifico).Column("desconto_especifico");  
		Map(prop => prop.JustificativaAtraso).Column("justificativa_atraso");  
		Map(prop => prop.DataImpressao).Column("data_impressao");  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
		Map(prop => prop.DataAutorizacao).Column("data_autorizacao");  
		Map(prop => prop.RemoverRelatorioItensautorizado).Column("remover_relatorio_itensautorizados");  
		Map(prop => prop.CodTipoPeca).Column("cod_tipo_peca");  
		Map(prop => prop.CodConciliacao).Column("cod_conciliacao");  
			//
		}
	}
}