using DapperExtensions.Mapper; 
using DapperExtensions.Mapper;
using NetWebAPI.Domain.Entidades.Pecas;namespace Prismatec{
	public class RelatorioMapper : ClassMapper<Relatorio>
	{
		public RelatorioMapper()
		{
			//
			Schema("public");
			Table("relatorios");
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.NomeArquivo).Column("nome_arquivo");  
		Map(prop => prop.IdRelatorio).Column("id_relatorio").Key(KeyType.Identity);  
		Map(prop => prop.NomeAmbRelatorio).Column("nome_amb_relatorio");  
			//
		}
	}
}