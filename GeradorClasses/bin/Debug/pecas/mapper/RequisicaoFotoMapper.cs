using DapperExtensions.Mapper; 
namespace Prismatec{
	public class RequisicaoFotoMapper : ClassMapper<RequisicaoFoto>
	{
		public RequisicaoFotoMapper()
		{
			//
			Schema("pecas");
			Table("requisicoes_fotos");
		Map(prop => prop.CodPedido).Column("cod_pedido").Key(KeyType.Identity);  
		Map(prop => prop.IdRequisicaoFoto).Column("id_requisicao_fotos");  
		Map(prop => prop.CodSeguradora).Column("cod_seguradora");  
		Map(prop => prop.CodigoSinistro).Column("codigo_sinistro");  
		Map(prop => prop.LinkFoto).Column("link_fotos");  
		Map(prop => prop.CodVeiculo).Column("cod_veiculo");  
		Map(prop => prop.DataImportacao).Column("data_importacao");  
		Map(prop => prop.DataCriacao).Column("data_criacao");  
			//
		}
	}
}