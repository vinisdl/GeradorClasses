using DapperExtensions.Mapper; 
namespace Prismatec{
	public class FornecedoSumarioPedidoMapper : ClassMapper<FornecedoSumarioPedido>
	{
		public FornecedoSumarioPedidoMapper()
		{
			//
			Schema("pecas");
			Table("fornecedores_sumario_pedidos");
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
		Map(prop => prop.Danfependente).Column("danfependente");  
		Map(prop => prop.Aguardandoentrega).Column("aguardandoentrega");  
		Map(prop => prop.Devolvido).Column("devolvidos").Key(KeyType.Identity);  
		Map(prop => prop.Aguardandoorcamento).Column("aguardandoorcamento");  
		Map(prop => prop.Aguardandoimpressao).Column("aguardandoimpressao");  
		Map(prop => prop.Aguardandoautorizacao).Column("aguardandoautorizacao");  
			//
		}
	}
}