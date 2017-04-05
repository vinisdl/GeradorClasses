using DapperExtensions.Mapper; 
namespace Prismatec{
	public class PedidoSimulacaoMapper : ClassMapper<PedidoSimulacao>
	{
		public PedidoSimulacaoMapper()
		{
			//
			Schema("pecas");
			Table("pedidos_simulacoes");
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.IdPedidoSimulacao).Column("id_pedido_simulacao");  
		Map(prop => prop.SimulacaoAceita).Column("simulacao_aceita");  
		Map(prop => prop.IntegracaoEnviada).Column("integracao_enviada");  
		Map(prop => prop.Enviada).Column("enviada");  
		Map(prop => prop.DataSimulacao).Column("data_simulacao");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.Numero).Column("numero");  
		Map(prop => prop.CotacaoAutorizadaOficinaParticular).Column("cotacao_autorizada_oficina_particular");  
		Map(prop => prop.DataSimulacaoAceita).Column("data_simulacao_aceita");  
		Map(prop => prop.DataCriacao).Column("data_criacao");  
			//
		}
	}
}