using DapperExtensions.Mapper; 
namespace Prismatec{
	public class FornecedoRegiaoMapper : ClassMapper<FornecedoRegiao>
	{
		public FornecedoRegiaoMapper()
		{
			//
			Schema("pecas");
			Table("fornecedores_regioes");
		Map(prop => prop.CodRegiao).Column("cod_regiao");  
		Map(prop => prop.IdFornecedorRegiao).Column("id_fornecedor_regiao").Key(KeyType.Identity);  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
			//
		}
	}
}