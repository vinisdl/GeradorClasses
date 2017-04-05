using DapperExtensions.Mapper; 
namespace Prismatec{
	public class MotivoSolicitacaoDevolucaoMapper : ClassMapper<MotivoSolicitacaoDevolucao>
	{
		public MotivoSolicitacaoDevolucaoMapper()
		{
			//
			Schema("pecas");
			Table("motivos_solicitacao_devolucao");
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.TipoMotivo).Column("tipo_motivo");  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.Tipo).Column("tipo");  
		Map(prop => prop.IdMotivoSolicitacaoDevolucao).Column("id_motivo_solicitacao_devolucao").Key(KeyType.Identity);  
			//
		}
	}
}