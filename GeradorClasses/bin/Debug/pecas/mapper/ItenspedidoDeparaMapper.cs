using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ItenspedidoDeparaMapper : ClassMapper<ItenspedidoDepara>
	{
		public ItenspedidoDeparaMapper()
		{
			//
			Schema("pecas");
			Table("itenspedido_depara");
		Map(prop => prop.CodItempedido).Column("cod_itempedido").Key(KeyType.Identity);  
		Map(prop => prop.CodMotivoDevolucao).Column("cod_motivo_devolucao");  
		Map(prop => prop.CodSolicitacaoDepara).Column("cod_solicitacao_depara");  
		Map(prop => prop.SubDescricao).Column("sub_descricao");  
		Map(prop => prop.ValorBrutoOriginal).Column("valor_bruto_original");  
		Map(prop => prop.CodArquivoImagemCatalogo).Column("cod_arquivo_imagem_catalogo");  
		Map(prop => prop.IdItempedidoDepara).Column("id_itempedido_depara");  
		Map(prop => prop.SubPathnumber).Column("sub_pathnumber");  
		Map(prop => prop.SubValorBruto).Column("sub_valor_bruto");  
		Map(prop => prop.Procede).Column("procede");  
		Map(prop => prop.Motivo).Column("motivo");  
			//
		}
	}
}