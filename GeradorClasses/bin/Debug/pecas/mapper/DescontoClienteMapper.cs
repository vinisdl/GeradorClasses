using DapperExtensions.Mapper; 
namespace Prismatec{
	public class DescontoClienteMapper : ClassMapper<DescontoCliente>
	{
		public DescontoClienteMapper()
		{
			//
			Schema("pecas");
			Table("descontos_clientes");
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.CodMarca).Column("cod_marca");  
		Map(prop => prop.Desconto).Column("desconto");  
		Map(prop => prop.IdDescontoCliente).Column("id_desconto_cliente").Key(KeyType.Identity);  
		Map(prop => prop.CodEstado).Column("cod_estado");  
			//
		}
	}
}