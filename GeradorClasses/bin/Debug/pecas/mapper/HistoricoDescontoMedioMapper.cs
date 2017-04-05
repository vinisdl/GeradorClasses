using DapperExtensions.Mapper; 
namespace Prismatec{
	public class HistoricoDescontoMedioMapper : ClassMapper<HistoricoDescontoMedio>
	{
		public HistoricoDescontoMedioMapper()
		{
			//
			Schema("pecas");
			Table("historico_desconto_medio");
		Map(prop => prop.DescontoMedio).Column("desconto_medio");  
		Map(prop => prop.DataGeracao).Column("data_geracao");  
		Map(prop => prop.TipoFornecedor).Column("tipo_fornecedor");  
		Map(prop => prop.DescontoMinimo).Column("desconto_minimo");  
		Map(prop => prop.DescontoMaximo).Column("desconto_maximo");  
		Map(prop => prop.CodMarca).Column("cod_marca");  
		Map(prop => prop.CodEstado).Column("cod_estado");  
		Map(prop => prop.IdHistorico).Column("id_historico").Key(KeyType.Identity);  
			//
		}
	}
}