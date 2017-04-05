using DapperExtensions.Mapper; 
namespace Prismatec{
	public class SistemaMapper : ClassMapper<Sistema>
	{
		public SistemaMapper()
		{
			//
			Schema("seguranca");
			Table("sistemas");
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.IdSistema).Column("id_sistema").Key(KeyType.Identity);  
			//
		}
	}
}