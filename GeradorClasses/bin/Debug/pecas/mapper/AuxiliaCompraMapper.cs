using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AuxiliaCompraMapper : ClassMapper<AuxiliaCompra>
	{
		public AuxiliaCompraMapper()
		{
			//
			Schema("pecas");
			Table("auxiliares_compra");
		Map(prop => prop.Ordem).Column("ordem");  
		Map(prop => prop.IdAuxiliarCompra).Column("id_auxiliar_compra").Key(KeyType.Identity);  
		Map(prop => prop.CodEstado).Column("cod_estado");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.NumeroPedidoFase2).Column("numero_pedidos_fase2");  
		Map(prop => prop.Fase).Column("fase");  
		Map(prop => prop.Vulneravel).Column("vulneravel");  
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.NumeroPedido).Column("numero_pedidos");  
			//
		}
	}
}