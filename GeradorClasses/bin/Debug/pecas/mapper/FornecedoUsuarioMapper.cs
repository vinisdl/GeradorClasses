using DapperExtensions.Mapper; 
namespace Prismatec{
	public class FornecedoUsuarioMapper : ClassMapper<FornecedoUsuario>
	{
		public FornecedoUsuarioMapper()
		{
			//
			Schema("pecas");
			Table("fornecedores_usuarios");
		Map(prop => prop.IdFornecedorUsuario).Column("id_fornecedor_usuario").Key(KeyType.Identity);  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
			//
		}
	}
}