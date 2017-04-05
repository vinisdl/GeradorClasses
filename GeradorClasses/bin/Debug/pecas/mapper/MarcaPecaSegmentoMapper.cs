using DapperExtensions.Mapper; 
namespace Prismatec{
	public class MarcaPecaSegmentoMapper : ClassMapper<MarcaPecaSegmento>
	{
		public MarcaPecaSegmentoMapper()
		{
			//
			Schema("pecas");
			Table("marcas_pecas_segmentos");
		Map(prop => prop.CodMarcaPeca).Column("cod_marca_peca");  
		Map(prop => prop.IdMarcaPecaSegmento).Column("id_marca_peca_segmento").Key(KeyType.Identity);  
		Map(prop => prop.CodSegmento).Column("cod_segmento");  
			//
		}
	}
}