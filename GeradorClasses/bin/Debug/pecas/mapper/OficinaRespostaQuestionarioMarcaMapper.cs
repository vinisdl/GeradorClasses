using DapperExtensions.Mapper; 
namespace Prismatec{
	public class OficinaRespostaQuestionarioMarcaMapper : ClassMapper<OficinaRespostaQuestionarioMarca>
	{
		public OficinaRespostaQuestionarioMarcaMapper()
		{
			//
			Schema("pecas");
			Table("oficinas_respostas_questionario_marcas");
		Map(prop => prop.CodOficinaRespostaQuestionario).Column("cod_oficina_resposta_questionario");  
		Map(prop => prop.IdOficinaRespostaQuestionarioMarca).Column("id_oficina_resposta_questionario_marca").Key(KeyType.Identity);  
		Map(prop => prop.CodMarca).Column("cod_marca");  
			//
		}
	}
}