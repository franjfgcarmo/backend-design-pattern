using System;

namespace DobleDespacho.Extensible
{
	public class Mujer : Persona
	{
		public override void Aceptar(IVisitadorPersona visitadorPersona)
		{
			visitadorPersona.Visitar(this);
		}

		public void EscucharHalago()
		{
			Console.WriteLine("++++++++++ Soy una mujer ruborizada");
		}

		public void EscucharPiropo()
		{
			Console.WriteLine("++++++++++ Soy una mujer más ruborizada");
		}
	}
}