using Tickets.v1.Tickets;
using Tickets.v1.Utils;

namespace Tickets.v1.Menus
{
    public class ReturnLineCommand : Command
    {
        public ReturnLineCommand() : base("Linea de devolución")
        {
        }

        public override void Execute()
        {
            int id = LimitedIntDialog.Instance().Read("Código", 1000);
            int units = LimitedIntDialog.Instance().Read("Unidades", 1000);
            Ticket.Add(new ReturnLine(id, units));
        }
    }
}
