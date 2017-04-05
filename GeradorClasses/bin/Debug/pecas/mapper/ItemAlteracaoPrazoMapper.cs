using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ItemAlteracaoPrazoMapper : ClassMapper<ItemAlteracaoPrazo>
	{
		public ItemAlteracaoPrazoMapper()
		{
			//
			Schema("pecas");
			Table("itens_alteracoes_prazos");
		Map(prop => prop.DataNovaEntrega).Column("data_nova_entrega");  
		Map(prop => prop.CodMotivoAlteracaoPrazo).Column("cod_motivo_alteracao_prazo");  
		Map(prop => prop.IdItemAlteracaoPrazo).Column("id_item_alteracao_prazo").Key(KeyType.Identity);  
		Map(prop => prop.CodItempedidoFornecedor).Column("cod_itempedido_fornecedor");  
		Map(prop => prop.CodAlteracaoPrazo).Column("cod_alteracao_prazo");  
			//
		}
	}
}