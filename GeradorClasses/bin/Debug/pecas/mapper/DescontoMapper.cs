using DapperExtensions.Mapper; 
namespace Prismatec{
	public class DescontoMapper : ClassMapper<Desconto>
	{
		public DescontoMapper()
		{
			//
			Schema("pecas");
			Table("descontos");
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.IdDesconto).Column("id_desconto").Key(KeyType.Identity);  
		Map(prop => prop.ValorDesconto).Column("valor_desconto");  
		Map(prop => prop.Interestadual).Column("interestadual");  
		Map(prop => prop.CodFornecedorMarca).Column("cod_fornecedor_marca");  
			//
		}
	}
}