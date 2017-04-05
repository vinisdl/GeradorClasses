using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AuxiliaAtendimentoMapper : ClassMapper<AuxiliaAtendimento>
	{
		public AuxiliaAtendimentoMapper()
		{
			//
			Schema("pecas");
			Table("auxiliares_atendimento");
		Map(prop => prop.Area).Column("area");  
		Map(prop => prop.IdAuxiliarAtendimento).Column("id_auxiliar_atendimento").Key(KeyType.Identity);  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
			//
		}
	}
}