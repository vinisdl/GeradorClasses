using DapperExtensions.Mapper; 
namespace Prismatec{
	public class OficinaContatoMapper : ClassMapper<OficinaContato>
	{
		public OficinaContatoMapper()
		{
			//
			Schema("pecas");
			Table("oficinas_contatos");
		Map(prop => prop.TelefoneRamal).Column("telefone_ramal");  
		Map(prop => prop.CodOficina).Column("cod_oficina");  
		Map(prop => prop.CelularNumero).Column("celular_numero");  
		Map(prop => prop.CodUsuario).Column("cod_usuario");  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.AlteracaoData).Column("alteracao_data");  
		Map(prop => prop.CelularRamal).Column("celular_ramal");  
		Map(prop => prop.TelefoneDdd).Column("telefone_ddd");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.CelularDdd).Column("celular_ddd");  
		Map(prop => prop.IdOficinaContato).Column("id_oficina_contato").Key(KeyType.Identity);  
		Map(prop => prop.Nextel).Column("nextel");  
		Map(prop => prop.AlteracaoCodUsuario).Column("alteracao_cod_usuario");  
		Map(prop => prop.TelefoneNumero).Column("telefone_numero");  
		Map(prop => prop.Idskype).Column("idskype");  
		Map(prop => prop.TipoContato).Column("tipo_contato");  
		Map(prop => prop.RecebeNotificacao).Column("recebe_notificacao");  
		Map(prop => prop.Email).Column("email");  
			//
		}
	}
}