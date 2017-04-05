using DapperExtensions.Mapper; 
namespace Prismatec{
	public class MotivoAtrasoMapper : ClassMapper<MotivoAtraso>
	{
		public MotivoAtrasoMapper()
		{
			//
			Schema("pecas");
			Table("motivos_atraso");
		Map(prop => prop.Descricao).Column("descricao");  
		Map(prop => prop.IdMotivoAtraso).Column("id_motivo_atraso").Key(KeyType.Identity);  
			//
		}
	}
}