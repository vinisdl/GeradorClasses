using DapperExtensions.Mapper; 
namespace Prismatec{
	public class SelecaoClienteMapper : ClassMapper<SelecaoCliente>
	{
		public SelecaoClienteMapper()
		{
			//
			Schema("pecas");
			Table("selecoes_clientes");
		Map(prop => prop.Codigo).Column("codigo");  
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.SelecaoCodCliente).Column("selecao_cod_cliente");  
		Map(prop => prop.IdSelecaoCliente).Column("id_selecao_cliente").Key(KeyType.Identity);  
			//
		}
	}
}