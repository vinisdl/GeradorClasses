using DapperExtensions.Mapper; 
namespace Prismatec{
	public class PeritoMapper : ClassMapper<Perito>
	{
		public PeritoMapper()
		{
			//
			Schema("pecas");
			Table("peritos");
		Map(prop => prop.Cnpj).Column("cnpj");  
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.Email).Column("email");  
		Map(prop => prop.IdPerito).Column("id_perito").Key(KeyType.Identity);  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
			//
		}
	}
}