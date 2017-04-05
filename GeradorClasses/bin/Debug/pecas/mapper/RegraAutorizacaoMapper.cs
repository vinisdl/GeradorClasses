using DapperExtensions.Mapper; 
namespace Prismatec{
	public class RegraAutorizacaoMapper : ClassMapper<RegraAutorizacao>
	{
		public RegraAutorizacaoMapper()
		{
			//
			Schema("pecas");
			Table("regras_autorizacao");
		Map(prop => prop.DataAlteracaoRegrasautorizacao).Column("data_alteracao_regrasautorizacao");  
		Map(prop => prop.MargemIdadeVeiculo).Column("margem_idade_veiculo").Key(KeyType.Identity);  
		Map(prop => prop.AutorizacaoAutomatica).Column("autorizacao_automatica");  
		Map(prop => prop.CodUsuarioAlteracaoRegrasautorizacao).Column("cod_usuario_alteracao_regrasautorizacao");  
		Map(prop => prop.OrdemEscolhaPeca).Column("ordem_escolha_peca");  
		Map(prop => prop.MargemParticipacaoDistribuidor).Column("margem_participacao_distribuidor");  
		Map(prop => prop.MargemPedido).Column("margem_pedido");  
		Map(prop => prop.FornecimentoInterestadual).Column("fornecimento_interestadual");  
		Map(prop => prop.PrazoMaximo).Column("prazo_maximo");  
		Map(prop => prop.PermiteSubstituida).Column("permite_substituida");  
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.IdRegraAutorizacao).Column("id_regra_autorizacao");  
		Map(prop => prop.TempoAutorizacao).Column("tempo_autorizacao");  
			//
		}
	}
}