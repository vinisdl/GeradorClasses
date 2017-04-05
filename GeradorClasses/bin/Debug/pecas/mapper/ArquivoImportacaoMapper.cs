using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ArquivoImportacaoMapper : ClassMapper<ArquivoImportacao>
	{
		public ArquivoImportacaoMapper()
		{
			//
			Schema("pecas");
			Table("arquivos_importacoes");
		Map(prop => prop.CodPreimportacao).Column("cod_preimportacao");  
		Map(prop => prop.CodArquivo).Column("cod_arquivo");  
		Map(prop => prop.IdArquivoImportacao).Column("id_arquivo_importacao").Key(KeyType.Identity);  
			//
		}
	}
}