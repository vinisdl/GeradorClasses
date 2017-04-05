using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ItenspedidoFornecedoMapper : ClassMapper<ItenspedidoFornecedo>
	{
		public ItenspedidoFornecedoMapper()
		{
			//
			Schema("pecas");
			Table("itenspedido_fornecedores");
		Map(prop => prop.CodNotafiscalDevol).Column("cod_notafiscal_devol");  
		Map(prop => prop.NomeMarca).Column("nome_marca");  
		Map(prop => prop.Desconto).Column("desconto");  
		Map(prop => prop.EnviadaConfirmacaoDevolucao).Column("enviada_confirmacao_devolucao");  
		Map(prop => prop.Prazo).Column("prazo");  
		Map(prop => prop.JustifPrazo).Column("justif_prazo");  
		Map(prop => prop.DataPrazoEntrega).Column("data_prazo_entrega");  
		Map(prop => prop.LogisticaDataEntrega).Column("logistica_data_entrega");  
		Map(prop => prop.DataImpressaoDevolucao).Column("data_impressao_devolucao");  
		Map(prop => prop.DevolMotivo).Column("devol_motivo");  
		Map(prop => prop.DevolSolicitada).Column("devol_solicitada");  
		Map(prop => prop.PrecoBruto).Column("preco_bruto");  
		Map(prop => prop.DevolImpressa).Column("devol_impressa");  
		Map(prop => prop.LogisticaRecolhimento).Column("logistica_recolhimento");  
		Map(prop => prop.CodNotafiscalVenda).Column("cod_notafiscal_venda");  
		Map(prop => prop.DevolMotivoDesc).Column("devol_motivo_desc");  
		Map(prop => prop.Fornece).Column("fornece");  
		Map(prop => prop.PrazoInicialCotacao).Column("prazo_inicial_cotacao");  
		Map(prop => prop.DevolDataAutorizacao).Column("devol_data_autorizacao");  
		Map(prop => prop.DevolDataCancelamento).Column("devol_data_cancelamento");  
		Map(prop => prop.JustificativaNaofornece).Column("justificativa_naofornece");  
		Map(prop => prop.SituacaoFornecimento).Column("situacao_fornecimento");  
		Map(prop => prop.CodPedidofornecedor).Column("cod_pedidofornecedor").Key(KeyType.Identity);  
		Map(prop => prop.Entregue).Column("entregue");  
		Map(prop => prop.LogisticaPrevisao).Column("logistica_previsao");  
		Map(prop => prop.Descricao).Column("descricao");  
		Map(prop => prop.CodLogisticaDevolucao).Column("cod_logistica_devolucao");  
		Map(prop => prop.CodMarcaPeca).Column("cod_marca_peca");  
		Map(prop => prop.Pathnumber).Column("pathnumber");  
		Map(prop => prop.CodMotivoAlteracaoPrazo).Column("cod_motivo_alteracao_prazo");  
		Map(prop => prop.ValorTotalLiquido).Column("valor_total_liquido");  
		Map(prop => prop.CodItempedido).Column("cod_itempedido");  
		Map(prop => prop.Substituida).Column("substituida");  
		Map(prop => prop.PrecoLiquidoUnitario).Column("preco_liquido_unitario");  
		Map(prop => prop.CodGrupopecaMarca).Column("cod_grupopeca_marca");  
		Map(prop => prop.LogisticaEntrega).Column("logistica_entrega");  
		Map(prop => prop.DevolCancelada).Column("devol_cancelada");  
		Map(prop => prop.IdItempedidoFornecedor).Column("id_itempedido_fornecedor");  
		Map(prop => prop.DevolSolicitacaoData).Column("devol_solicitacao_data");  
		Map(prop => prop.DescontoBase).Column("desconto_base");  
		Map(prop => prop.MotivoSubstituicao).Column("motivo_substituicao");  
		Map(prop => prop.MotivoNaofornecimento).Column("motivo_naofornecimento");  
		Map(prop => prop.DevolAutorizada).Column("devol_autorizada");  
		Map(prop => prop.DevolCodUsuarioCancelamento).Column("devol_cod_usuario_cancelamento");  
		Map(prop => prop.CodGrupopeca).Column("cod_grupopeca");  
		Map(prop => prop.DevolCodUsuarioAutorizacao).Column("devol_cod_usuario_autorizacao");  
		Map(prop => prop.DataPrazoInicialCotacao).Column("data_prazo_inicial_cotacao");  
		Map(prop => prop.Quantidade).Column("quantidade");  
			//
		}
	}
}