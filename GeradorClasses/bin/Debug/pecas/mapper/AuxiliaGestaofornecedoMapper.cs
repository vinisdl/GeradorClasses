using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AuxiliaGestaofornecedoMapper : ClassMapper<AuxiliaGestaofornecedo>
	{
		public AuxiliaGestaofornecedoMapper()
		{
			//
			Schema("pecas");
			Table("auxiliares_gestaofornecedores");
		Map(prop => prop.IdAuxiliarGestaofornecedor).Column("id_auxiliar_gestaofornecedor").Key(KeyType.Identity);  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
			//
		}
	}
}