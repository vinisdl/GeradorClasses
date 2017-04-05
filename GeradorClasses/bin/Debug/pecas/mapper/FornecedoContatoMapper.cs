using DapperExtensions.Mapper; 
namespace Prismatec{
	public class FornecedoContatoMapper : ClassMapper<FornecedoContato>
	{
		public FornecedoContatoMapper()
		{
			//
			Schema("pecas");
			Table("fornecedores_contatos");
		Map(prop => prop.TelefoneRamal).Column("telefone_ramal");  
		Map(prop => prop.AlteracaoCodUsuario).Column("alteracao_cod_usuario");  
		Map(prop => prop.Email).Column("email");  
		Map(prop => prop.UltimoEnvioranking).Column("ultimo_envioranking");  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.TipoContato).Column("tipo_contato");  
		Map(prop => prop.IdFornecedorContato).Column("id_fornecedor_contato").Key(KeyType.Identity);  
		Map(prop => prop.CelularNumero).Column("celular_numero");  
		Map(prop => prop.RecebeNotificacao).Column("recebe_notificacao");  
		Map(prop => prop.RecebeCnf).Column("recebe_cnf");  
		Map(prop => prop.NGestaoFornecedor).Column("n_gestao_fornecedor");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.AlteracaoData).Column("alteracao_data");  
		Map(prop => prop.TelefoneDdd).Column("telefone_ddd");  
		Map(prop => prop.NProcessoEmaberto).Column("n_processos_emaberto");  
		Map(prop => prop.NEntregaAtrasada).Column("n_entrega_atrasada");  
		Map(prop => prop.NItemCancelado).Column("n_itens_cancelados");  
		Map(prop => prop.CelularRamal).Column("celular_ramal");  
		Map(prop => prop.PeriocidadeEnvioranking).Column("periocidade_envioranking");  
		Map(prop => prop.NNovoOrcamento).Column("n_novo_orcamento");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.CelularDdd).Column("celular_ddd");  
		Map(prop => prop.Msn).Column("msn");  
		Map(prop => prop.NPedidoCancelado).Column("n_pedidos_cancelados");  
		Map(prop => prop.NPreventivaEntrega).Column("n_preventiva_entrega");  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
		Map(prop => prop.TelefoneNumero).Column("telefone_numero");  
		Map(prop => prop.Idskype).Column("idskype");  
		Map(prop => prop.Nextel).Column("nextel");  
			//
		}
	}
}