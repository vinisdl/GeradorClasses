using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AuxiliaAtendimentoTipoMapper : ClassMapper<AuxiliaAtendimentoTipo>
	{
		public AuxiliaAtendimentoTipoMapper()
		{
			//
			Schema("pecas");
			Table("auxiliares_atendimento_tipos");
		Map(prop => prop.IdAuxiliarAtendimentoTipo).Column("id_auxiliar_atendimento_tipo").Key(KeyType.Identity);  
		Map(prop => prop.CodAtendimentoTipo).Column("cod_atendimento_tipo");  
		Map(prop => prop.CodAuxiliarAtendimento).Column("cod_auxiliar_atendimento");  
			//
		}
	}
}