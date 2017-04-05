using DapperExtensions.Mapper; 
namespace Prismatec{
	public class DescontoGrupospecaMarcaMapper : ClassMapper<DescontoGrupospecaMarca>
	{
		public DescontoGrupospecaMarcaMapper()
		{
			//
			Schema("pecas");
			Table("descontos_grupospecas_marcas");
		Map(prop => prop.IdDescontoGrupopecaMarca).Column("id_desconto_grupopeca_marca").Key(KeyType.Identity);  
		Map(prop => prop.CodDesconto).Column("cod_desconto");  
		Map(prop => prop.ValorDesconto).Column("valor_desconto");  
		Map(prop => prop.CodGrupopecaMarca).Column("cod_grupopeca_marca");  
			//
		}
	}
}