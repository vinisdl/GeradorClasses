using DapperExtensions.Mapper; 
namespace Prismatec{
	public class NotasfiscalSolicitacaoRessarcimentoMapper : ClassMapper<NotasfiscalSolicitacaoRessarcimento>
	{
		public NotasfiscalSolicitacaoRessarcimentoMapper()
		{
			//
			Schema("pecas");
			Table("notasfiscais_solicitacao_ressarcimento");
		Map(prop => prop.ComprovantePagamentoCodArquivo).Column("comprovante_pagamento_cod_arquivo");  
		Map(prop => prop.Cancelada).Column("cancelada");  
		Map(prop => prop.DataConfirmacaoRessarcimento).Column("data_confirmacao_ressarcimento");  
		Map(prop => prop.CodNotafiscal).Column("cod_notafiscal");  
		Map(prop => prop.Observacao).Column("observacao");  
		Map(prop => prop.DataPagamento).Column("data_pagamento");  
		Map(prop => prop.JustificativaCancelamento).Column("justificativa_cancelamento");  
		Map(prop => prop.CodSolicitacaoRessarcimento).Column("cod_solicitacao_ressarcimento");  
		Map(prop => prop.DataRessarcimento).Column("data_ressarcimento");  
		Map(prop => prop.TipoNota).Column("tipo_nota");  
		Map(prop => prop.ComprovanteRessarcimentoCodArquivo).Column("comprovante_ressarcimento_cod_arquivo");  
		Map(prop => prop.DataCobrancaInicial).Column("data_cobranca_inicial");  
		Map(prop => prop.IdNotafiscalSolicitacaoRessarcimento).Column("id_notafiscal_solicitacao_ressarcimento").Key(KeyType.Identity);  
			//
		}
	}
}