using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AuxiliaCompraClienteMapper : ClassMapper<AuxiliaCompraCliente>
	{
		public AuxiliaCompraClienteMapper()
		{
			//
			Schema("pecas");
			Table("auxiliares_compra_clientes");
		Map(prop => prop.IdAuxiliarCompraCliente).Column("id_auxiliar_compra_cliente").Key(KeyType.Identity);  
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.CodAuxiliarCompra).Column("cod_auxiliar_compra");  
			//
		}
	}
}