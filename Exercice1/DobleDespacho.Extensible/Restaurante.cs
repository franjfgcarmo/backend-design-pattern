using System;
using System.Collections.Generic;
using System.Text;

namespace DobleDespacho.Extensible
{
	public class Restaurante
	{
		private Recepcionista recepcionista;
		private Camarero camarero;
		private Restaurante()
		{
			recepcionista = new Recepcionista();
			camarero = new Camarero();
		}

		public static void Main()
		{
			new Restaurante().SimularEscenario();
		}

		private void SimularEscenario()
		{

			for (int i = 0; i < 5; i++)
			{
				Persona persona;
				if (new Random().Next(0, 2) == 0)
				{
					persona = new Hombre();
				}
				else
				{
					persona = new Mujer();
				}
				SimularEscenario(persona);
			}
		}

		private void SimularEscenario(Persona persona)
		{
			persona.Saludar();
			recepcionista.Recibir(persona);
			persona.Pedir();
			camarero.Servir(persona);
			persona.Despedirse();
			camarero.Recoger();
			recepcionista.AgradecerVisita();
			Console.WriteLine("... ");
			Console.WriteLine("... pasa el tiempo!");
			Console.WriteLine("... ");
			Console.ReadLine();
		}
	}
}
