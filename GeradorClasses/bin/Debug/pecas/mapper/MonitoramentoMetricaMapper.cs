using DapperExtensions.Mapper; 
namespace Prismatec{
	public class MonitoramentoMetricaMapper : ClassMapper<MonitoramentoMetrica>
	{
		public MonitoramentoMetricaMapper()
		{
			//
			Schema("pecas");
			Table("monitoramento_metricas");
		Map(prop => prop.IdMonitoramentoMetrica).Column("id_monitoramento_metrica").Key(KeyType.Identity);  
		Map(prop => prop.CodMonitoramentoFornecedor).Column("cod_monitoramento_fornecedor");  
		Map(prop => prop.CodMetrica).Column("cod_metrica");  
			//
		}
	}
}