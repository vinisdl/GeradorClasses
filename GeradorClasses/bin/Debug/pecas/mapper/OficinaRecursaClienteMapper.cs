using DapperExtensions.Mapper; 
namespace Prismatec{
	public class OficinaRecursaClienteMapper : ClassMapper<OficinaRecursaCliente>
	{
		public OficinaRecursaClienteMapper()
		{
			//
			Schema("pecas");
			Table("oficina_recursa_clientes");
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.IdOficinaRecusaCliente).Column("id_oficina_recusa_cliente").Key(KeyType.Identity);  
		Map(prop => prop.CodOficina).Column("cod_oficina");  
			//
		}
	}
}