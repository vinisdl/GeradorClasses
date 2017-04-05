using DapperExtensions.Mapper; 
using DapperExtensions.Mapper;
using NetWebAPI.Domain.Entidades.Pecas;namespace Prismatec{
	public class EstadoMapper : ClassMapper<Estado>
	{
		public EstadoMapper()
		{
			//
			Schema("public");
			Table("estados");
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.IdEstado).Column("id_estado").Key(KeyType.Identity);  
		Map(prop => prop.Sigla).Column("sigla");  
			//
		}
	}
}