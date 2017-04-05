using DapperExtensions.Mapper; 
using DapperExtensions.Mapper;
using NetWebAPI.Domain.Entidades.Pecas;namespace Prismatec{
	public class ArquivoLogMapper : ClassMapper<ArquivoLog>
	{
		public ArquivoLogMapper()
		{
			//
			Schema("public");
			Table("arquivos_log");
		Map(prop => prop.Operacao).Column("operacao");  
		Map(prop => prop.IdArquivoLog).Column("id_arquivos_log").Key(KeyType.Identity);  
		Map(prop => prop.Datahora).Column("datahora");  
		Map(prop => prop.CodArquivo).Column("cod_arquivo");  
			//
		}
	}
}