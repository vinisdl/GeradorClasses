using DapperExtensions.Mapper; 
namespace Prismatec{
	public class SegmentoMapper : ClassMapper<Segmento>
	{
		public SegmentoMapper()
		{
			//
			Schema("pecas");
			Table("segmentos");
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.Homologado).Column("homologado");  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.IdSegmento).Column("id_segmento").Key(KeyType.Identity);  
			//
		}
	}
}