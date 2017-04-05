using DapperExtensions.Mapper; 
using DapperExtensions.Mapper;
using NetWebAPI.Domain.Entidades.Pecas;namespace Prismatec{
	public class WArquivoBkpMapper : ClassMapper<WArquivoBkp>
	{
		public WArquivoBkpMapper()
		{
			//
			Schema("public");
			Table("w_arquivos_bkp");
		Map(prop => prop.CriacaoData).Column("criacao_data");  
		Map(prop => prop.CriacaoCodUsuario).Column("criacao_cod_usuario");  
		Map(prop => prop.Tamanho).Column("tamanho");  
		Map(prop => prop.IdArquivo).Column("id_arquivo").Key(KeyType.Identity);  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.Conteudo).Column("conteudo");  
		Map(prop => prop.MimeType).Column("mime_type");  
		Map(prop => prop.Descricao).Column("descricao");  
			//
		}
	}
}