using System;

namespace DobleDesplacho.basic
{
	public class Mujer : Persona
	{
		/// <summary>
		/// Dice al recepcionista vísitame a mi (voz de mujer).
		/// </summary>
		/// <param name="recepcionista"></param>
		public override void Aceptar(Recepcionista recepcionista)
		{
			recepcionista.Visitar(this);
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