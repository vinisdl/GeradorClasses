using DapperExtensions.Mapper; 
namespace Prismatec{
	public class SituacaoLogisticaDevolucaoMapper : ClassMapper<SituacaoLogisticaDevolucao>
	{
		public SituacaoLogisticaDevolucaoMapper()
		{
			//
			Schema("pecas");
			Table("situacoes_logisticas_devolucoes");
		Map(prop => prop.Descricao).Column("descricao");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.IdSituacaoLogisticaDevolucao).Column("id_situacao_logistica_devolucao").Key(KeyType.Identity);  
			//
		}
	}
}