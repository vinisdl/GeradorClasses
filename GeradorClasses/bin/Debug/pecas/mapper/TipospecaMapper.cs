using DapperExtensions.Mapper; 
namespace Prismatec{
	public class TipospecaMapper : ClassMapper<Tipospeca>
	{
		public TipospecaMapper()
		{
			//
			Schema("pecas");
			Table("tipospeca");
		Map(prop => prop.Descricao).Column("descricao");  
		Map(prop => prop.IdTipopeca).Column("id_tipopeca").Key(KeyType.Identity);  
		Map(prop => prop.Ordem).Column("ordem");  
			//
		}
	}
}