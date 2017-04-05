using DapperExtensions.Mapper; 
namespace Prismatec{
	public class NotasfiscalSolicitacaoPagamentoMapper : ClassMapper<NotasfiscalSolicitacaoPagamento>
	{
		public NotasfiscalSolicitacaoPagamentoMapper()
		{
			//
			Schema("pecas");
			Table("notasfiscais_solicitacao_pagamento");
		Map(prop => prop.DataConfirmacaoPagamento).Column("data_confirmacao_pagamento");  
		Map(prop => prop.ComprovantePagamentoCodArquivo).Column("comprovante_pagamento_cod_arquivo");  
		Map(prop => prop.Cancelada).Column("cancelada");  
		Map(prop => prop.IdNotafiscalSolicitacaoPagamento).Column("id_notafiscal_solicitacao_pagamento").Key(KeyType.Identity);  
		Map(prop => prop.ConfirmacaoPagamento).Column("confirmacao_pagamento");  
		Map(prop => prop.Observacao).Column("observacao");  
		Map(prop => prop.DataPagamento).Column("data_pagamento");  
		Map(prop => prop.CodNotafiscal).Column("cod_notafiscal");  
		Map(prop => prop.DataEnvioDocumento).Column("data_envio_documento");  
		Map(prop => prop.JustificativaCancelamento).Column("justificativa_cancelamento");  
		Map(prop => prop.ComprovanteEnvioCodArquivo).Column("comprovante_envio_cod_arquivo");  
		Map(prop => prop.DataCobrancaInicial).Column("data_cobranca_inicial");  
		Map(prop => prop.CodSolicitacaoPagamento).Column("cod_solicitacao_pagamento");  
			//
		}
	}
}