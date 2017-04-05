using DapperExtensions.Mapper; 
namespace Prismatec{
	public class MotivoAlteracaoPrazoMapper : ClassMapper<MotivoAlteracaoPrazo>
	{
		public MotivoAlteracaoPrazoMapper()
		{
			//
			Schema("pecas");
			Table("motivos_alteracao_prazo");
		Map(prop => prop.Descricao).Column("descricao");  
		Map(prop => prop.IdMotivoAlteracaoPrazo).Column("id_motivo_alteracao_prazo").Key(KeyType.Identity);  
			//
		}
	}
}