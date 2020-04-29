using Tickets.v1.Tickets;
using Tickets.v1.Utils;

namespace Tickets.v1.Menus
{
    public class CancellationLineCommand : Command
    {
        public CancellationLineCommand() : base("Linea de cancelación")
        {

        }

        public override void Execute()
        {
            int max = Ticket.Lines();
            int line = LimitedIntDialog.Instance().Read("Línea", max);
            Ticket.Add(new CancellationLine(line));
        }
    }
}
