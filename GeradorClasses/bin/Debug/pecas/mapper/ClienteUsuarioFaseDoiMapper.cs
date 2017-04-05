using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ClienteUsuarioFaseDoiMapper : ClassMapper<ClienteUsuarioFaseDoi>
	{
		public ClienteUsuarioFaseDoiMapper()
		{
			//
			Schema("pecas");
			Table("clientes_usuarios_fase_dois");
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.IdClienteUsuarioFaseDoi).Column("id_cliente_usuario_fase_dois").Key(KeyType.Identity);  
			//
		}
	}
}