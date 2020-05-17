using TPV.v1.Tickets;

namespace TPV.v1.Tickets
{
    public abstract class Line
    {
        public int Price { get; set; }
        /// <summary>
        /// everyone line have to accept the visitor
        /// </summary>
        /// <param name="ticketVisitor"></param>
        public abstract void Accept(ITicketVisitor ticketVisitor);
        public override string ToString() => $",price={Price}";
    }
}