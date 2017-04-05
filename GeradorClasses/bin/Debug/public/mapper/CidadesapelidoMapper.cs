using DapperExtensions.Mapper; 
using DapperExtensions.Mapper;
using NetWebAPI.Domain.Entidades.Pecas;namespace Prismatec{
	public class CidadesapelidoMapper : ClassMapper<Cidadesapelido>
	{
		public CidadesapelidoMapper()
		{
			//
			Schema("public");
			Table("cidadesapelidos");
		Map(prop => prop.Apelido).Column("apelido").Key(KeyType.Identity);  
		Map(prop => prop.CodCidade).Column("cod_cidade");  
		Map(prop => prop.IdCidadeapelido).Column("id_cidadeapelido");  
			//
		}
	}
}