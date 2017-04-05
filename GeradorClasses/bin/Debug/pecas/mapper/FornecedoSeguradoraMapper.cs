using DapperExtensions.Mapper; 
namespace Prismatec{
	public class FornecedoSeguradoraMapper : ClassMapper<FornecedoSeguradora>
	{
		public FornecedoSeguradoraMapper()
		{
			//
			Schema("pecas");
			Table("fornecedores_seguradoras");
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.IdFornecedorSeguradora).Column("id_fornecedor_seguradora").Key(KeyType.Identity);  
		Map(prop => prop.CodigoSeguradora).Column("codigo_seguradora");  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
			//
		}
	}
}