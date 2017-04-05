using DapperExtensions.Mapper; 
namespace Prismatec{
	public class SolicitacaoPagamentoMapper : ClassMapper<SolicitacaoPagamento>
	{
		public SolicitacaoPagamentoMapper()
		{
			//
			Schema("pecas");
			Table("solicitacoes_pagamento");
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.CodUsuarioCriacao).Column("cod_usuario_criacao");  
		Map(prop => prop.DataLocacao).Column("data_locacao");  
		Map(prop => prop.CodAuxiliarPagamento).Column("cod_auxiliar_pagamento");  
		Map(prop => prop.DataAgendamentoEnvio).Column("data_agendamento_envio");  
		Map(prop => prop.DataCobrancaInicial).Column("data_cobranca_inicial");  
		Map(prop => prop.IdSolicitacaoPagamento).Column("id_solicitacao_pagamento");  
		Map(prop => prop.CodPedidoFornecedor).Column("cod_pedido_fornecedor");  
		Map(prop => prop.DataCriacao).Column("data_criacao");  
			//
		}
	}
}