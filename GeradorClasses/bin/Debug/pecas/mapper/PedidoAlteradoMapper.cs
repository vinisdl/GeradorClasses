using DapperExtensions.Mapper; 
namespace Prismatec{
	public class PedidoAlteradoMapper : ClassMapper<PedidoAlterado>
	{
		public PedidoAlteradoMapper()
		{
			//
			Schema("pecas");
			Table("pedidos_alterados");
		Map(prop => prop.DataAlteracao).Column("data_alteracao");  
		Map(prop => prop.Alteracao).Column("alteracao");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.IdPedidoAlterado).Column("id_pedido_alterado");  
			//
		}
	}
}