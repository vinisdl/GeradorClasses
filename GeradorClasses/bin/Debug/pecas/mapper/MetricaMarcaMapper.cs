using DapperExtensions.Mapper; 
namespace Prismatec{
	public class MetricaMarcaMapper : ClassMapper<MetricaMarca>
	{
		public MetricaMarcaMapper()
		{
			//
			Schema("pecas");
			Table("metrica_marcas");
		Map(prop => prop.CodMetrica).Column("cod_metrica");  
		Map(prop => prop.IdMetricaMarca).Column("id_metrica_marca").Key(KeyType.Identity);  
		Map(prop => prop.CodMarca).Column("cod_marca");  
			//
		}
	}
}