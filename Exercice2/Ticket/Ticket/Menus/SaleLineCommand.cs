using Tickets.v1.Tickets;
using Tickets.v1.Utils;

namespace Tickets.v1.Menus
{
    public class SaleLineCommand : Command
    {
        
        public SaleLineCommand() : base("Linea de venta")
        {
        }
        public override void Execute()
        {
            int id = LimitedIntDialog.Instance().Read("Código", 1000);
            int units = LimitedIntDialog.Instance().Read("Unidades", 1000);
            Ticket.Add(new SaleLine(id, units));
        }
    }
}
