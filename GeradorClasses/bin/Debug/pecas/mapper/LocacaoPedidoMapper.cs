using DapperExtensions.Mapper; 
namespace Prismatec{
	public class LocacaoPedidoMapper : ClassMapper<LocacaoPedido>
	{
		public LocacaoPedidoMapper()
		{
			//
			Schema("pecas");
			Table("locacoes_pedidos");
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.IdLocacaoPedido).Column("id_locacao_pedido");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
			//
		}
	}
}