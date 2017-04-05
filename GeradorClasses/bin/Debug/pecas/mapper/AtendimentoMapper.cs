using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AtendimentoMapper : ClassMapper<Atendimento>
	{
		public AtendimentoMapper()
		{
			//
			Schema("pecas");
			Table("atendimentos");
		Map(prop => prop.IdAtendimento).Column("id_atendimento").Key(KeyType.Identity);  
		Map(prop => prop.CodPedido).Column("cod_pedido");  
		Map(prop => prop.CodUsuarioResponsavel).Column("cod_usuario_responsavel");  
		Map(prop => prop.DataEncerramento).Column("data_encerramento");  
		Map(prop => prop.CodUsuarioCriacao).Column("cod_usuario_criacao");  
		Map(prop => prop.Statu).Column("status");  
		Map(prop => prop.DataReabertura).Column("data_reabertura");  
		Map(prop => prop.CodTipoAtendimento).Column("cod_tipo_atendimento");  
		Map(prop => prop.Descricao).Column("descricao");  
		Map(prop => prop.DataCriacao).Column("data_criacao");  
			//
		}
	}
}