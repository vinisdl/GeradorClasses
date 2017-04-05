using DapperExtensions.Mapper; 
namespace Prismatec{
	public class NotasfiscalMapper : ClassMapper<Notasfiscal>
	{
		public NotasfiscalMapper()
		{
			//
			Schema("pecas");
			Table("notasfiscais");
		Map(prop => prop.EnviadaNotafiscalIntegracao).Column("enviada_notafiscal_integracao");  
		Map(prop => prop.DataEnvioNotafiscalManual).Column("data_envio_notafiscal_manual");  
		Map(prop => prop.CancelamentoCodUsuario).Column("cancelamento_cod_usuario");  
		Map(prop => prop.DanfeGeradaCodArquivo).Column("danfe_gerada_cod_arquivo");  
		Map(prop => prop.CodNotafiscalModelo).Column("cod_notafiscal_modelo");  
		Map(prop => prop.TipoNota).Column("tipo_nota");  
		Map(prop => prop.DataEmissao).Column("data_emissao");  
		Map(prop => prop.Eletronica).Column("eletronica");  
		Map(prop => prop.DataConfirmacaoPgt).Column("data_confirmacao_pgt");  
		Map(prop => prop.Cancelada).Column("cancelada");  
		Map(prop => prop.DanfeCodArquivo).Column("danfe_cod_arquivo");  
		Map(prop => prop.PdfCodArquivo).Column("pdf_cod_arquivo");  
		Map(prop => prop.DataEnvioCancelamentoNotafiscalIntegracao).Column("data_envio_cancelamento_notafiscal_integracao");  
		Map(prop => prop.ValorTotal).Column("valor_total");  
		Map(prop => prop.MotivoCancelamento).Column("motivo_cancelamento");  
		Map(prop => prop.CancelamentoData).Column("cancelamento_data");  
		Map(prop => prop.NfeCodArquivo).Column("nfe_cod_arquivo");  
		Map(prop => prop.CodNotafiscalSerie).Column("cod_notafiscal_serie");  
		Map(prop => prop.DataSaida).Column("data_saida").Key(KeyType.Identity);  
		Map(prop => prop.Numero).Column("numero");  
		Map(prop => prop.NomeRecebimento).Column("nome_recebimento");  
		Map(prop => prop.DataEntrega).Column("data_entrega");  
		Map(prop => prop.DataEnvioNotafiscalIntegracao).Column("data_envio_notafiscal_integracao");  
		Map(prop => prop.CodPedidoFornecedor).Column("cod_pedido_fornecedor");  
		Map(prop => prop.DataInclusao).Column("data_inclusao");  
		Map(prop => prop.Chave).Column("chave");  
		Map(prop => prop.IdNotafiscal).Column("id_notafiscal");  
		Map(prop => prop.DataUltimaVerificacaoPgt).Column("data_ultima_verificacao_pgt");  
			//
		}
	}
}