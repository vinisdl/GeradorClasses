using DapperExtensions.Mapper; 
namespace Prismatec{
	public class LogSolicitacaoPagamentoMapper : ClassMapper<LogSolicitacaoPagamento>
	{
		public LogSolicitacaoPagamentoMapper()
		{
			//
			Schema("pecas");
			Table("logs_solicitacao_pagamento");
		Map(prop => prop.Tipo).Column("tipo");  
		Map(prop => prop.Texto).Column("texto");  
		Map(prop => prop.Data).Column("data");  
		Map(prop => prop.TipoContato).Column("tipo_contato");  
		Map(prop => prop.IdLogSolicitacaoPagamento).Column("id_log_solicitacao_pagamento").Key(KeyType.Identity);  
		Map(prop => prop.CodSolicitacaoPagamento).Column("cod_solicitacao_pagamento");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
			//
		}
	}
}