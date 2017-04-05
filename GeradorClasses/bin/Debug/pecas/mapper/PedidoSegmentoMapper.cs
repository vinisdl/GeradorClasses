using DapperExtensions.Mapper; 
namespace Prismatec{
	public class PedidoSegmentoMapper : ClassMapper<PedidoSegmento>
	{
		public PedidoSegmentoMapper()
		{
			//
			Schema("pecas");
			Table("pedidos_segmentos");
		Map(prop => prop.IdPedidoSegmento).Column("id_pedido_segmento").Key(KeyType.Identity);  
		Map(prop => prop.CodPedido).Column("cod_pedido");  
		Map(prop => prop.CodSegmento).Column("cod_segmento");  
			//
		}
	}
}