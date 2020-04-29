using TPV.v1.Tickets;

namespace TPV.v1.Operations
{
    public abstract class TicketOperation : TicketVisitor
    {
        public Ticket Ticket { protected get; set; }

        public void Visit(Header head)
        {
            
        }

        public void Visit(SaleLine saleLine)
        {
            
        }

        public void Visit(RepetitionLine repetitionLine)
        {
            
        }

        public void Visit(CancellationLine cancellationLine)
        {
            
        }

        public void Visit(ReturnLine returnLine)
        {
            
        }

        public void Visit(Footer footer)
        {
            
        }
    }
}
