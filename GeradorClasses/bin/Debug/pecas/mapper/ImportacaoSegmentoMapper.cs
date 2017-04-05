using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ImportacaoSegmentoMapper : ClassMapper<ImportacaoSegmento>
	{
		public ImportacaoSegmentoMapper()
		{
			//
			Schema("pecas");
			Table("importacoes_segmentos");
		Map(prop => prop.IdImportacaoSegmento).Column("id_importacao_segmento").Key(KeyType.Identity);  
		Map(prop => prop.CodImportacao).Column("cod_importacao");  
		Map(prop => prop.CodSegmento).Column("cod_segmento");  
			//
		}
	}
}