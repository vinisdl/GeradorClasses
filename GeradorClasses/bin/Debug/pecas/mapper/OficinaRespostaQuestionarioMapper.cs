using DapperExtensions.Mapper; 
namespace Prismatec{
	public class OficinaRespostaQuestionarioMapper : ClassMapper<OficinaRespostaQuestionario>
	{
		public OficinaRespostaQuestionarioMapper()
		{
			//
			Schema("pecas");
			Table("oficinas_respostas_questionario");
		Map(prop => prop.CodOficina).Column("cod_oficina");  
		Map(prop => prop.DataAlteracao).Column("data_alteracao");  
		Map(prop => prop.RespostaEspecifica).Column("resposta_especifica");  
		Map(prop => prop.CodOficinaAlternativaQuestionario).Column("cod_oficina_alternativa_questionario");  
		Map(prop => prop.CodUsuarioAlteracao).Column("cod_usuario_alteracao");  
		Map(prop => prop.IdOficinaRespostaQuestionario).Column("id_oficina_resposta_questionario").Key(KeyType.Identity);  
			//
		}
	}
}