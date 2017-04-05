using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ItemBoMapper : ClassMapper<ItemBo>
	{
		public ItemBoMapper()
		{
			//
			Schema("pecas");
			Table("itens_bo");
		Map(prop => prop.Descricao).Column("descricao");  
		Map(prop => prop.IdItemBo).Column("id_item_bo").Key(KeyType.Identity);  
		Map(prop => prop.Parthnumber).Column("parthnumber");  
		Map(prop => prop.CodMarca).Column("cod_marca");  
			//
		}
	}
}