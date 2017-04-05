using DapperExtensions.Mapper; 
using DapperExtensions.Mapper;
using NetWebAPI.Domain.Entidades.Pecas;namespace Prismatec{
	public class RegiaoCidadeMapper : ClassMapper<RegiaoCidade>
	{
		public RegiaoCidadeMapper()
		{
			//
			Schema("public");
			Table("regioes_cidades");
		Map(prop => prop.IdRegiaoCidade).Column("id_regioes_cidades").Key(KeyType.Identity);  
		Map(prop => prop.CodCidade).Column("cod_cidade");  
		Map(prop => prop.CodRegiao).Column("cod_regiao");  
			//
		}
	}
}