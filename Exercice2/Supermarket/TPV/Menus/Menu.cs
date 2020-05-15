using System.Collections.Generic;
using System.Linq;
using TPV.v1.Tickets;
using TPV.v1.Utils;

namespace TPV.v1.Menus
{
	/// <summary>
	/// Esta clase se hace por herencia y no por composición porque es sencilla y no queremos dinamismo,
	/// es decir cuando se despliegue en un surpermercado, siempre va a ser español o frances, no va a
	/// ser algunas veces español y otras Frances.
	/// Los patrones tienden a composición, pero hacer aquí la composición no tiene sentido porque tendrías que 
	/// crear una interfaz de la cual heredara menu....
	/// </summary>
	public abstract class Menu
	{
		//LISTA DE comandos
		protected List<Command> commands;
		private ExitCommand exitCommand;//comando salir para todos los paises.
		public Menu()
		{
			commands = new List<Command>();
			SetCommand();//este método es abstracto
			exitCommand = new ExitCommand();
			commands.Add(exitCommand);
		}

		//Template Method
		protected abstract void SetCommand();


		protected void Set(Ticket ticket)
		{
			//a cada comando le dijo sobre que ticket se va ejecutar.
			foreach (var command in commands)
			{
				command.Set(ticket);
			}
		}
		/// <summary>
		/// Se le asignan todos los comandos del menú al ticket, dependiendo de su comfiguración.
		/// </summary>
		/// <param name="ticket"></param>
		public void Execute(Ticket ticket)
		{
			Set(ticket);
			exitCommand.Reset();
			do
			{
				Write();
				var option = GetOption();
				commands[option].Execute();
			} while (!exitCommand.Closed);
		}
		/// <summary>
		/// Escribe los menú que han sido cargado para cada pais
		/// </summary>
		private void Write()
		{
			IO.Instance().Writeln();
			IO.Instance().Writeln();
			IO.Instance().Writeln("---------------------");
			for (int i = 0; i < commands.Count(); i++)
			{
				IO.Instance().Writeln(
						i + 1 + ". " + commands[i].Title);
			}
		}

		private int GetOption()
		{
			return LimitedIntDialog.Instance()
					.Read("Opción", 1, commands.Count()) - 1;
		}

		public bool IsClosed()
		{
			return exitCommand.Closed;
		}
	}
}
