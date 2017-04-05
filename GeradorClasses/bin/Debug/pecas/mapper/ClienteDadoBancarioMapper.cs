using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ClienteDadoBancarioMapper : ClassMapper<ClienteDadoBancario>
	{
		public ClienteDadoBancarioMapper()
		{
			//
			Schema("pecas");
			Table("clientes_dados_bancarios");
		Map(prop => prop.CodClienteContato).Column("cod_cliente_contato");  
		Map(prop => prop.AlteracaoCodUsuario).Column("alteracao_cod_usuario");  
		Map(prop => prop.RazaoSocial).Column("razao_social");  
		Map(prop => prop.CodBanco).Column("cod_banco");  
		Map(prop => prop.BancoAgencia).Column("banco_agencia");  
		Map(prop => prop.BancoConta).Column("banco_conta");  
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.IdClienteDadoBancario).Column("id_cliente_dado_bancario").Key(KeyType.Identity);  
		Map(prop => prop.BancoNumero).Column("banco_numero");  
		Map(prop => prop.AlteracaoData).Column("alteracao_data");  
		Map(prop => prop.Cnpj).Column("cnpj");  
			//
		}
	}
}