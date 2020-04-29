using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.v1.Countries;
using Tickets.v1.Tickets;

namespace Tickets.v1.SpanishConfiguration
{
    public class SpanishTicketBuilder : TicketBuilder
    {
        public override Ticket Build()
        {
			TicketOperationComposite lineTicketOperationComposite = new TicketOperationComposite();
			lineTicketOperationComposite.add(new PriceCalculatorOperation());
			lineTicketOperationComposite.add(new ClientPrinterOperation());
			lineTicketOperationComposite.add(new TaxPrinterOperation());
			lineTicketOperation = lineTicketOperationComposite;
			TicketOperationComposite globalTicketOperationComposite = new TicketOperationComposite();
			lineTicketOperationComposite.add(new PriceCalculatorOperation());
			lineTicketOperationComposite.add(new ClientPrinterOperation());
			lineTicketOperationComposite.add(new TaxPrinterOperation());
			globalTicketOperation = globalTicketOperationComposite;
		}
    }
}
