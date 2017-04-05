using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ObservacoesfornecedoMapper : ClassMapper<Observacoesfornecedo>
	{
		public ObservacoesfornecedoMapper()
		{
			//
			Schema("pecas");
			Table("observacoesfornecedores");
		Map(prop => prop.CriacaoData).Column("criacao_data");  
		Map(prop => prop.CriacaoCodUsuario).Column("criacao_cod_usuario");  
		Map(prop => prop.IdObservacaofornecedor).Column("id_observacaofornecedor").Key(KeyType.Identity);  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
		Map(prop => prop.CriacaoIp).Column("criacao_ip");  
		Map(prop => prop.Conteudo).Column("conteudo");  
			//
		}
	}
}