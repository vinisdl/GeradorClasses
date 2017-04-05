using DapperExtensions.Mapper; 
namespace Prismatec{
	public class FornecedoTipospecaMapper : ClassMapper<FornecedoTipospeca>
	{
		public FornecedoTipospecaMapper()
		{
			//
			Schema("pecas");
			Table("fornecedores_tipospeca");
		Map(prop => prop.CodTipopeca).Column("cod_tipopeca");  
		Map(prop => prop.IdFornecedorTipopeca).Column("id_fornecedor_tipopeca").Key(KeyType.Identity);  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
			//
		}
	}
}