using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ItenspedidoDevolucaoSolicitadaMapper : ClassMapper<ItenspedidoDevolucaoSolicitada>
	{
		public ItenspedidoDevolucaoSolicitadaMapper()
		{
			//
			Schema("pecas");
			Table("itenspedido_devolucao_solicitada");
		Map(prop => prop.CodItempedido).Column("cod_itempedido").Key(KeyType.Identity);  
		Map(prop => prop.Cancelada).Column("cancelada");  
		Map(prop => prop.CodDevolucaoSolicitada).Column("cod_devolucao_solicitada");  
		Map(prop => prop.IdItempedidoDevolucaoSolicitada).Column("id_itempedido_devolucao_solicitada");  
		Map(prop => prop.Procede).Column("procede");  
		Map(prop => prop.DataCriacao).Column("data_criacao");  
			//
		}
	}
}