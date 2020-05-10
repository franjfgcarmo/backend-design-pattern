using TPV.v1.Tickets;

namespace TPV.v1.Tickets
{
    public class Footer
    {
        public int TotalPrice { get; private set; }

        public void Accept(ITicketVisitor ticketVisitor) => ticketVisitor.Visit(this);

        public override string ToString() => $"Footer [totalPrice={TotalPrice}]";
    }
}