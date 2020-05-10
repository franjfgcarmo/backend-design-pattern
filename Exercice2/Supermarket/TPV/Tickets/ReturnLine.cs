using TPV.v1.Tickets;

namespace TPV.v1.Tickets
{
    public class ReturnLine : IdLine
    {
        public ReturnLine(int id, int units) : base(id, units)
        {
        }

        public override void Accept(ITicketVisitor ticketVisitor)
        {
            ticketVisitor.Visit(this);
        }
        public override string ToString()=> $"ReturnLine {base.ToString()}";
        
    }
}