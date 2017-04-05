using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AlteracaoPrazoMapper : ClassMapper<AlteracaoPrazo>
	{
		public AlteracaoPrazoMapper()
		{
			//
			Schema("pecas");
			Table("alteracoes_prazos");
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.IdAlteracaoPrazo).Column("id_alteracao_prazo");  
		Map(prop => prop.DataAlteracao).Column("data_alteracao");  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
			//
		}
	}
}