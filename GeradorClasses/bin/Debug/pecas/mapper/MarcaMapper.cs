using DapperExtensions.Mapper; 
namespace Prismatec{
	public class MarcaMapper : ClassMapper<Marca>
	{
		public MarcaMapper()
		{
			//
			Schema("pecas");
			Table("marcas");
		Map(prop => prop.TelefonesacDdd).Column("telefonesac_ddd");  
		Map(prop => prop.AlteracaoCodUsuario).Column("alteracao_cod_usuario");  
		Map(prop => prop.TelefonesacNumero).Column("telefonesac_numero");  
		Map(prop => prop.TelefonesacRamal).Column("telefonesac_ramal");  
		Map(prop => prop.Categoria).Column("categoria");  
		Map(prop => prop.Endereco).Column("endereco");  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.IdMarca).Column("id_marca").Key(KeyType.Identity);  
		Map(prop => prop.Cep).Column("cep");  
		Map(prop => prop.AlteracaoData).Column("alteracao_data");  
			//
		}
	}
}