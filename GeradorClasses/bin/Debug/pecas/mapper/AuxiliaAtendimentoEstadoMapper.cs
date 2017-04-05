using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AuxiliaAtendimentoEstadoMapper : ClassMapper<AuxiliaAtendimentoEstado>
	{
		public AuxiliaAtendimentoEstadoMapper()
		{
			//
			Schema("pecas");
			Table("auxiliares_atendimento_estados");
		Map(prop => prop.CodEstado).Column("cod_estado");  
		Map(prop => prop.IdAuxiliarAtendimentoEstado).Column("id_auxiliar_atendimento_estado").Key(KeyType.Identity);  
		Map(prop => prop.CodAuxiliarAtendimento).Column("cod_auxiliar_atendimento");  
			//
		}
	}
}