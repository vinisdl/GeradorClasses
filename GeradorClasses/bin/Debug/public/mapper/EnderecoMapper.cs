using DapperExtensions.Mapper; 
using DapperExtensions.Mapper;
using NetWebAPI.Domain.Entidades.Pecas;namespace Prismatec{
	public class EnderecoMapper : ClassMapper<Endereco>
	{
		public EnderecoMapper()
		{
			//
			Schema("public");
			Table("enderecos");
		Map(prop => prop.CoordenadaGeografica).Column("coordenadas_geograficas");  
		Map(prop => prop.IdEndereco).Column("id_endereco").Key(KeyType.Identity);  
		Map(prop => prop.Bairro).Column("bairro");  
		Map(prop => prop.Complemento).Column("complemento");  
		Map(prop => prop.Logradouro).Column("logradouro");  
		Map(prop => prop.Numero).Column("numero");  
		Map(prop => prop.CodCidade).Column("cod_cidade");  
		Map(prop => prop.Cep).Column("cep");  
			//
		}
	}
}