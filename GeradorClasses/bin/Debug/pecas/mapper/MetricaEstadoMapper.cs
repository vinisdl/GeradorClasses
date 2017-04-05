using DapperExtensions.Mapper; 
namespace Prismatec{
	public class MetricaEstadoMapper : ClassMapper<MetricaEstado>
	{
		public MetricaEstadoMapper()
		{
			//
			Schema("pecas");
			Table("metrica_estados");
		Map(prop => prop.IdMetricaEstado).Column("id_metrica_estado").Key(KeyType.Identity);  
		Map(prop => prop.CodMetrica).Column("cod_metrica");  
		Map(prop => prop.CodEstado).Column("cod_estado");  
			//
		}
	}
}