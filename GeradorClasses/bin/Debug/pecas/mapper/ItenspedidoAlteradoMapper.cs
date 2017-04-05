using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ItenspedidoAlteradoMapper : ClassMapper<ItenspedidoAlterado>
	{
		public ItenspedidoAlteradoMapper()
		{
			//
			Schema("pecas");
			Table("itenspedido_alterado");
		Map(prop => prop.QuantidadeOriginal).Column("quantidade_original").Key(KeyType.Identity);  
		Map(prop => prop.CodItempedidoFornecedor).Column("cod_itempedido_fornecedor");  
		Map(prop => prop.ValorBrutoUnitarioAtual).Column("valor_bruto_unitario_atual");  
		Map(prop => prop.ValorLiquidoUnitarioOriginal).Column("valor_liquido_unitario_original");  
		Map(prop => prop.ValorLiquidoUnitarioAtual).Column("valor_liquido_unitario_atual");  
		Map(prop => prop.IdItempedidoAlterado).Column("id_itempedido_alterado");  
		Map(prop => prop.CodPedidoAlterado).Column("cod_pedido_alterado");  
		Map(prop => prop.QuantidadeAtual).Column("quantidade_atual");  
		Map(prop => prop.ValorBrutoUnitarioOriginal).Column("valor_bruto_unitario_original");  
		Map(prop => prop.DataCriacao).Column("data_criacao");  
			//
		}
	}
}