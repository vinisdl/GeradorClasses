using DapperExtensions.Mapper; 
namespace Prismatec{
	public class FornecedoSegmentoMapper : ClassMapper<FornecedoSegmento>
	{
		public FornecedoSegmentoMapper()
		{
			//
			Schema("pecas");
			Table("fornecedores_segmentos");
		Map(prop => prop.IdFornecedorSegmento).Column("id_fornecedor_segmento").Key(KeyType.Identity);  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
		Map(prop => prop.CodSegmento).Column("cod_segmento");  
			//
		}
	}
}