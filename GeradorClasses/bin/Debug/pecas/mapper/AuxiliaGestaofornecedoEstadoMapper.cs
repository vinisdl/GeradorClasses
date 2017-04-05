using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AuxiliaGestaofornecedoEstadoMapper : ClassMapper<AuxiliaGestaofornecedoEstado>
	{
		public AuxiliaGestaofornecedoEstadoMapper()
		{
			//
			Schema("pecas");
			Table("auxiliares_gestaofornecedores_estados");
		Map(prop => prop.IdAuxiliarGestaofornecedoEstado).Column("id_auxiliar_gestaofornecedores_estados").Key(KeyType.Identity);  
		Map(prop => prop.CodAuxiliarGestaofornecedor).Column("cod_auxiliar_gestaofornecedor");  
		Map(prop => prop.CodEstado).Column("cod_estado");  
			//
		}
	}
}