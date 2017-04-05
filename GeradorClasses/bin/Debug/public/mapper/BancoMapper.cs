using DapperExtensions.Mapper; 
using DapperExtensions.Mapper;
using NetWebAPI.Domain.Entidades.Pecas;namespace Prismatec{
	public class BancoMapper : ClassMapper<Banco>
	{
		public BancoMapper()
		{
			//
			Schema("public");
			Table("bancos");
		Map(prop => prop.Codigo).Column("codigo");  
		Map(prop => prop.IdBanco).Column("id_banco").Key(KeyType.Identity);  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.Apelido).Column("apelido");  
			//
		}
	}
}