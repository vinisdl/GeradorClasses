using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ReguladoraMapper : ClassMapper<Reguladora>
	{
		public ReguladoraMapper()
		{
			//
			Schema("pecas");
			Table("reguladoras");
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.IdReguladora).Column("id_reguladora").Key(KeyType.Identity);  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.Cnpj).Column("cnpj");  
			//
		}
	}
}