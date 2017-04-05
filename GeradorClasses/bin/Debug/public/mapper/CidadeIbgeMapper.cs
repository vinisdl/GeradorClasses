using DapperExtensions.Mapper; 
using DapperExtensions.Mapper;
using NetWebAPI.Domain.Entidades.Pecas;namespace Prismatec{
	public class CidadeIbgeMapper : ClassMapper<CidadeIbge>
	{
		public CidadeIbgeMapper()
		{
			//
			Schema("public");
			Table("cidades_ibge");
		Map(prop => prop.CodIbge).Column("cod_ibge");  
		Map(prop => prop.Cidade).Column("cidade").Key(KeyType.Identity);  
		Map(prop => prop.Uf).Column("uf");  
			//
		}
	}
}