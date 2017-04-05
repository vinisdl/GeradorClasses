using DapperExtensions.Mapper; 
namespace Prismatec{
	public class FornecedoDadoBancarioMapper : ClassMapper<FornecedoDadoBancario>
	{
		public FornecedoDadoBancarioMapper()
		{
			//
			Schema("pecas");
			Table("fornecedores_dados_bancarios");
		Map(prop => prop.CodFornecedorContato).Column("cod_fornecedor_contato");  
		Map(prop => prop.AlteracaoCodUsuario).Column("alteracao_cod_usuario");  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
		Map(prop => prop.BancoAgencia).Column("banco_agencia");  
		Map(prop => prop.BancoConta).Column("banco_conta");  
		Map(prop => prop.IdFornecedorDadoBancario).Column("id_fornecedor_dado_bancario").Key(KeyType.Identity);  
		Map(prop => prop.CodBanco).Column("cod_banco");  
		Map(prop => prop.BancoNumero).Column("banco_numero");  
		Map(prop => prop.AlteracaoData).Column("alteracao_data");  
			//
		}
	}
}