using DapperExtensions.Mapper; 
namespace Prismatec{
	public class MarcaPecaMapper : ClassMapper<MarcaPeca>
	{
		public MarcaPecaMapper()
		{
			//
			Schema("pecas");
			Table("marcas_pecas");
		Map(prop => prop.Descricao).Column("descricao");  
		Map(prop => prop.IdMarcaPeca).Column("id_marca_peca").Key(KeyType.Identity);  
			//
		}
	}
}