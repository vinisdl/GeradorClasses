using DapperExtensions.Mapper; 
namespace Prismatec{
	public class CombustiveiMapper : ClassMapper<Combustivei>
	{
		public CombustiveiMapper()
		{
			//
			Schema("pecas");
			Table("combustiveis");
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.Expressao).Column("expressao");  
		Map(prop => prop.IdCombustivel).Column("id_combustivel").Key(KeyType.Identity);  
			//
		}
	}
}