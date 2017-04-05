using DapperExtensions.Mapper; 
namespace Prismatec{
	public class MonitoramentoFornecedoMapper : ClassMapper<MonitoramentoFornecedo>
	{
		public MonitoramentoFornecedoMapper()
		{
			//
			Schema("pecas");
			Table("monitoramentos_fornecedores");
		Map(prop => prop.SituacaoCritica).Column("situacao_critica");  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
		Map(prop => prop.IdMonitoramentoFornecedor).Column("id_monitoramento_fornecedor").Key(KeyType.Identity);  
		Map(prop => prop.Statu).Column("status");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.DataAtualizacao).Column("data_atualizacao");  
			//
		}
	}
}