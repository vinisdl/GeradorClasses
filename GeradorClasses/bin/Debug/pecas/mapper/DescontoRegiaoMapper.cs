using DapperExtensions.Mapper; 
namespace Prismatec{
	public class DescontoRegiaoMapper : ClassMapper<DescontoRegiao>
	{
		public DescontoRegiaoMapper()
		{
			//
			Schema("pecas");
			Table("descontos_regioes");
		Map(prop => prop.IdDescontoRegiao).Column("id_desconto_regiao").Key(KeyType.Identity);  
		Map(prop => prop.CodFornecedorRegiaoCliente).Column("cod_fornecedor_regiao_cliente");  
		Map(prop => prop.ValorDesconto).Column("valor_desconto");  
		Map(prop => prop.CodFornecedorMarca).Column("cod_fornecedor_marca");  
			//
		}
	}
}