using DapperExtensions.Mapper; 
namespace Prismatec{
	public class FornecedoMapper : ClassMapper<Fornecedo>
	{
		public FornecedoMapper()
		{
			//
			Schema("pecas");
			Table("fornecedores");
		Map(prop => prop.RazaoSocial).Column("razao_social");  
		Map(prop => prop.Importador).Column("importador");  
		Map(prop => prop.AlteracaoCodUsuario).Column("alteracao_cod_usuario");  
		Map(prop => prop.Contato).Column("contato");  
		Map(prop => prop.CodEndereco).Column("cod_endereco");  
		Map(prop => prop.Email).Column("email");  
		Map(prop => prop.TipoDesconto).Column("tipo_desconto");  
		Map(prop => prop.CnfResponsavel).Column("cnf_responsavel");  
		Map(prop => prop.CadastroLiberado).Column("cadastro_liberado");  
		Map(prop => prop.IdFornecedor).Column("id_fornecedor").Key(KeyType.Identity);  
		Map(prop => prop.PeriodicidadeRanking).Column("periodicidade_ranking");  
		Map(prop => prop.FornecedorDestaque).Column("fornecedor_destaque");  
		Map(prop => prop.Telefone1Numero).Column("telefone1_numero");  
		Map(prop => prop.Telefone2Numero).Column("telefone2_numero");  
		Map(prop => prop.AlteracaoData).Column("alteracao_data");  
		Map(prop => prop.Fax).Column("fax");  
		Map(prop => prop.Telefone2Ddd).Column("telefone2_ddd");  
		Map(prop => prop.RecebePedido).Column("recebe_pedido");  
		Map(prop => prop.FornecedorNovo).Column("fornecedor_novo");  
		Map(prop => prop.Fone2).Column("fone2");  
		Map(prop => prop.EmailEnvioCnf).Column("emails_envio_cnf");  
		Map(prop => prop.Fone1).Column("fone1");  
		Map(prop => prop.CnfTelefoneDdd).Column("cnf_telefone_ddd");  
		Map(prop => prop.BancoAgencia).Column("banco_agencia");  
		Map(prop => prop.AceitaCondicaoData).Column("aceita_condicoes_data");  
		Map(prop => prop.CnfTelefoneNumero).Column("cnf_telefone_numero");  
		Map(prop => prop.NomeFantasia).Column("nome_fantasia");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.SomenteNfe).Column("somente_nfe");  
		Map(prop => prop.InscricaoMunicipal).Column("inscricao_municipal");  
		Map(prop => prop.ModalidadeFrete).Column("modalidade_frete");  
		Map(prop => prop.Interestadual).Column("interestadual");  
		Map(prop => prop.Telefone1Ramal).Column("telefone1_ramal");  
		Map(prop => prop.Codigo).Column("codigo");  
		Map(prop => prop.AceitaCondicaoCodUsuario).Column("aceita_condicoes_cod_usuario");  
		Map(prop => prop.InscricaoEstadual).Column("inscricao_estadual");  
		Map(prop => prop.Telefone2Ramal).Column("telefone2_ramal");  
		Map(prop => prop.CodEstatisticaFornecedor).Column("cod_estatistica_fornecedor");  
		Map(prop => prop.BancoNumero).Column("banco_numero");  
		Map(prop => prop.Telefone1Ddd).Column("telefone1_ddd");  
		Map(prop => prop.BancoConta).Column("banco_conta");  
		Map(prop => prop.Cnpj).Column("cnpj");  
		Map(prop => prop.CnfTelefoneRamal).Column("cnf_telefone_ramal");  
		Map(prop => prop.StatuFornecedor).Column("status_fornecedor");  
		Map(prop => prop.Reserva).Column("reserva");  
		Map(prop => prop.RecebeEmailCotacao).Column("recebe_email_cotacao");  
		Map(prop => prop.DescontoEspecifico).Column("desconto_especifico");  
			//
		}
	}
}