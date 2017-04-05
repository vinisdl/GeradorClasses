using DapperExtensions.Mapper; 
namespace Prismatec{
	public class OficinaAlternativaQuestionarioMapper : ClassMapper<OficinaAlternativaQuestionario>
	{
		public OficinaAlternativaQuestionarioMapper()
		{
			//
			Schema("pecas");
			Table("oficinas_alternativas_questionario");
		Map(prop => prop.Descricao).Column("descricao");  
		Map(prop => prop.IdOficinaAlternativaQuestionario).Column("id_oficina_alternativa_questionario").Key(KeyType.Identity);  
		Map(prop => prop.CodOficinaPerguntaQuestionario).Column("cod_oficina_pergunta_questionario");  
		Map(prop => prop.ExibeMarca).Column("exibe_marca");  
		Map(prop => prop.Especificar).Column("especificar");  
			//
		}
	}
}