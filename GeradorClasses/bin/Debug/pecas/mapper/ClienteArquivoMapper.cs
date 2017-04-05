using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ClienteArquivoMapper : ClassMapper<ClienteArquivo>
	{
		public ClienteArquivoMapper()
		{
			//
			Schema("pecas");
			Table("clientes_arquivos");
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.IdClienteArquivo).Column("id_cliente_arquivo").Key(KeyType.Identity);  
		Map(prop => prop.CodArquivo).Column("cod_arquivo");  
			//
		}
	}
}