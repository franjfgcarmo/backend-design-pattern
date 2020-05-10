using System.Collections.Generic;
using TPV.v1.Tickets;

namespace TPV.v1.Operations
{
    public class TicketOperationComposite : TicketOperation
    {
        private List<TicketOperation> ticketOperationList;

        public TicketOperationComposite()
        {
            ticketOperationList = new List<TicketOperation>();
        }

        public void Add(TicketOperation ticketOperation)
        {
            ticketOperationList.Add(ticketOperation);
        }

        public override void Set(Ticket ticket)
        {
            base.Set(ticket);
            foreach (var ticketOperation in ticketOperationList)
            {
                ticketOperation.Set(ticket);
            }
        }

        public override void Visit(Header head)
        {
            foreach (var ticketOperation in ticketOperationList)
            {
                ticketOperation.Visit(head);
            }
        }

        public override void Visit(SaleLine saleLine)
        {
            foreach (var ticketOperation in ticketOperationList)
            {
                ticketOperation.Visit(saleLine);
            }
        }

        public override void Visit(RepetitionLine repetitionLine)
        {
            foreach (var ticketOperation in ticketOperationList)
            {
                ticketOperation.Visit(repetitionLine);
            }
        }

        public override void Visit(CancellationLine cancellationLine)
        {
            foreach (var ticketOperation in ticketOperationList)
            {
                ticketOperation.Visit(cancellationLine);
            }
        }

        public override void Visit(ReturnLine returnLine)
        {
            foreach (var ticketOperation in ticketOperationList)
            {
                ticketOperation.Visit(returnLine);
            }
        }

        public override void Visit(Footer footer)
        {
            foreach (var ticketOperation in ticketOperationList)
            {
                ticketOperation.Visit(footer);
            }
        }
    }
}
