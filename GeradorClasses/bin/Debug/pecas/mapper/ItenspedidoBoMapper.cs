using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ItenspedidoBoMapper : ClassMapper<ItenspedidoBo>
	{
		public ItenspedidoBoMapper()
		{
			//
			Schema("pecas");
			Table("itenspedido_bo");
		Map(prop => prop.DataCriacaoPdf).Column("data_criacao_pdf");  
		Map(prop => prop.CodItempedido).Column("cod_itempedido").Key(KeyType.Identity);  
		Map(prop => prop.Laudo).Column("laudo");  
		Map(prop => prop.DataPedidoFabrica).Column("data_pedido_fabrica");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.DataPrevista).Column("data_prevista");  
		Map(prop => prop.CodMarca).Column("cod_marca");  
		Map(prop => prop.IdItemBo).Column("id_item_bo");  
		Map(prop => prop.DataCriacao).Column("data_criacao");  
			//
		}
	}
}