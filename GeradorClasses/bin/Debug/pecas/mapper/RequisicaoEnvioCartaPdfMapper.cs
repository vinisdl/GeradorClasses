using DapperExtensions.Mapper; 
namespace Prismatec{
	public class RequisicaoEnvioCartaPdfMapper : ClassMapper<RequisicaoEnvioCartaPdf>
	{
		public RequisicaoEnvioCartaPdfMapper()
		{
			//
			Schema("pecas");
			Table("requisicoes_envio_carta_pdf");
		Map(prop => prop.CodigoSinistro).Column("codigo_sinistro");  
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.IdRequisicaoEnvioCartaPdf).Column("id_requisicao_envio_carta_pdf");  
		Map(prop => prop.CodArquivo).Column("cod_arquivo");  
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.CriacaoCodUsuario).Column("criacao_cod_usuario");  
		Map(prop => prop.Conteudo).Column("conteudo");  
		Map(prop => prop.DataImportacao).Column("data_importacao");  
		Map(prop => prop.DataCriacao).Column("data_criacao");  
			//
		}
	}
}