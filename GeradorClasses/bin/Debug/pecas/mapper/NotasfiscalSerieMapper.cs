using DapperExtensions.Mapper; 
namespace Prismatec{
	public class NotasfiscalSerieMapper : ClassMapper<NotasfiscalSerie>
	{
		public NotasfiscalSerieMapper()
		{
			//
			Schema("pecas");
			Table("notasfiscais_series");
		Map(prop => prop.IdNotafiscalSerie).Column("id_notafiscal_serie").Key(KeyType.Identity);  
		Map(prop => prop.Descricao).Column("descricao");  
		Map(prop => prop.Codigo).Column("codigo");  
			//
		}
	}
}