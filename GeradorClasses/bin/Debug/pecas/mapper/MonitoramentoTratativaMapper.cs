using DapperExtensions.Mapper; 
namespace Prismatec{
	public class MonitoramentoTratativaMapper : ClassMapper<MonitoramentoTratativa>
	{
		public MonitoramentoTratativaMapper()
		{
			//
			Schema("pecas");
			Table("monitoramentos_tratativas");
		Map(prop => prop.IdMonitoramentoTratativa).Column("id_monitoramento_tratativa").Key(KeyType.Identity);  
		Map(prop => prop.DataEnvioNotificacao).Column("data_envio_notificacao");  
		Map(prop => prop.Texto).Column("texto");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.Notificacao).Column("notificacao");  
		Map(prop => prop.CodArquivo).Column("cod_arquivo");  
		Map(prop => prop.CodMonitoramentoFornecedor).Column("cod_monitoramento_fornecedor");  
		Map(prop => prop.DataCriacao).Column("data_criacao");  
			//
		}
	}
}