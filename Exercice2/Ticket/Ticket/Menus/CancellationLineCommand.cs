using TPV.v1.Tickets;
using TPV.v1.Utils;

namespace TPV.v1.Menus
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
