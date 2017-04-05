using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AtuacaoBoMapper : ClassMapper<AtuacaoBo>
	{
		public AtuacaoBoMapper()
		{
			//
			Schema("pecas");
			Table("atuacoes_bo");
		Map(prop => prop.Atuacao).Column("atuacao");  
		Map(prop => prop.DataAtuacao).Column("data_atuacao");  
		Map(prop => prop.IdAtuacaoBo).Column("id_atuacao_bo").Key(KeyType.Identity);  
		Map(prop => prop.CodItemBo).Column("cod_item_bo");  
		Map(prop => prop.Statu).Column("status");  
			//
		}
	}
}