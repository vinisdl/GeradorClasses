using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AtendimentoTipoMapper : ClassMapper<AtendimentoTipo>
	{
		public AtendimentoTipoMapper()
		{
			//
			Schema("pecas");
			Table("atendimentos_tipo");
		Map(prop => prop.IdAtendimentoTipo).Column("id_atendimento_tipo").Key(KeyType.Identity);  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.Area).Column("area");  
			//
		}
	}
}