using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ClienteUsuarioMapper : ClassMapper<ClienteUsuario>
	{
		public ClienteUsuarioMapper()
		{
			//
			Schema("pecas");
			Table("clientes_usuarios");
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.IdClienteUsuario).Column("id_cliente_usuario").Key(KeyType.Identity);  
			//
		}
	}
}