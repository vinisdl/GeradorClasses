using DapperExtensions.Mapper; 
namespace Prismatec{
	public class RegistroAuditoriaMapper : ClassMapper<RegistroAuditoria>
	{
		public RegistroAuditoriaMapper()
		{
			//
			Schema("pecas");
			Table("registros_auditoria");
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.Acao).Column("acao");  
		Map(prop => prop.Finalizado).Column("finalizado");  
		Map(prop => prop.IdRegistroAuditoria).Column("id_registro_auditoria");  
		Map(prop => prop.Statu).Column("status");  
		Map(prop => prop.ItemPendente).Column("itens_pendentes");  
			//
		}
	}
}