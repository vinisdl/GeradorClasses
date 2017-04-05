using DapperExtensions.Mapper; 
namespace Prismatec{
	public class MotivoErroConciliacaoMapper : ClassMapper<MotivoErroConciliacao>
	{
		public MotivoErroConciliacaoMapper()
		{
			//
			Schema("pecas");
			Table("motivos_erro_conciliacao");
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.IdMotivoErroConciliacao).Column("id_motivo_erro_conciliacao").Key(KeyType.Identity);  
			//
		}
	}
}