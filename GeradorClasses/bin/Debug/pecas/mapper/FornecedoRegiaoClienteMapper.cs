using DapperExtensions.Mapper; 
namespace Prismatec{
	public class FornecedoRegiaoClienteMapper : ClassMapper<FornecedoRegiaoCliente>
	{
		public FornecedoRegiaoClienteMapper()
		{
			//
			Schema("pecas");
			Table("fornecedores_regioes_clientes");
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.CodFornecedorRegiao).Column("cod_fornecedor_regiao");  
		Map(prop => prop.IdFornecedorRegiaoCliente).Column("id_fornecedor_regiao_cliente").Key(KeyType.Identity);  
			//
		}
	}
}