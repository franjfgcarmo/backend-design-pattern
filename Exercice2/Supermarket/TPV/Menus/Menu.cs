using System.Collections.Generic;
using System.Linq;
using TPV.v1.Tickets;
using TPV.v1.Utils;

namespace TPV.v1.Menus
{
	//todo:voy por aquí.
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
