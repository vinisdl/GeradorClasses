using DapperExtensions.Mapper; 
namespace Prismatec{
	public class UsuarioMapper : ClassMapper<Usuario>
	{
		public UsuarioMapper()
		{
			//
			Schema("seguranca");
			Table("usuarios");
		Map(prop => prop.AuxiliarFase2).Column("auxiliar_fase2");  
		Map(prop => prop.StatuLogistica).Column("status_logistica");  
		Map(prop => prop.UltimoLoginIp).Column("ultimo_login_ip");  
		Map(prop => prop.OrdemLogistica).Column("ordem_logistica");  
		Map(prop => prop.Senha).Column("senha");  
		Map(prop => prop.CodPerito).Column("cod_perito");  
		Map(prop => prop.Username).Column("username");  
		Map(prop => prop.UltimoLoginData).Column("ultimo_login_data");  
		Map(prop => prop.TokenRecuperacaoSenha).Column("token_recuperacao_senha");  
		Map(prop => prop.NomeCompleto).Column("nome_completo");  
		Map(prop => prop.Ativo).Column("ativo");  
		Map(prop => prop.CnpjCpf).Column("cnpj_cpf");  
		Map(prop => prop.NomeRazaoSocial).Column("nome_razao_social");  
		Map(prop => prop.Habilitado).Column("habilitado");  
		Map(prop => prop.UltimaSenha).Column("ultimas_senhas");  
		Map(prop => prop.DataTrocaSenha).Column("data_troca_senha");  
		Map(prop => prop.CodOficina).Column("cod_oficina");  
		Map(prop => prop.IdUsuario).Column("id_usuario").Key(KeyType.Identity);  
		Map(prop => prop.CriacaoData).Column("criacao_data");  
		Map(prop => prop.Email).Column("email");  
			//
		}
	}
}