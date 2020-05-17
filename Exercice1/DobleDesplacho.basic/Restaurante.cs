using System;
using System.Collections.Generic;
using System.Text;

namespace DobleDesplacho.basic
{
	public class Restaurante
	{
		private Recepcionista recepcionista;

		private Restaurante()
		{
			recepcionista = new Recepcionista();
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
			persona.Despedirse();
			recepcionista.AgradecerVisita();
			Console.WriteLine("... ");
			Console.WriteLine("... pasa el tiempo!");
			Console.WriteLine("... ");
			Console.ReadLine();
		}
	}
}
