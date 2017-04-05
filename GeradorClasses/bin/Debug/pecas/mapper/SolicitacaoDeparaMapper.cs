using DapperExtensions.Mapper; 
namespace Prismatec{
	public class SolicitacaoDeparaMapper : ClassMapper<SolicitacaoDepara>
	{
		public SolicitacaoDeparaMapper()
		{
			//
			Schema("pecas");
			Table("solicitacoes_depara");
		Map(prop => prop.StatuJustificativaDepara).Column("status_justificativa_depara");  
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.EnviarEmailCia).Column("enviar_email_cia");  
		Map(prop => prop.CodUsuarioFinalizacao).Column("cod_usuario_finalizacao");  
		Map(prop => prop.IdSolicitacaoDepara).Column("id_solicitacao_depara");  
		Map(prop => prop.CodArquivo).Column("cod_arquivo");  
		Map(prop => prop.Cancelado).Column("cancelado");  
		Map(prop => prop.MotivoCancelamento).Column("motivo_cancelamento");  
		Map(prop => prop.DataSolicitacao).Column("data_solicitacao");  
		Map(prop => prop.EmailEnviado).Column("email_enviado");  
		Map(prop => prop.ComplementoCodPedido).Column("complemento_cod_pedido");  
		Map(prop => prop.DataFinalizacao).Column("data_finalizacao");  
		Map(prop => prop.Finalizado).Column("finalizado");  
		Map(prop => prop.Motivo).Column("motivo");  
			//
		}
	}
}