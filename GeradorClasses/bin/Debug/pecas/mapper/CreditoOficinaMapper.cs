using DapperExtensions.Mapper; 
namespace Prismatec{
	public class CreditoOficinaMapper : ClassMapper<CreditoOficina>
	{
		public CreditoOficinaMapper()
		{
			//
			Schema("pecas");
			Table("credito_oficina");
		Map(prop => prop.DataConfirmacaoCredito).Column("data_confirmacao_credito");  
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.DataCancelamento).Column("data_cancelamento");  
		Map(prop => prop.Cancelado).Column("cancelado");  
		Map(prop => prop.CodUsuarioConfirmacao).Column("cod_usuario_confirmacao");  
		Map(prop => prop.IdCreditoOficina).Column("id_credito_oficina");  
		Map(prop => prop.MotivoCreditoCancelamento).Column("motivo_credito_cancelamento");  
		Map(prop => prop.CreditoUtilizado).Column("credito_utilizado");  
		Map(prop => prop.DataCreditoUtilizado).Column("data_credito_utilizado");  
		Map(prop => prop.Credito).Column("credito");  
		Map(prop => prop.DataCriacao).Column("data_criacao");  
			//
		}
	}
}