using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ItenspedidoSimulacaoMapper : ClassMapper<ItenspedidoSimulacao>
	{
		public ItenspedidoSimulacaoMapper()
		{
			//
			Schema("pecas");
			Table("itenspedido_simulacoes");
		Map(prop => prop.MotivoNaofornecimento).Column("motivo_naofornecimento");  
		Map(prop => prop.CodPedidoSimulacao).Column("cod_pedido_simulacao").Key(KeyType.Identity);  
		Map(prop => prop.CodItempedido).Column("cod_itempedido");  
		Map(prop => prop.CodItempedidoFornecedor).Column("cod_itempedido_fornecedor");  
		Map(prop => prop.IdItempedidoSimulacao).Column("id_itempedido_simulacao");  
			//
		}
	}
}