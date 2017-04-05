using DapperExtensions.Mapper; 
namespace Prismatec{
	public class FotosimportacaoMapper : ClassMapper<Fotosimportacao>
	{
		public FotosimportacaoMapper()
		{
			//
			Schema("pecas");
			Table("fotosimportacao");
		Map(prop => prop.CodArquivo).Column("cod_arquivo");  
		Map(prop => prop.IdImportacao).Column("id_importacao").Key(KeyType.Identity);  
		Map(prop => prop.IdFotoimportacao).Column("id_fotoimportacao");  
			//
		}
	}
}