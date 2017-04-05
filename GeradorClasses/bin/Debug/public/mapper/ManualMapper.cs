using DapperExtensions.Mapper; 
using DapperExtensions.Mapper;
using NetWebAPI.Domain.Entidades.Pecas;namespace Prismatec{
	public class ManualMapper : ClassMapper<Manual>
	{
		public ManualMapper()
		{
			//
			Schema("public");
			Table("manuais");
		Map(prop => prop.IdManual).Column("id_manual").Key(KeyType.Identity);  
		Map(prop => prop.Descricao).Column("descricao");  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.CodArquivo).Column("cod_arquivo");  
			//
		}
	}
}