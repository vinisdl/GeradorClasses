using DapperExtensions.Mapper; 
namespace Prismatec{
	public class FornecedoMarcaMapper : ClassMapper<FornecedoMarca>
	{
		public FornecedoMarcaMapper()
		{
			//
			Schema("pecas");
			Table("fornecedores_marcas");
		Map(prop => prop.IdFornecedorMarca).Column("id_fornecedor_marca").Key(KeyType.Identity);  
		Map(prop => prop.CodMarca).Column("cod_marca");  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
			//
		}
	}
}