using DapperExtensions.Mapper; 
using DapperExtensions.Mapper;
using NetWebAPI.Domain.Entidades.Pecas;namespace Prismatec{
	public class RegiaoEstadoMapper : ClassMapper<RegiaoEstado>
	{
		public RegiaoEstadoMapper()
		{
			//
			Schema("public");
			Table("regioes_estados");
		Map(prop => prop.CodRegiao).Column("cod_regiao");  
		Map(prop => prop.IdRegiaoEstado).Column("id_regiao_estado").Key(KeyType.Identity);  
		Map(prop => prop.CodEstado).Column("cod_estado");  
			//
		}
	}
}