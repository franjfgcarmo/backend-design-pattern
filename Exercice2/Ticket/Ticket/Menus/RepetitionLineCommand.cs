using Tickets.v1.Tickets;
using Tickets.v1.Utils;

namespace Tickets.v1.Menus
{
    public class RepetitionLineCommand : Command
    {

        public RepetitionLineCommand() : base("Linea de repetición")
        {
        }

        public override void Execute()
        {
            int max = Ticket.Lines();
            int line = LimitedIntDialog.Instance().Read("Línea? ", max);
            Ticket.Add(new RepetitionLine(line));
        }
    }
}
