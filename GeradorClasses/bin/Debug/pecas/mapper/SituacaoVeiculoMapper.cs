using DapperExtensions.Mapper; 
namespace Prismatec{
	public class SituacaoVeiculoMapper : ClassMapper<SituacaoVeiculo>
	{
		public SituacaoVeiculoMapper()
		{
			//
			Schema("pecas");
			Table("situacoes_veiculo");
		Map(prop => prop.IdSituacaoVeiculo).Column("id_situacao_veiculo").Key(KeyType.Identity);  
		Map(prop => prop.Descricao).Column("descricao");  
			//
		}
	}
}