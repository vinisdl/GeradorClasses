using DapperExtensions.Mapper; 
namespace Prismatec{
	public class EstatisticaFornecedoPedidoFornecedoMapper : ClassMapper<EstatisticaFornecedoPedidoFornecedo>
	{
		public EstatisticaFornecedoPedidoFornecedoMapper()
		{
			//
			Schema("pecas");
			Table("estatisticas_fornecedores_pedidos_fornecedores");
		Map(prop => prop.CodPedidoFornecedor).Column("cod_pedido_fornecedor").Key(KeyType.Identity);  
		Map(prop => prop.CodEstatisticaFornecedor).Column("cod_estatistica_fornecedor");  
		Map(prop => prop.IdEstatisticaFornecedorPedidoFornecedor).Column("id_estatistica_fornecedor_pedido_fornecedor");  
		Map(prop => prop.TipoEstatistica).Column("tipo_estatistica");  
			//
		}
	}
}