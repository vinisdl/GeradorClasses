using DapperExtensions.Mapper; 
namespace Prismatec{
	public class SolicitacaoRessarcimentoMapper : ClassMapper<SolicitacaoRessarcimento>
	{
		public SolicitacaoRessarcimentoMapper()
		{
			//
			Schema("pecas");
			Table("solicitacoes_ressarcimento");
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.IdSolicitacaoRessarcimento).Column("id_solicitacao_ressarcimento");  
		Map(prop => prop.CodUsuarioCriacao).Column("cod_usuario_criacao");  
		Map(prop => prop.DataLocacao).Column("data_locacao");  
		Map(prop => prop.DataCobrancaInicial).Column("data_cobranca_inicial");  
		Map(prop => prop.DataAgendamentoEnvio).Column("data_agendamento_envio");  
		Map(prop => prop.CodAuxiliarRessarcimento).Column("cod_auxiliar_ressarcimento");  
		Map(prop => prop.CodPedidoFornecedor).Column("cod_pedido_fornecedor");  
		Map(prop => prop.DataCriacao).Column("data_criacao");  
			//
		}
	}
}