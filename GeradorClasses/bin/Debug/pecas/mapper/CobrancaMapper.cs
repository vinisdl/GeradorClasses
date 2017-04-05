using DapperExtensions.Mapper; 
namespace Prismatec{
	public class CobrancaMapper : ClassMapper<Cobranca>
	{
		public CobrancaMapper()
		{
			//
			Schema("pecas");
			Table("cobrancas");
		Map(prop => prop.IdCobranca).Column("id_cobranca").Key(KeyType.Identity);  
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.TelefoneNumero).Column("telefone_numero");  
		Map(prop => prop.Codigo).Column("codigo");  
		Map(prop => prop.TelefoneDdd).Column("telefone_ddd");  
		Map(prop => prop.Contato).Column("contato");  
		Map(prop => prop.Email).Column("email");  
		Map(prop => prop.CodEndereco).Column("cod_endereco");  
		Map(prop => prop.TelefoneRamal).Column("telefone_ramal");  
			//
		}
	}
}