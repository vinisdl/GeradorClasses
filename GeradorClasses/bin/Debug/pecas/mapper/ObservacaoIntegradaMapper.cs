using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ObservacaoIntegradaMapper : ClassMapper<ObservacaoIntegrada>
	{
		public ObservacaoIntegradaMapper()
		{
			//
			Schema("pecas");
			Table("observacoes_integradas");
		Map(prop => prop.DataCriacao).Column("data_criacao");  
		Map(prop => prop.Confidencial).Column("confidencial").Key(KeyType.Identity);  
		Map(prop => prop.Mensagem).Column("mensagem");  
		Map(prop => prop.IdObservacaoIntegrada).Column("id_observacao_integrada");  
		Map(prop => prop.DataIntegracao).Column("data_integracao");  
		Map(prop => prop.CodPedido).Column("cod_pedido");  
		Map(prop => prop.OpcaoZurich).Column("opcao_zurich");  
		Map(prop => prop.CodigoSinistro).Column("codigo_sinistro");  
		Map(prop => prop.NomeUsuario).Column("nome_usuario");  
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.Gravando).Column("gravando");  
		Map(prop => prop.IntegracaoCilia).Column("integracao_cilia");  
		Map(prop => prop.IntegracaoManual).Column("integracao_manual");  
			//
		}
	}
}