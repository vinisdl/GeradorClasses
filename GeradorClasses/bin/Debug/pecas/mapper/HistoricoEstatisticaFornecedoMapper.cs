using DapperExtensions.Mapper; 
namespace Prismatec{
	public class HistoricoEstatisticaFornecedoMapper : ClassMapper<HistoricoEstatisticaFornecedo>
	{
		public HistoricoEstatisticaFornecedoMapper()
		{
			//
			Schema("pecas");
			Table("historico_estatisticas_fornecedores");
		Map(prop => prop.PedidoReagendadoReagendado).Column("pedidos_reagendados_reagendados").Key(KeyType.Identity);  
		Map(prop => prop.PedidoPrevisto).Column("pedidos_previstos");  
		Map(prop => prop.PedidoNaoCotado).Column("pedidos_nao_cotados");  
		Map(prop => prop.PedidoReagendado).Column("pedidos_reagendados");  
		Map(prop => prop.PedidoRecebido).Column("pedidos_recebidos");  
		Map(prop => prop.PedidoEntreguePrazo).Column("pedidos_entregues_prazo");  
		Map(prop => prop.PedidoDevolucaoAberto).Column("pedidos_devolucao_aberto");  
		Map(prop => prop.DataReferencia).Column("data_referencia");  
		Map(prop => prop.PedidoCotado).Column("pedidos_cotados");  
		Map(prop => prop.PedidoEntregueForaPrazo).Column("pedidos_entregues_fora_prazo");  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
		Map(prop => prop.IdHistoricoEstatisticaFornecedor).Column("id_historico_estatistica_fornecedor");  
		Map(prop => prop.PedidoPrazoAlterado).Column("pedidos_prazo_alterado");  
		Map(prop => prop.PedidoAutorizado).Column("pedidos_autorizados");  
			//
		}
	}
}