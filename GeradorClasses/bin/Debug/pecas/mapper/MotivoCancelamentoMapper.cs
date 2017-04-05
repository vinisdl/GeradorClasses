using DapperExtensions.Mapper; 
namespace Prismatec{
	public class MotivoCancelamentoMapper : ClassMapper<MotivoCancelamento>
	{
		public MotivoCancelamentoMapper()
		{
			//
			Schema("pecas");
			Table("motivos_cancelamento");
		Map(prop => prop.Descricao).Column("descricao");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.IdMotivoCancelamento).Column("id_motivo_cancelamento").Key(KeyType.Identity);  
		Map(prop => prop.Tipo).Column("tipo");  
			//
		}
	}
}