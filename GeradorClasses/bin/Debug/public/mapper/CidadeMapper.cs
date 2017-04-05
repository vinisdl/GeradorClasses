using DapperExtensions.Mapper; 
using DapperExtensions.Mapper;
using NetWebAPI.Domain.Entidades.Pecas;namespace Prismatec{
	public class CidadeMapper : ClassMapper<Cidade>
	{
		public CidadeMapper()
		{
			//
			Schema("public");
			Table("cidades");
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.CodIbge).Column("cod_ibge");  
		Map(prop => prop.IdCidade).Column("id_cidade").Key(KeyType.Identity);  
		Map(prop => prop.CodEstado).Column("cod_estado");  
			//
		}
	}
}