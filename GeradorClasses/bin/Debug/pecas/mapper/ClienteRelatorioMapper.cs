using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ClienteRelatorioMapper : ClassMapper<ClienteRelatorio>
	{
		public ClienteRelatorioMapper()
		{
			//
			Schema("pecas");
			Table("clientes_relatorios");
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.CodRelatorio).Column("cod_relatorio");  
		Map(prop => prop.IdClienteRelatorio).Column("id_cliente_relatorio").Key(KeyType.Identity);  
			//
		}
	}
}