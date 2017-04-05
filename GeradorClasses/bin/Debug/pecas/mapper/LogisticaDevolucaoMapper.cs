using DapperExtensions.Mapper; 
namespace Prismatec{
	public class LogisticaDevolucaoMapper : ClassMapper<LogisticaDevolucao>
	{
		public LogisticaDevolucaoMapper()
		{
			//
			Schema("pecas");
			Table("logisticas_devolucao");
		Map(prop => prop.CodPedidoFornecedor).Column("cod_pedido_fornecedor").Key(KeyType.Identity);  
		Map(prop => prop.DataNovoContato).Column("data_novo_contato");  
		Map(prop => prop.DataEncerramento).Column("data_encerramento");  
		Map(prop => prop.AuxiliarCodUsuario).Column("auxiliar_cod_usuario");  
		Map(prop => prop.IdLogisticaDevolucao).Column("id_logistica_devolucao");  
		Map(prop => prop.DataLocacao).Column("data_locacao");  
		Map(prop => prop.EncerramentoCodUsuario).Column("encerramento_cod_usuario");  
		Map(prop => prop.CodSituacaoLogisticaDevolucao).Column("cod_situacao_logistica_devolucao");  
		Map(prop => prop.SituacaoOficina).Column("situacao_oficina");  
		Map(prop => prop.SituacaoFornecedor).Column("situacao_fornecedor");  
		Map(prop => prop.DataCriacao).Column("data_criacao");  
			//
		}
	}
}