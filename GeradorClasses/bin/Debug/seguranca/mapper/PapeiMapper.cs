using DapperExtensions.Mapper; 
namespace Prismatec{
	public class PapeiMapper : ClassMapper<Papei>
	{
		public PapeiMapper()
		{
			//
			Schema("seguranca");
			Table("papeis");
		Map(prop => prop.Codigo).Column("codigo");  
		Map(prop => prop.Descricao).Column("descricao");  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.IdPapel).Column("id_papel").Key(KeyType.Identity);  
			//
		}
	}
}