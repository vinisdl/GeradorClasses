using DapperExtensions.Mapper; 
using DapperExtensions.Mapper;
using NetWebAPI.Domain.Entidades.Pecas;namespace Prismatec{
	public class VUsuarioMapper : ClassMapper<VUsuario>
	{
		public VUsuarioMapper()
		{
			//
			Schema("public");
			Table("v_usuario");
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
			//
		}
	}
}