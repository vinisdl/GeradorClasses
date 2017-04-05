using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ItenspedidoMapper : ClassMapper<Itenspedido>
	{
		public ItenspedidoMapper()
		{
			//
			Schema("pecas");
			Table("itenspedido");
		Map(prop => prop.Statu).Column("status");  
		Map(prop => prop.CancelamentoCodUsuario).Column("cancelamento_cod_usuario");  
		Map(prop => prop.AutorizacaoCodItempedidoFornecedor).Column("autorizacao_cod_itempedido_fornecedor").Key(KeyType.Identity);  
		Map(prop => prop.Autorizado).Column("autorizado");  
		Map(prop => prop.CodPedido).Column("cod_pedido");  
		Map(prop => prop.StatuItemOficina).Column("status_item_oficina");  
		Map(prop => prop.CataPecaLocalizado).Column("cata_peca_localizado");  
		Map(prop => prop.DataEnvioFinalizacao).Column("data_envio_finalizacao");  
		Map(prop => prop.CodUsuarioSolicitacaoCataPeca).Column("cod_usuario_solicitacao_cata_peca");  
		Map(prop => prop.CodSegmento).Column("cod_segmento");  
		Map(prop => prop.SemPrevisao).Column("sem_previsao");  
		Map(prop => prop.CodMotivoSolicitacaoDevolucao).Column("cod_motivo_solicitacao_devolucao");  
		Map(prop => prop.CodReferenciaItemportal).Column("cod_referencia_itemportal");  
		Map(prop => prop.CodGrupo).Column("cod_grupo");  
		Map(prop => prop.DataEnvioCancelamento).Column("data_envio_cancelamento");  
		Map(prop => prop.Pathnumber).Column("pathnumber");  
		Map(prop => prop.Valorlista).Column("valorlista");  
		Map(prop => prop.Idpec).Column("idpec");  
		Map(prop => prop.IdItempedido).Column("id_itempedido");  
		Map(prop => prop.Descricao).Column("descricao");  
		Map(prop => prop.RetornoCataPeca).Column("retorno_cata_peca");  
		Map(prop => prop.ItemEmBo).Column("item_em_bo");  
		Map(prop => prop.CodMotivoCancelamento).Column("cod_motivo_cancelamento");  
		Map(prop => prop.Cancelado).Column("cancelado");  
		Map(prop => prop.VlrOficina).Column("vlr_oficina");  
		Map(prop => prop.CataPecaFinalizado).Column("cata_peca_finalizado");  
		Map(prop => prop.DataSolicitacaoCataPeca).Column("data_solicitacao_cata_pecas");  
		Map(prop => prop.PathnumberAlternativo).Column("pathnumber_alternativo");  
		Map(prop => prop.CancelamentoSolicitado).Column("cancelamento_solicitado");  
		Map(prop => prop.CataPecaAcionado).Column("cata_pecas_acionado");  
		Map(prop => prop.AutorizacaoCodUsuario).Column("autorizacao_cod_usuario");  
		Map(prop => prop.Audatex14Identificador).Column("audatex14_identificador");  
		Map(prop => prop.DataFinalizacaoCataPeca).Column("data_finalizacao_cata_pecas");  
		Map(prop => prop.QuantidadeTrocar).Column("quantidade_trocar");  
		Map(prop => prop.CancelamentoData).Column("cancelamento_data");  
		Map(prop => prop.Quantidade).Column("quantidade");  
			//
		}
	}
}