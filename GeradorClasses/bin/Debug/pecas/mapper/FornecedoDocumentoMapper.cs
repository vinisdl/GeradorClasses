using DapperExtensions.Mapper; 
namespace Prismatec{
	public class FornecedoDocumentoMapper : ClassMapper<FornecedoDocumento>
	{
		public FornecedoDocumentoMapper()
		{
			//
			Schema("pecas");
			Table("fornecedores_documentos");
		Map(prop => prop.NomeArquivo).Column("nome_arquivo");  
		Map(prop => prop.IdFornecedorDocumento).Column("id_fornecedor_documento").Key(KeyType.Identity);  
		Map(prop => prop.TipoDocumento).Column("tipo_documento");  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
			//
		}
	}
}