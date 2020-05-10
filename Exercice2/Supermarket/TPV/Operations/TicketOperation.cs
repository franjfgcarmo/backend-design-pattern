using TPV.v1.Tickets;

namespace TPV.v1.Operations
{
    /// <summary>
    /// This is a Hook method, esto permite a las clases hija no implementar 
    /// toda la interfaz, sólo define los métodos que necesita
    /// </summary>
    public abstract class TicketOperation : ITicketVisitor
    {
        protected Ticket ticket;

        public virtual void Set(Ticket ticket)
        {
            this.ticket = ticket;
        }

        public virtual void Visit(Header head)
        {
            
        }

        public virtual void Visit(SaleLine saleLine)
        {
            
        }

        public virtual void Visit(RepetitionLine repetitionLine)
        {
            
        }

        public virtual void Visit(CancellationLine cancellationLine)
        {
            
        }

        public virtual void Visit(ReturnLine returnLine)
        {
            
        }

        public virtual void Visit(Footer footer)
        {
            
        }
    }
}
