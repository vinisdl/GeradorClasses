using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AnalistaMapper : ClassMapper<Analista>
	{
		public AnalistaMapper()
		{
			//
			Schema("pecas");
			Table("analistas");
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.IdAnalista).Column("id_analista").Key(KeyType.Identity);  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.Ativo).Column("ativo");  
			//
		}
	}
}