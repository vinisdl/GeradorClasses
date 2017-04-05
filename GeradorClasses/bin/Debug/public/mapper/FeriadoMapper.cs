using DapperExtensions.Mapper; 
using DapperExtensions.Mapper;
using NetWebAPI.Domain.Entidades.Pecas;namespace Prismatec{
	public class FeriadoMapper : ClassMapper<Feriado>
	{
		public FeriadoMapper()
		{
			//
			Schema("public");
			Table("feriados");
		Map(prop => prop.Dia).Column("dia");  
		Map(prop => prop.IdFeriado).Column("id_feriado").Key(KeyType.Identity);  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.Ano).Column("ano");  
		Map(prop => prop.Me).Column("mes");  
			//
		}
	}
}