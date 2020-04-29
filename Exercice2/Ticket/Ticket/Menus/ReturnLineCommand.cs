using TPV.v1.Tickets;
using TPV.v1.Utils;

namespace TPV.v1.Menus
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
