using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ItemPedidoReativacaoMapper : ClassMapper<ItemPedidoReativacao>
	{
		public ItemPedidoReativacaoMapper()
		{
			//
			Schema("pecas");
			Table("itens_pedido_reativacao");
		Map(prop => prop.CodReativacaoPedido).Column("cod_reativacao_pedido").Key(KeyType.Identity);  
		Map(prop => prop.CodItempedido).Column("cod_itempedido");  
		Map(prop => prop.IdItemPedidoReativacao).Column("id_item_pedido_reativacao");  
			//
		}
	}
}