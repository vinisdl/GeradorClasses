using DapperExtensions.Mapper; 
namespace Prismatec{
	public class SituacaoLogisticaMapper : ClassMapper<SituacaoLogistica>
	{
		public SituacaoLogisticaMapper()
		{
			//
			Schema("pecas");
			Table("situacao_logisticas");
		Map(prop => prop.Pedido).Column("pedidos").Key(KeyType.Identity);  
		Map(prop => prop.IdStatuLogistica).Column("id_status_logistica");  
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.DataGeracao).Column("data_geracao");  
		Map(prop => prop.TipoStatu).Column("tipo_status");  
		Map(prop => prop.Cliente).Column("cliente");  
		Map(prop => prop.Estado).Column("estado");  
			//
		}
	}
}