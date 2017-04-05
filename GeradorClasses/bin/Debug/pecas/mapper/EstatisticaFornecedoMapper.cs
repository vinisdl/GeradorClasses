using DapperExtensions.Mapper; 
namespace Prismatec{
	public class EstatisticaFornecedoMapper : ClassMapper<EstatisticaFornecedo>
	{
		public EstatisticaFornecedoMapper()
		{
			//
			Schema("pecas");
			Table("estatisticas_fornecedores");
		Map(prop => prop.PedidoPrazoAlterado).Column("pedidos_prazo_alterado").Key(KeyType.Identity);  
		Map(prop => prop.PedidoReagendadoReagendado).Column("pedidos_reagendados_reagendados");  
		Map(prop => prop.PedidoReagendado).Column("pedidos_reagendados");  
		Map(prop => prop.IdEstatisticaFornecedor).Column("id_estatistica_fornecedor");  
		Map(prop => prop.DadoSemanaFinalizado).Column("dados_semana_finalizados");  
		Map(prop => prop.PedidoRecebido).Column("pedidos_recebidos");  
		Map(prop => prop.PedidoEntreguePrazo).Column("pedidos_entregues_prazo");  
		Map(prop => prop.PedidoNaoCotato).Column("pedidos_nao_cotatos");  
		Map(prop => prop.PedidoPrevisto).Column("pedidos_previstos");  
		Map(prop => prop.PedidoDevolucaoAberto).Column("pedidos_devolucao_aberto");  
		Map(prop => prop.QuantidadeAtualizacao).Column("quantidade_atualizacoes");  
		Map(prop => prop.PedidoCotado).Column("pedidos_cotados");  
		Map(prop => prop.DataUltimaAtualizacao).Column("data_ultima_atualizacao");  
		Map(prop => prop.PedidoEntregueForaPrazo).Column("pedidos_entregues_fora_prazo");  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
		Map(prop => prop.Semana).Column("semana");  
		Map(prop => prop.PedidoAutorizado).Column("pedidos_autorizados");  
			//
		}
	}
}