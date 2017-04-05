using DapperExtensions.Mapper; 
namespace Prismatec{
	public class LogSolicitacaoRessarcimentoMapper : ClassMapper<LogSolicitacaoRessarcimento>
	{
		public LogSolicitacaoRessarcimentoMapper()
		{
			//
			Schema("pecas");
			Table("logs_solicitacao_ressarcimento");
		Map(prop => prop.Tipo).Column("tipo");  
		Map(prop => prop.Texto).Column("texto");  
		Map(prop => prop.CodSolicitacaoRessarcimento).Column("cod_solicitacao_ressarcimento");  
		Map(prop => prop.IdLogSolicitacaoRessarcimento).Column("id_log_solicitacao_ressarcimento").Key(KeyType.Identity);  
		Map(prop => prop.Data).Column("data");  
		Map(prop => prop.TipoContato).Column("tipo_contato");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
			//
		}
	}
}