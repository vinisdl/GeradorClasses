using DapperExtensions.Mapper; 
namespace Prismatec{
	public class DescontoGrupospecaMapper : ClassMapper<DescontoGrupospeca>
	{
		public DescontoGrupospecaMapper()
		{
			//
			Schema("pecas");
			Table("descontos_grupospecas");
		Map(prop => prop.CodDesconto).Column("cod_desconto");  
		Map(prop => prop.CodGrupopeca).Column("cod_grupopeca");  
		Map(prop => prop.ValorDesconto).Column("valor_desconto");  
		Map(prop => prop.IdDescontoGrupopeca).Column("id_desconto_grupopeca").Key(KeyType.Identity);  
			//
		}
	}
}