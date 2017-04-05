using DapperExtensions.Mapper; 
namespace Prismatec{
	public class AuxiliaAtendimentoClienteMapper : ClassMapper<AuxiliaAtendimentoCliente>
	{
		public AuxiliaAtendimentoClienteMapper()
		{
			//
			Schema("pecas");
			Table("auxiliares_atendimento_clientes");
		Map(prop => prop.IdAuxiliarAtendimentoCliente).Column("id_auxiliar_atendimento_cliente").Key(KeyType.Identity);  
		Map(prop => prop.CodCliente).Column("cod_cliente");  
		Map(prop => prop.CodAuxiliarAtendimento).Column("cod_auxiliar_atendimento");  
			//
		}
	}
}