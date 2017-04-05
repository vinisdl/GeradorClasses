using DapperExtensions.Mapper; 
namespace Prismatec{
	public class PedidoNotificacaoMobileMapper : ClassMapper<PedidoNotificacaoMobile>
	{
		public PedidoNotificacaoMobileMapper()
		{
			//
			Schema("pecas");
			Table("pedidos_notificacoes_mobile");
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.IdPedidoNotificacao).Column("id_pedido_notificacao");  
		Map(prop => prop.Origem).Column("origem");  
		Map(prop => prop.DataVisualizado).Column("data_visualizado");  
		Map(prop => prop.CodObservacao).Column("cod_observacao");  
		Map(prop => prop.ClienteVisualiza).Column("cliente_visualiza");  
		Map(prop => prop.Visualizado).Column("visualizado");  
			//
		}
	}
}