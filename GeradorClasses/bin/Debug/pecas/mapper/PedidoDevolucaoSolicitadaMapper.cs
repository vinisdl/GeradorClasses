using DapperExtensions.Mapper; 
namespace Prismatec{
	public class PedidoDevolucaoSolicitadaMapper : ClassMapper<PedidoDevolucaoSolicitada>
	{
		public PedidoDevolucaoSolicitadaMapper()
		{
			//
			Schema("pecas");
			Table("pedido_devolucao_solicitada");
		Map(prop => prop.CriacaoCodUsuario).Column("criacao_cod_usuario");  
		Map(prop => prop.IdDevolucaoSolicitada).Column("id_devolucao_solicitada").Key(KeyType.Identity);  
		Map(prop => prop.DataCriacao).Column("data_criacao");  
		Map(prop => prop.CodPedido).Column("cod_pedido");  
		Map(prop => prop.DataEnvioDevolucao).Column("data_envio_devolucao");  
			//
		}
	}
}