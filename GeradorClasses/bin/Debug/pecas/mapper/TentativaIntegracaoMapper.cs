using DapperExtensions.Mapper; 
namespace Prismatec{
	public class TentativaIntegracaoMapper : ClassMapper<TentativaIntegracao>
	{
		public TentativaIntegracaoMapper()
		{
			//
			Schema("pecas");
			Table("tentativas_integracao");
		Map(prop => prop.DataEnvio).Column("data_envio");  
		Map(prop => prop.Retorno).Column("retorno");  
		Map(prop => prop.Tentativa).Column("tentativas");  
		Map(prop => prop.IdTentativa).Column("id_tentativa").Key(KeyType.Identity);  
		Map(prop => prop.CodPedidoFornecedor).Column("cod_pedido_fornecedor");  
			//
		}
	}
}