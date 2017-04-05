using DapperExtensions.Mapper; 
namespace Prismatec{
	public class OficinaPerguntaQuestionarioMapper : ClassMapper<OficinaPerguntaQuestionario>
	{
		public OficinaPerguntaQuestionarioMapper()
		{
			//
			Schema("pecas");
			Table("oficinas_perguntas_questionario");
		Map(prop => prop.OrdemPergunta).Column("ordem_pergunta");  
		Map(prop => prop.Enunciado).Column("enunciado");  
		Map(prop => prop.MultiplaEscolha).Column("multipla_escolha");  
		Map(prop => prop.IdOficinaPerguntaQuestionario).Column("id_oficina_pergunta_questionario").Key(KeyType.Identity);  
			//
		}
	}
}