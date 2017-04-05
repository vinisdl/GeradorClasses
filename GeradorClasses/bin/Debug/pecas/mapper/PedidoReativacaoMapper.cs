using DapperExtensions.Mapper; 
namespace Prismatec{
	public class PedidoReativacaoMapper : ClassMapper<PedidoReativacao>
	{
		public PedidoReativacaoMapper()
		{
			//
			Schema("pecas");
			Table("pedidos_reativacao");
		Map(prop => prop.DataCancelamento).Column("data_cancelamento");  
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.Cancelada).Column("cancelada");  
		Map(prop => prop.DataReativacao).Column("data_reativacao");  
		Map(prop => prop.Motivo).Column("motivo");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.TipoReativacao).Column("tipo_reativacao");  
		Map(prop => prop.IdPedidoReativacao).Column("id_pedido_reativacao");  
		Map(prop => prop.DataCriacao).Column("data_criacao");  
			//
		}
	}
}