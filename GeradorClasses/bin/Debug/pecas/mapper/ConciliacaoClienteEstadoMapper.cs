using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ConciliacaoClienteEstadoMapper : ClassMapper<ConciliacaoClienteEstado>
	{
		public ConciliacaoClienteEstadoMapper()
		{
			//
			Schema("pecas");
			Table("conciliacao_cliente_estado");
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.IdConciliacaoClienteEstado).Column("id_conciliacao_cliente_estado").Key(KeyType.Identity);  
		Map(prop => prop.CodEstado).Column("cod_estado");  
			//
		}
	}
}