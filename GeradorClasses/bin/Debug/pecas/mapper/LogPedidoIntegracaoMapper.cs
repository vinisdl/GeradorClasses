using DapperExtensions.Mapper; 
namespace Prismatec{
	public class LogPedidoIntegracaoMapper : ClassMapper<LogPedidoIntegracao>
	{
		public LogPedidoIntegracaoMapper()
		{
			//
			Schema("pecas");
			Table("log_pedidos_integracao");
		Map(prop => prop.Mensagem).Column("mensagem");  
		Map(prop => prop.DataEnvio).Column("data_envio");  
		Map(prop => prop.Tipo).Column("tipo");  
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.IdLogPedido).Column("id_log_pedido");  
			//
		}
	}
}