using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ClienteReguladoraMapper : ClassMapper<ClienteReguladora>
	{
		public ClienteReguladoraMapper()
		{
			//
			Schema("pecas");
			Table("clientes_reguladoras");
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.IdClienteReguladora).Column("id_cliente_reguladora").Key(KeyType.Identity);  
		Map(prop => prop.CodReguladora).Column("cod_reguladora");  
			//
		}
	}
}