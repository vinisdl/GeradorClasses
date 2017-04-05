using DapperExtensions.Mapper; 
namespace Prismatec{
	public class GrupospecaMapper : ClassMapper<Grupospeca>
	{
		public GrupospecaMapper()
		{
			//
			Schema("pecas");
			Table("grupospecas");
		Map(prop => prop.IdGrupopeca).Column("id_grupopeca").Key(KeyType.Identity);  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.CodFornecedorMarca).Column("cod_fornecedor_marca");  
			//
		}
	}
}