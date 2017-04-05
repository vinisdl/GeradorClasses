using DapperExtensions.Mapper; 
namespace Prismatec{
	public class ItensimportacaoMapper : ClassMapper<Itensimportacao>
	{
		public ItensimportacaoMapper()
		{
			//
			Schema("pecas");
			Table("itensimportacao");
		Map(prop => prop.Referencia).Column("referencia");  
		Map(prop => prop.Audatex14StatuRecebido).Column("audatex14_status_recebido").Key(KeyType.Identity);  
		Map(prop => prop.SequenciaVistoria).Column("sequencia_vistoria");  
		Map(prop => prop.CodReferenciaItemportal).Column("cod_referencia_itemportal");  
		Map(prop => prop.AudatexIdentificador).Column("audatex_identificador");  
		Map(prop => prop.Pintar).Column("pintar");  
		Map(prop => prop.Acao).Column("acao");  
		Map(prop => prop.Duplicado).Column("duplicado");  
		Map(prop => prop.Pathnumber).Column("pathnumber");  
		Map(prop => prop.Trocar).Column("trocar");  
		Map(prop => prop.Recuperar).Column("recuperar");  
		Map(prop => prop.Quantidade).Column("quantidade");  
		Map(prop => prop.Descricao).Column("descricao");  
		Map(prop => prop.Idpec).Column("idpec");  
		Map(prop => prop.Audatex14Retorno).Column("audatex14_retorno");  
		Map(prop => prop.CodSegmento).Column("cod_segmento");  
		Map(prop => prop.Fornece).Column("fornece");  
		Map(prop => prop.OrcamentoRetornado).Column("orcamento_retornado");  
		Map(prop => prop.Valorlista).Column("valorlista");  
		Map(prop => prop.IdItemimportacao).Column("id_itemimportacao");  
		Map(prop => prop.ValorOficina).Column("valor_oficina");  
		Map(prop => prop.CodImportacao).Column("cod_importacao");  
			//
		}
	}
}