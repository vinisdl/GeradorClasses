using DapperExtensions.Mapper; 
namespace Prismatec{
	public class UsuarioPapeiMapper : ClassMapper<UsuarioPapei>
	{
		public UsuarioPapeiMapper()
		{
			//
			Schema("seguranca");
			Table("usuarios_papeis");
		Map(prop => prop.CodPapel).Column("cod_papel");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.IdUsuarioPapel).Column("id_usuario_papel").Key(KeyType.Identity);  
			//
		}
	}
}