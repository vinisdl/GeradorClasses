using DapperExtensions.Mapper; 
namespace Prismatec{
	public class NotasfiscalModeloMapper : ClassMapper<NotasfiscalModelo>
	{
		public NotasfiscalModeloMapper()
		{
			//
			Schema("pecas");
			Table("notasfiscais_modelos");
		Map(prop => prop.Codigo).Column("codigo");  
		Map(prop => prop.Descricao).Column("descricao");  
		Map(prop => prop.IdNotafiscalModelo).Column("id_notafiscal_modelo").Key(KeyType.Identity);  
			//
		}
	}
}