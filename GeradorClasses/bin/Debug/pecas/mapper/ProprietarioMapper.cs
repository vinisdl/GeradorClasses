using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ProprietarioMapper : ClassMapper<Proprietario>
	{
		public ProprietarioMapper()
		{
			//
			Schema("pecas");
			Table("proprietarios");
		Map(prop => prop.FaxRamal).Column("fax_ramal");  
		Map(prop => prop.FaxDdd).Column("fax_ddd");  
		Map(prop => prop.Email).Column("email");  
		Map(prop => prop.CpfCnpj).Column("cpf_cnpj");  
		Map(prop => prop.TelefoneNumero).Column("telefone_numero");  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.Rg).Column("rg");  
		Map(prop => prop.TelefoneDdd).Column("telefone_ddd");  
		Map(prop => prop.FaxNumero).Column("fax_numero");  
		Map(prop => prop.IdProprietario).Column("id_proprietario").Key(KeyType.Identity);  
		Map(prop => prop.CodEndereco).Column("cod_endereco");  
		Map(prop => prop.TelefoneRamal).Column("telefone_ramal");  
			//
		}
	}
}