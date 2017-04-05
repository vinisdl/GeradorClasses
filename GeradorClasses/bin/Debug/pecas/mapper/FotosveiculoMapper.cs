using DapperExtensions.Mapper; 
namespace Prismatec{
	public class FotosveiculoMapper : ClassMapper<Fotosveiculo>
	{
		public FotosveiculoMapper()
		{
			//
			Schema("pecas");
			Table("fotosveiculos");
		Map(prop => prop.AlteracaoCodUsuario).Column("alteracao_cod_usuario");  
		Map(prop => prop.CodArquivo).Column("cod_arquivo");  
		Map(prop => prop.CodVeiculo).Column("cod_veiculo");  
		Map(prop => prop.IdFotoveiculo).Column("id_fotoveiculo").Key(KeyType.Identity);  
		Map(prop => prop.AlteracaoData).Column("alteracao_data");  
		Map(prop => prop.Descricao).Column("descricao");  
			//
		}
	}
}