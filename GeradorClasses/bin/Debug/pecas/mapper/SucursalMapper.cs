using DapperExtensions.Mapper; 
namespace Prismatec{
	public class SucursalMapper : ClassMapper<Sucursal>
	{
		public SucursalMapper()
		{
			//
			Schema("pecas");
			Table("sucursais");
		Map(prop => prop.Telefone1Ramal).Column("telefone1_ramal");  
		Map(prop => prop.Email).Column("email");  
		Map(prop => prop.Contato).Column("contato");  
		Map(prop => prop.CodEndereco).Column("cod_endereco");  
		Map(prop => prop.RazaoSocial).Column("razao_social");  
		Map(prop => prop.IdSucursal).Column("id_sucursal").Key(KeyType.Identity);  
		Map(prop => prop.Telefone2Numero).Column("telefone2_numero");  
		Map(prop => prop.AlteracaoData).Column("alteracao_data");  
		Map(prop => prop.Codigo).Column("codigo");  
		Map(prop => prop.InscricaoEstadual).Column("inscricao_estadual");  
		Map(prop => prop.Telefone1Numero).Column("telefone1_numero");  
		Map(prop => prop.Fax).Column("fax");  
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.NomeFantasia).Column("nome_fantasia");  
		Map(prop => prop.AlteracaoCodUsuario).Column("alteracao_cod_usuario");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.InscricaoMunicipal).Column("inscricao_municipal");  
		Map(prop => prop.Telefone2Ddd).Column("telefone2_ddd");  
		Map(prop => prop.Telefone1Ddd).Column("telefone1_ddd");  
		Map(prop => prop.Telefone2Ramal).Column("telefone2_ramal");  
		Map(prop => prop.CodCobranca).Column("cod_cobranca");  
		Map(prop => prop.Cnpj).Column("cnpj");  
			//
		}
	}
}