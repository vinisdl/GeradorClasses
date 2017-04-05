using DapperExtensions.Mapper; 
namespace Prismatec{
	public class OrigemProblemaMapper : ClassMapper<OrigemProblema>
	{
		public OrigemProblemaMapper()
		{
			//
			Schema("pecas");
			Table("origens_problema");
		Map(prop => prop.Descricao).Column("descricao");  
		Map(prop => prop.IdOrigemProblema).Column("id_origem_problema").Key(KeyType.Identity);  
		Map(prop => prop.CodMotivoAtraso).Column("cod_motivo_atraso");  
			//
		}
	}
}