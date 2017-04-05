using DapperExtensions.Mapper; 
namespace Prismatec{
	public class VistoriaMapper : ClassMapper<Vistoria>
	{
		public VistoriaMapper()
		{
			//
			Schema("pecas");
			Table("vistorias");
		Map(prop => prop.CodReguladora).Column("cod_reguladora");  
		Map(prop => prop.Numero).Column("numero");  
		Map(prop => prop.CodSinistro).Column("cod_sinistro");  
		Map(prop => prop.IdVistoria).Column("id_vistoria").Key(KeyType.Identity);  
			//
		}
	}
}