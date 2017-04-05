using DapperExtensions.Mapper; 
namespace Prismatec{
	public class GrupospecaMarcaMapper : ClassMapper<GrupospecaMarca>
	{
		public GrupospecaMarcaMapper()
		{
			//
			Schema("pecas");
			Table("grupospecas_marcas");
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.IdGrupopecaMarca).Column("id_grupopeca_marca").Key(KeyType.Identity);  
		Map(prop => prop.Interestadual).Column("interestadual");  
		Map(prop => prop.CodMarca).Column("cod_marca");  
			//
		}
	}
}