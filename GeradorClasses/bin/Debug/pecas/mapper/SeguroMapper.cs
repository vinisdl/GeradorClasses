using DapperExtensions.Mapper; 
namespace Prismatec{
	public class SeguroMapper : ClassMapper<Seguro>
	{
		public SeguroMapper()
		{
			//
			Schema("pecas");
			Table("seguros");
		Map(prop => prop.IdSeguro).Column("id_seguro").Key(KeyType.Identity);  
		Map(prop => prop.Valor).Column("valor");  
		Map(prop => prop.Apolice).Column("apolice");  
		Map(prop => prop.NomeCorretor).Column("nome_corretor");  
		Map(prop => prop.Franquia).Column("franquia");  
			//
		}
	}
}