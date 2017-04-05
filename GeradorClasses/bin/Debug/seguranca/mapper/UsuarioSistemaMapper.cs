using DapperExtensions.Mapper; 
namespace Prismatec{
	public class UsuarioSistemaMapper : ClassMapper<UsuarioSistema>
	{
		public UsuarioSistemaMapper()
		{
			//
			Schema("seguranca");
			Table("usuarios_sistemas");
		Map(prop => prop.Gerente).Column("gerente");  
		Map(prop => prop.CodSistema).Column("cod_sistema");  
		Map(prop => prop.IdUsuarioSistema).Column("id_usuario_sistema").Key(KeyType.Identity);  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.CodUsuarioExterno).Column("cod_usuario_externo");  
			//
		}
	}
}