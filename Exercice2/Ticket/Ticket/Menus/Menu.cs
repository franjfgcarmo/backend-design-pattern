using System.Collections.Generic;
using Tickets.v1.Menus;

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
        public void Execute(Ticket ticket) {
            var exit = false;
            do
            {

            } while (!exit);
        }
        //Template Method
        protected abstract void SetCommand();
    }
}
