using DapperExtensions.Mapper; 
using DapperExtensions.Mapper;
using NetWebAPI.Domain.Entidades.Pecas;namespace Prismatec{
	public class RegiaoMapper : ClassMapper<Regiao>
	{
		public RegiaoMapper()
		{
			//
			Schema("public");
			Table("regioes");
		Map(prop => prop.Descricao).Column("descricao");  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.IdRegiao).Column("id_regiao").Key(KeyType.Identity);  
			//
		}
	}
}