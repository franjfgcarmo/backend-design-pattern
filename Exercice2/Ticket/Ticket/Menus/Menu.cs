using System.Collections.Generic;
using System.Linq;
using Tickets.v1.Menus;
using Tickets.v1.Tickets;
using Tickets.v1.Utils;

namespace Tickets.v1
{
    public abstract class Menu
    {
        protected List<Command> commands;
        private ExitCommand exitCommand;
        public Menu() {
            commands = new List<Command>();
            SetCommand();
            exitCommand = new ExitCommand();
            commands.Add(exitCommand);
        }
        
        //Template Method
        protected abstract void SetCommand();


		protected void Set(Ticket ticket)
		{
			foreach (var command in commands)
			{
				command.Set(ticket);
			}		
		}

		public void Execute(Ticket ticket)
		{
			this.Set(ticket);
			exitCommand.Reset();
			do
			{
				this.Write();
				int option = this.GetOption();
				commands[option].Execute();
			} while (!exitCommand.Closed);
		}

		private void Write()
		{
			IO.Instance().Writeln();
			IO.Instance().Writeln();
			IO.Instance().Writeln("---------------------");
			for (int i = 0; i < commands.Count(); i++)
			{
				IO.Instance().Writeln(
						(i + 1) + ". " + commands[i].Title);
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
