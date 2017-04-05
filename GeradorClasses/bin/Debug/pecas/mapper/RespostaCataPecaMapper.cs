using DapperExtensions.Mapper; 
namespace Prismatec{
	public class RespostaCataPecaMapper : ClassMapper<RespostaCataPeca>
	{
		public RespostaCataPecaMapper()
		{
			//
			Schema("pecas");
			Table("respostas_cata_pecas");
		Map(prop => prop.PossuiItem).Column("possui_item");  
		Map(prop => prop.Desconto).Column("desconto");  
		Map(prop => prop.IdRespostaCatapeca).Column("id_resposta_catapeca").Key(KeyType.Identity);  
		Map(prop => prop.CodItempedido).Column("cod_itempedido");  
		Map(prop => prop.ValorBruto).Column("valor_bruto");  
		Map(prop => prop.PathnumberAlternativo).Column("pathnumber_alternativo");  
		Map(prop => prop.DataInformada).Column("data_informada");  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
		Map(prop => prop.ForneceItem).Column("fornece_item");  
		Map(prop => prop.Prazo).Column("prazo");  
			//
		}
	}
}