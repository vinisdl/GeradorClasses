using DapperExtensions.Mapper; 
using DapperExtensions.Mapper;
using NetWebAPI.Domain.Entidades.Pecas;namespace Prismatec{
	public class VAuxiliarDispMapper : ClassMapper<VAuxiliarDisp>
	{
		public VAuxiliarDispMapper()
		{
			//
			Schema("public");
			Table("v_auxiliar_disp");
		Map(prop => prop.FnAuxiliarDisponivel).Column("fn_auxiliar_disponivel");  
			//
		}
	}
}