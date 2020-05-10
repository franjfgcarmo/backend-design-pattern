
namespace TPV.v1.Tickets
{
    public class CancellationLine : NumberLine
    {
        public CancellationLine(int number) : base(number)
        {
        }

        public override void Accept(ITicketVisitor ticketVisitor) => ticketVisitor.Visit(this);
        public override string ToString() => "CancellationLine " + base.ToString();
    }
}