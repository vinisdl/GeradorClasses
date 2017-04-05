using DapperExtensions.Mapper; 
namespace Prismatec{
	public class FornecedoDadoBancarioClienteMapper : ClassMapper<FornecedoDadoBancarioCliente>
	{
		public FornecedoDadoBancarioClienteMapper()
		{
			//
			Schema("pecas");
			Table("fornecedores_dados_bancarios_clientes");
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.CodFornecedorDadoBancario).Column("cod_fornecedor_dado_bancario");  
		Map(prop => prop.IdFornecedorDadoBancarioCliente).Column("id_fornecedor_dado_bancario_cliente").Key(KeyType.Identity);  
			//
		}
	}
}