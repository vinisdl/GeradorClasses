using DapperExtensions.Mapper; 
namespace Prismatec{
	public class MuralFornecedorMapper : ClassMapper<MuralFornecedor>
	{
		public MuralFornecedorMapper()
		{
			//
			Schema("pecas");
			Table("mural_fornecedor");
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.Mensagem).Column("mensagem");  
		Map(prop => prop.IdMuralFornecedor).Column("id_mural_fornecedor").Key(KeyType.Identity);  
			//
		}
	}
}