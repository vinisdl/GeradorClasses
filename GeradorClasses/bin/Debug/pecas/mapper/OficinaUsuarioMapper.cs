using DapperExtensions.Mapper; 
namespace Prismatec{
	public class OficinaUsuarioMapper : ClassMapper<OficinaUsuario>
	{
		public OficinaUsuarioMapper()
		{
			//
			Schema("pecas");
			Table("oficinas_usuarios");
		Map(prop => prop.IdOficinaUsuario).Column("id_oficina_usuario").Key(KeyType.Identity);  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.CodOficina).Column("cod_oficina");  
			//
		}
	}
}