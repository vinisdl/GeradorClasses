using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ClienteContatoMapper : ClassMapper<ClienteContato>
	{
		public ClienteContatoMapper()
		{
			//
			Schema("pecas");
			Table("clientes_contatos");
		Map(prop => prop.TelefoneRamal).Column("telefone_ramal");  
		Map(prop => prop.Nome).Column("nome");  
		Map(prop => prop.AlteracaoData).Column("alteracao_data");  
		Map(prop => prop.TelefoneDdd).Column("telefone_ddd");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.RecebeRelatorio).Column("recebe_relatorio");  
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.Nextel).Column("nextel");  
		Map(prop => prop.AlteracaoCodUsuario).Column("alteracao_cod_usuario");  
		Map(prop => prop.IdClienteContato).Column("id_cliente_contato").Key(KeyType.Identity);  
		Map(prop => prop.TelefoneNumero).Column("telefone_numero");  
		Map(prop => prop.TipoContato).Column("tipo_contato");  
		Map(prop => prop.RecebeNotificacao).Column("recebe_notificacao");  
		Map(prop => prop.Email).Column("email");  
			//
		}
	}
}