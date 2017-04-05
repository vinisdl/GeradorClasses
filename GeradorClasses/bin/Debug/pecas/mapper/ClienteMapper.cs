using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ClienteMapper : ClassMapper<Cliente>
	{
		public ClienteMapper()
		{
			//
			Schema("pecas");
			Table("clientes");
		Map(prop => prop.RazaoSocial).Column("razao_social");  
		Map(prop => prop.MargemNf).Column("margem_nf");  
		Map(prop => prop.PreencheOrdemServicoFornecedor).Column("preenche_ordem_servico_fornecedor");  
		Map(prop => prop.Pintura).Column("pintura");  
		Map(prop => prop.InscricaoEstadual).Column("inscricao_estadual");  
		Map(prop => prop.TokenAcesso).Column("token_acesso");  
		Map(prop => prop.Contato).Column("contato");  
		Map(prop => prop.PrazoReenvioCnf).Column("prazo_reenvio_cnf");  
		Map(prop => prop.Email).Column("email");  
		Map(prop => prop.CodArquivoLogotipo).Column("cod_arquivo_logotipo");  
		Map(prop => prop.CodEndereco).Column("cod_endereco");  
		Map(prop => prop.IdCliente).Column("id_cliente").Key(KeyType.Identity);  
		Map(prop => prop.MostraFornecedorIntegracao).Column("mostra_fornecedor_integracao");  
		Map(prop => prop.Funilaria).Column("funilaria");  
		Map(prop => prop.ExtratoPagamentoObrigatorio).Column("extrato_pagamento_obrigatorio");  
		Map(prop => prop.AlteracaoCodUsuario).Column("alteracao_cod_usuario");  
		Map(prop => prop.ValorMaoObraAcumulada).Column("valor_mao_obra_acumulada");  
		Map(prop => prop.PrazoInicioConciliacao).Column("prazo_inicio_conciliacao");  
		Map(prop => prop.PossuiListaAnalista).Column("possui_lista_analista");  
		Map(prop => prop.TipoPessoaFaturar).Column("tipo_pessoa_faturar");  
		Map(prop => prop.ValidacaoAutomaticaPdf).Column("validacao_automatica_pdf");  
		Map(prop => prop.Telefone1Numero).Column("telefone1_numero");  
		Map(prop => prop.Telefone2Numero).Column("telefone2_numero");  
		Map(prop => prop.AlteracaoData).Column("alteracao_data");  
		Map(prop => prop.Fax).Column("fax");  
		Map(prop => prop.FaturarTerceiro).Column("faturar_terceiro");  
		Map(prop => prop.EmailNotificacao).Column("email_notificacoes");  
		Map(prop => prop.Telefone2Ddd).Column("telefone2_ddd");  
		Map(prop => prop.DesejaEmailConciliacao).Column("deseja_email_conciliacao");  
		Map(prop => prop.AutorizacaoSucursal).Column("autorizacao_sucursal");  
		Map(prop => prop.CodEnderecoEnvioNotaFiscal).Column("cod_endereco_envio_notas_fiscais");  
		Map(prop => prop.PossuiIntegracaoObservacao).Column("possui_integracao_observacoes");  
		Map(prop => prop.Codigo).Column("codigo");  
		Map(prop => prop.CadastroLiberado).Column("cadastro_liberado");  
		Map(prop => prop.TipoCliente).Column("tipo_cliente");  
		Map(prop => prop.CategoriaMarca).Column("categorias_marcas");  
		Map(prop => prop.PossuiListaPerito).Column("possui_lista_perito");  
		Map(prop => prop.AtendeSegmentoNaoHomologado).Column("atende_segmentos_nao_homologados");  
		Map(prop => prop.Tapecaria).Column("tapecaria");  
		Map(prop => prop.NomeFantasia).Column("nome_fantasia");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.PossuiIntegracaoAudatex14).Column("possui_integracao_audatex14");  
		Map(prop => prop.PrazoPagamentoFornecedo).Column("prazo_pagamento_fornecedores");  
		Map(prop => prop.RecebeRelPedidoRecebido).Column("recebe_rel_pedidos_recebidos");  
		Map(prop => prop.InscricaoMunicipal).Column("inscricao_municipal");  
		Map(prop => prop.AtendeSegmentoHomologado).Column("atende_segmentos_homologados");  
		Map(prop => prop.AtendeOficinaParticula).Column("atende_oficinas_particulares");  
		Map(prop => prop.Telefone1Ramal).Column("telefone1_ramal");  
		Map(prop => prop.DataAlteracaoRegrasautorizacao).Column("data_alteracao_regrasautorizacao");  
		Map(prop => prop.PossuiPedidofiscal).Column("possui_pedidofiscal");  
		Map(prop => prop.Telefone2Ramal).Column("telefone2_ramal");  
		Map(prop => prop.CodUsuarioAlteracaoRegrasautorizacao).Column("cod_usuario_alteracao_regrasautorizacao");  
		Map(prop => prop.ObrigaDataRecebimentoPedido).Column("obriga_data_recebimento_pedido");  
		Map(prop => prop.ObrigaEnvioOrdemCompra).Column("obriga_envio_ordem_compra");  
		Map(prop => prop.MargemPedido).Column("margem_pedido");  
		Map(prop => prop.Telefone1Ddd).Column("telefone1_ddd");  
		Map(prop => prop.LinkAgendaInterna).Column("link_agenda_interna");  
		Map(prop => prop.Cnpj).Column("cnpj");  
		Map(prop => prop.SinistroComVistoria).Column("sinistro_com_vistoria");  
		Map(prop => prop.PrazoInicioLogisticaDevolucao).Column("prazo_inicio_logistica_devolucao");  
		Map(prop => prop.CodCobranca).Column("cod_cobranca");  
		Map(prop => prop.Mecanica).Column("mecanica");  
		Map(prop => prop.EmailDevolucao).Column("email_devolucao");  
		Map(prop => prop.Eletrica).Column("eletrica");  
			//
		}
	}
}