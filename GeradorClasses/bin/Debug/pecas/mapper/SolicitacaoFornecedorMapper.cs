using DapperExtensions.Mapper; 
namespace Prismatec{
	public class SolicitacaoFornecedorMapper : ClassMapper<SolicitacaoFornecedor>
	{
		public SolicitacaoFornecedorMapper()
		{
			//
			Schema("pecas");
			Table("solicitacoes_fornecedor");
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.IdSolicitacaoFornecedor).Column("id_solicitacao_fornecedor");  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
		Map(prop => prop.Resposta).Column("resposta");  
		Map(prop => prop.Mensagem).Column("mensagem");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.DataResposta).Column("data_resposta");  
		Map(prop => prop.DataCriacao).Column("data_criacao");  
			//
		}
	}
}