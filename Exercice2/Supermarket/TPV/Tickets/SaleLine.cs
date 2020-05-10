using TPV.v1.Tickets;

namespace TPV.v1.Tickets
{
    public class SaleLine : IdLine
    {
        public SaleLine(int id, int units) : base(id, units)
        {
        }

        public override void Accept(ITicketVisitor ticketVisitor) => ticketVisitor.Visit(this);

        public override string ToString() => $"SaleLine {base.ToString()}";

    }
}