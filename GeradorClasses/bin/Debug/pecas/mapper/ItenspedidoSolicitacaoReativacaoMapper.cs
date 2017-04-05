using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ItenspedidoSolicitacaoReativacaoMapper : ClassMapper<ItenspedidoSolicitacaoReativacao>
	{
		public ItenspedidoSolicitacaoReativacaoMapper()
		{
			//
			Schema("pecas");
			Table("itenspedido_solicitacao_reativacao");
		Map(prop => prop.DataAtuacao).Column("data_atuacao");  
		Map(prop => prop.CodArquivo).Column("cod_arquivo");  
		Map(prop => prop.IdItemSolicitacaoReativacao).Column("id_item_solicitacao_reativacao").Key(KeyType.Identity);  
		Map(prop => prop.ContatoOficina).Column("contato_oficina");  
		Map(prop => prop.Aprovada).Column("aprovada");  
		Map(prop => prop.Motivo).Column("motivo");  
		Map(prop => prop.DataSolicitacao).Column("data_solicitacao");  
		Map(prop => prop.Cancelado).Column("cancelado");  
		Map(prop => prop.CodItempedidoFornecedor).Column("cod_itempedido_fornecedor");  
			//
		}
	}
}