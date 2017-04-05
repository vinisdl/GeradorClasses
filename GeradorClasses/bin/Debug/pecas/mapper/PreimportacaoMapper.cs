using DapperExtensions.Mapper; 
namespace Prismatec{
	public class PreimportacaoMapper : ClassMapper<Preimportacao>
	{
		public PreimportacaoMapper()
		{
			//
			Schema("pecas");
			Table("preimportacoes");
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.IdPreimportacao).Column("id_preimportacao").Key(KeyType.Identity);  
		Map(prop => prop.CriacaoData).Column("criacao_data");  
		Map(prop => prop.Observacao).Column("observacao");  
		Map(prop => prop.CriacaoCodUsuario).Column("criacao_cod_usuario");  
			//
		}
	}
}