using DapperExtensions.Mapper; 
namespace Prismatec{
	public class PedidoCompraOficinaMapper : ClassMapper<PedidoCompraOficina>
	{
		public PedidoCompraOficinaMapper()
		{
			//
			Schema("pecas");
			Table("pedidos_compras_oficinas");
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.IdPedidoCompraOficina).Column("id_pedido_compra_oficina");  
		Map(prop => prop.DataVencimento).Column("data_vencimento");  
		Map(prop => prop.FormaPagamento).Column("forma_pagamento");  
		Map(prop => prop.Bandeira).Column("bandeira");  
		Map(prop => prop.Valor).Column("valor");  
		Map(prop => prop.DataPagamento).Column("data_pagamento");  
		Map(prop => prop.Parcela).Column("parcelas");  
			//
		}
	}
}