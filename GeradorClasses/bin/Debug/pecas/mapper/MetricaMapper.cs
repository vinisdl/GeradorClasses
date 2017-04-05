using DapperExtensions.Mapper; 
namespace Prismatec{
	public class MetricaMapper : ClassMapper<Metrica>
	{
		public MetricaMapper()
		{
			//
			Schema("pecas");
			Table("metricas");
		Map(prop => prop.PercentualPedidoAtrazado).Column("percentual_pedidos_atrazados").Key(KeyType.Identity);  
		Map(prop => prop.DataCriacao).Column("data_criacao");  
		Map(prop => prop.Tipo).Column("tipo");  
		Map(prop => prop.IdMetrica).Column("id_metrica");  
		Map(prop => prop.PercentualPedidoDevolucaoAberto).Column("percentual_pedidos_devolucao_aberto");  
		Map(prop => prop.PercentualPedidoAlterado).Column("percentual_pedidos_alterados");  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.DataAlteracao).Column("data_alteracao");  
		Map(prop => prop.QuantidadePedidoAutorizado).Column("quantidade_pedidos_autorizados");  
		Map(prop => prop.QuantidadePedidoRecebido).Column("quantidade_pedidos_recebidos");  
		Map(prop => prop.CodUsuarioAlteracao).Column("cod_usuario_alteracao");  
		Map(prop => prop.PercentualSemCotacao).Column("percentual_sem_cotacao");  
		Map(prop => prop.CodUsuarioCriacao).Column("cod_usuario_criacao");  
		Map(prop => prop.QuantidadeDevolucaoEmAberto).Column("quantidade_devolucoes_em_aberto");  
			//
		}
	}
}