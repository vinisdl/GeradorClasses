using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AuxiliaCompraEstadoMapper : ClassMapper<AuxiliaCompraEstado>
	{
		public AuxiliaCompraEstadoMapper()
		{
			//
			Schema("pecas");
			Table("auxiliares_compra_estados");
		Map(prop => prop.CodEstado).Column("cod_estado");  
		Map(prop => prop.IdAuxiliarCompraEstado).Column("id_auxiliar_compra_estado").Key(KeyType.Identity);  
		Map(prop => prop.CodAuxiliarCompra).Column("cod_auxiliar_compra");  
			//
		}
	}
}