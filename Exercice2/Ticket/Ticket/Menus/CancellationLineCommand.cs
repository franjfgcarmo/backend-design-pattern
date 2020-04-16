using Tickets.v1.Utils;

namespace Tickets.v1.Menus
{
    public class CancellationLineCommand : Command
    {
        public CancellationLineCommand(string title) : base(title)
        {

        }

        protected override void Execute()
        {
            int max = Ticket.lines();
            int line = LimitedIntDialog.instance().Read("Línea", max);
            Ticket.add(new CancellationLine(line));
        }
    }
}
