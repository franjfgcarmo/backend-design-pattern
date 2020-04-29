using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.v1.Tickets;

namespace Tickets.v1.Operations
{
    public abstract class TicketOperation : TicketVisitor    
    {
        public Ticket Ticket { protected get; set; }

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
