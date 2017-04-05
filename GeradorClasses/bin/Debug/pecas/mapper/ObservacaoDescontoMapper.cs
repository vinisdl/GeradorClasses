using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ObservacaoDescontoMapper : ClassMapper<ObservacaoDesconto>
	{
		public ObservacaoDescontoMapper()
		{
			//
			Schema("pecas");
			Table("observacoes_descontos");
		Map(prop => prop.CriacaoData).Column("criacao_data");  
		Map(prop => prop.CriacaoCodUsuario).Column("criacao_cod_usuario");  
		Map(prop => prop.CodFornecedor).Column("cod_fornecedor");  
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.Motivo).Column("motivo");  
		Map(prop => prop.CriacaoIp).Column("criacao_ip");  
		Map(prop => prop.Conteudo).Column("conteudo");  
		Map(prop => prop.IdObservacaoDesconto).Column("id_observacao_desconto").Key(KeyType.Identity);  
			//
		}
	}
}