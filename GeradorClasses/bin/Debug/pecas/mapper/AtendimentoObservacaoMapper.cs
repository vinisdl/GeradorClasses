using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AtendimentoObservacaoMapper : ClassMapper<AtendimentoObservacao>
	{
		public AtendimentoObservacaoMapper()
		{
			//
			Schema("pecas");
			Table("atendimentos_observacoes");
		Map(prop => prop.Mensagem).Column("mensagem");  
		Map(prop => prop.IdAtendimentoObservacao).Column("id_atendimento_observacao").Key(KeyType.Identity);  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.DataCriacao).Column("data_criacao");  
		Map(prop => prop.CodAtendimento).Column("cod_atendimento");  
			//
		}
	}
}