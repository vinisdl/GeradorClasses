using DapperExtensions.Mapper; 
namespace Prismatec{
	public class OficinaMapper : ClassMapper<Oficina>
	{
		public OficinaMapper()
		{
			//
			Schema("pecas");
			Table("oficinas");
		Map(prop => prop.RazaoSocial).Column("razao_social");  
		Map(prop => prop.Telefone3Numero).Column("telefone3_numero");  
		Map(prop => prop.AlteracaoCodUsuario).Column("alteracao_cod_usuario");  
		Map(prop => prop.DataSolicitacaoNegociacao).Column("data_solicitacao_negociacao");  
		Map(prop => prop.Contato).Column("contato");  
		Map(prop => prop.Credenciada).Column("credenciada");  
		Map(prop => prop.CodEndereco).Column("cod_endereco");  
		Map(prop => prop.Email).Column("email");  
		Map(prop => prop.AtendeTelefone).Column("atende_telefone");  
		Map(prop => prop.ChaveAcesso).Column("chave_acesso");  
		Map(prop => prop.Telefone1Numero).Column("telefone1_numero");  
		Map(prop => prop.Telefone2Numero).Column("telefone2_numero");  
		Map(prop => prop.AlteracaoData).Column("alteracao_data");  
		Map(prop => prop.Fax).Column("fax");  
		Map(prop => prop.Telefone2Ddd).Column("telefone2_ddd");  
		Map(prop => prop.IdOficina).Column("id_oficina").Key(KeyType.Identity);  
		Map(prop => prop.Telefone3Ramal).Column("telefone3_ramal");  
		Map(prop => prop.Fone2).Column("fone2");  
		Map(prop => prop.Fone1).Column("fone1");  
		Map(prop => prop.DataConclusaoNegociacao).Column("data_conclusao_negociacao");  
		Map(prop => prop.IdSkype).Column("id_skype");  
		Map(prop => prop.DataChaveAcesso).Column("data_chave_acesso");  
		Map(prop => prop.NomeFantasia).Column("nome_fantasia");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.InscricaoMunicipal).Column("inscricao_municipal");  
		Map(prop => prop.Telefone1Ramal).Column("telefone1_ramal");  
		Map(prop => prop.Codigo).Column("codigo");  
		Map(prop => prop.InscricaoEstadual).Column("inscricao_estadual");  
		Map(prop => prop.Telefone2Ramal).Column("telefone2_ramal");  
		Map(prop => prop.Telefone1Ddd).Column("telefone1_ddd");  
		Map(prop => prop.Cnpj).Column("cnpj");  
		Map(prop => prop.Telefone3Ddd).Column("telefone3_ddd");  
		Map(prop => prop.Nextel).Column("nextel");  
		Map(prop => prop.Observacao).Column("observacao");  
			//
		}
	}
}