using DapperExtensions.Mapper; 
namespace Prismatec{
	public class LocacoeslogisticaMapper : ClassMapper<Locacoeslogistica>
	{
		public LocacoeslogisticaMapper()
		{
			//
			Schema("pecas");
			Table("locacoeslogistica");
		Map(prop => prop.DataLocacao).Column("data_locacao");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.IdLocacaologistica).Column("id_locacaologistica").Key(KeyType.Identity);  
		Map(prop => prop.CodOficina).Column("cod_oficina");  
			//
		}
	}
}